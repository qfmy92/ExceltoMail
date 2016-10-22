using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceltoMail
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        public class Email
        {
            /// <summary>
            /// 收件人
            /// </summary>
            public string[] ReciveMailAdress { get; set; }

            /// <summary>
            /// 发件人
            /// </summary>
            public string SendMailAdress { get; set; }

            /// <summary>
            /// 标题
            /// </summary>
            public string MailSubject { get; set; }

            /// <summary>
            /// 正文
            /// </summary>
            public string MailBody { get; set; }

            /// <summary>
            /// 用户名
            /// </summary>
            public string MailUser { get; set; }

            /// <summary>
            /// 用户密码
            /// </summary>
            public string MailPwd { get; set; }

            /// <summary>
            /// SMTP邮件服务器
            /// </summary>
            public string host { get; set; }

            public bool Send()
            {
                //使用指定的邮件地址初始化MailAddress实例
                MailAddress maddr = new MailAddress(SendMailAdress);
                //初始化MailMessage实例
                MailMessage myMail = new MailMessage();

                //收件人地址
                if (ReciveMailAdress != null)
                {
                    for (int i = 0; i < ReciveMailAdress.Length; i++)
                    {
                        myMail.To.Add(ReciveMailAdress[i].ToString());
                    }
                }

                //发件人地址
                myMail.From = maddr;

                //电子邮件的标题
                myMail.Subject = MailSubject;

                //电子邮件的主题内容使用的编码
                myMail.SubjectEncoding = Encoding.UTF8;

                //电子邮件正文
                myMail.Body = MailBody;

                //电子邮件正文的编码
                myMail.BodyEncoding = Encoding.Default;

                //myMail.Priority = MailPriority.High;

                myMail.IsBodyHtml = false;

                SmtpClient sc = new SmtpClient();
                //指定发件人的邮件地址和密码以验证发件人身份
                sc.Credentials = new System.Net.NetworkCredential(MailUser, MailPwd);

                //设置SMTP邮件服务器
                sc.Host = host;

                try
                {
                    //将邮件发送到SMTP邮件服务器
                    sc.Send(myMail);
                    return true;

                }
                catch (System.Net.Mail.SmtpException ex)
                {
                    return false;
                }

            }
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            if (MB_text.Text != "" || RMA_text.Text != ""|| SMA_text.Text != ""|| MS_text.Text != "")
            {
                Email email = new Email();
                email.SendMailAdress = SMA_text.Text;
                email.ReciveMailAdress = new string[] { RMA_text.Text };
                email.MailSubject = MS_text.Text;
                email.MailUser = MU_text.Text;
                email.MailPwd = MP_text.Text;
                email.MailBody = MB_text.Text;
                email.host = host_text.Text;
                if (email.Send())
                {
                    Msg_listbox.Items.Add("发往" + RMA_text.Text + "的邮件已发送成功！");
                }
                else
                {
                    Msg_listbox.Items.Add("发往" + RMA_text.Text + "的邮件发送失败！");
                }
            }
            else
            {
                MessageBox.Show("请不要留空！");
            }
        }


        public static DataSet ToDataTable(string filePath)
        {
            string connStr = "";
            string fileType = System.IO.Path.GetExtension(filePath);
            if (string.IsNullOrEmpty(fileType)) return null;

            if (fileType == ".xls")
                connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filePath + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
            else
                connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + filePath + ";" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";
            string sql_F = "Select * FROM [{0}]";

            OleDbConnection conn = null;
            OleDbDataAdapter da = null;
            DataTable dtSheetName = null;

            DataSet ds = new DataSet();
            try
            {
                //初始化连接，并打开
                conn = new OleDbConnection(connStr);
                conn.Open();

                //获取数据源的表定义元数据
                string SheetName = "";
                dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                //初始化适配器
                da = new OleDbDataAdapter();
                for (int i = 0; i < dtSheetName.Rows.Count; i++)
                {
                    SheetName = (string)dtSheetName.Rows[i]["TABLE_NAME"];

                    if (SheetName.Contains("$") && !SheetName.Replace("'", "").EndsWith("$"))
                    {
                        continue;
                    }

                    da.SelectCommand = new OleDbCommand(String.Format(sql_F, SheetName), conn);
                    DataSet dsItem = new DataSet();
                    da.Fill(dsItem, "Sheet1");

                    ds.Tables.Add(dsItem.Tables[0].Copy());
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                //关闭连接
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    da.Dispose();
                    conn.Dispose();
                }
            }
            return ds;
        }

        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        List<string> rule_names = new List<string>();
        int current_row = 0;
        public string Content_Regex(string content)
        {
            string pattern;
            string replacement;
            if(content.Contains("{"))
            {
                for (int i = 0; i < rule_names.Count(); i++)
                {
                    pattern = "\\{" + rule_names[i] + "\\}";
                    replacement = dt.Rows[current_row][rule_names[i]].ToString();
                    content = Regex.Replace(content, pattern, replacement);
                }
            }
            return content;
        }

        private void button_test2_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                if (current_row < dt.Rows.Count)
                {
                    RMA_text.Text = Content_Regex(RMA_exp_text.Text);
                    MS_text.Text = Content_Regex(MS_exp_text.Text);
                    MB_text.Text = Content_Regex(MB_exp_text.Text);
                    SMA_text.Text = MU_text.Text;
                    current_row++;
                    label_count.Text = "计数君\n" + "   " + current_row;
                }
            }
        }

        private void button_importExcel_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Excel(*.xls;*.xlsx)|*.xls;*.xlsx";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.Multiselect = false;
            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                ds.Reset();
                dt.Reset();
                rule_names.Clear();
                current_row = 0;
                var filePath = openFile.FileName;
                filepath_text.Text = filePath;
                ds = ToDataTable(filePath);
                dt = ds.Tables[0];
                this.dGViewExcel.DataSource = dt;
                Msg_listbox.Items.Add("导入文件：" + filePath);
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    var name = ds.Tables[0].Columns[i].ColumnName;
                    rule_names.Add(name);
                    Msg_listbox.Items.Add("导入规则{" + name + "}");
                }

            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            current_row = 0;
            button_load.PerformClick();
            label_count.Text = "计数君\n" +"   "+ current_row;

        }

    }
}
