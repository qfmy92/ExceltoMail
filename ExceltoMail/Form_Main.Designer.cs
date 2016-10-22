namespace ExceltoMail
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.filepath_text = new System.Windows.Forms.TextBox();
            this.button_importExcel = new System.Windows.Forms.Button();
            this.dGViewExcel = new System.Windows.Forms.DataGridView();
            this.button_send = new System.Windows.Forms.Button();
            this.Msg_listbox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MB_exp_text = new System.Windows.Forms.TextBox();
            this.MB_text = new System.Windows.Forms.TextBox();
            this.MS_exp_text = new System.Windows.Forms.TextBox();
            this.RMA_text = new System.Windows.Forms.TextBox();
            this.RMA_label = new System.Windows.Forms.Label();
            this.MU_text = new System.Windows.Forms.TextBox();
            this.MP_text = new System.Windows.Forms.TextBox();
            this.SMA_label = new System.Windows.Forms.Label();
            this.MS_label = new System.Windows.Forms.Label();
            this.MS_text = new System.Windows.Forms.TextBox();
            this.SMA_text = new System.Windows.Forms.TextBox();
            this.host_text = new System.Windows.Forms.TextBox();
            this.MB_label = new System.Windows.Forms.Label();
            this.RMA_exp_text = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MU_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MP_label = new System.Windows.Forms.Label();
            this.host_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewExcel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // filepath_text
            // 
            this.filepath_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filepath_text.Location = new System.Drawing.Point(87, 267);
            this.filepath_text.Name = "filepath_text";
            this.filepath_text.Size = new System.Drawing.Size(328, 21);
            this.filepath_text.TabIndex = 9;
            // 
            // button_importExcel
            // 
            this.button_importExcel.Location = new System.Drawing.Point(6, 265);
            this.button_importExcel.Name = "button_importExcel";
            this.button_importExcel.Size = new System.Drawing.Size(75, 23);
            this.button_importExcel.TabIndex = 8;
            this.button_importExcel.Text = "导入excel";
            this.button_importExcel.UseVisualStyleBackColor = true;
            this.button_importExcel.Click += new System.EventHandler(this.button_importExcel_Click);
            // 
            // dGViewExcel
            // 
            this.dGViewExcel.AllowDrop = true;
            this.dGViewExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewExcel.Location = new System.Drawing.Point(6, 20);
            this.dGViewExcel.Name = "dGViewExcel";
            this.dGViewExcel.RowTemplate.Height = 23;
            this.dGViewExcel.Size = new System.Drawing.Size(409, 239);
            this.dGViewExcel.TabIndex = 10;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(3, 3);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 6;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.send_button_Click);
            // 
            // Msg_listbox
            // 
            this.Msg_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Msg_listbox.Font = new System.Drawing.Font("宋体", 10F);
            this.Msg_listbox.FormattingEnabled = true;
            this.Msg_listbox.Location = new System.Drawing.Point(6, 19);
            this.Msg_listbox.Name = "Msg_listbox";
            this.Msg_listbox.Size = new System.Drawing.Size(409, 147);
            this.Msg_listbox.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 481);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // MB_exp_text
            // 
            this.MB_exp_text.AllowDrop = true;
            this.MB_exp_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MB_exp_text.Font = new System.Drawing.Font("宋体", 10F);
            this.MB_exp_text.Location = new System.Drawing.Point(69, 63);
            this.MB_exp_text.Multiline = true;
            this.MB_exp_text.Name = "MB_exp_text";
            this.MB_exp_text.Size = new System.Drawing.Size(194, 72);
            this.MB_exp_text.TabIndex = 11;
            this.MB_exp_text.Text = "{邮件正文}";
            // 
            // MB_text
            // 
            this.MB_text.AllowDrop = true;
            this.MB_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MB_text.Font = new System.Drawing.Font("宋体", 10F);
            this.MB_text.Location = new System.Drawing.Point(61, 86);
            this.MB_text.Multiline = true;
            this.MB_text.Name = "MB_text";
            this.MB_text.Size = new System.Drawing.Size(202, 72);
            this.MB_text.TabIndex = 4;
            // 
            // MS_exp_text
            // 
            this.MS_exp_text.AllowDrop = true;
            this.MS_exp_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MS_exp_text.Font = new System.Drawing.Font("宋体", 10F);
            this.MS_exp_text.Location = new System.Drawing.Point(69, 33);
            this.MS_exp_text.Name = "MS_exp_text";
            this.MS_exp_text.Size = new System.Drawing.Size(194, 23);
            this.MS_exp_text.TabIndex = 5;
            this.MS_exp_text.Text = "{邮件主题}";
            // 
            // RMA_text
            // 
            this.RMA_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RMA_text.Font = new System.Drawing.Font("宋体", 10F);
            this.RMA_text.Location = new System.Drawing.Point(61, 3);
            this.RMA_text.Name = "RMA_text";
            this.RMA_text.Size = new System.Drawing.Size(202, 23);
            this.RMA_text.TabIndex = 1;
            // 
            // RMA_label
            // 
            this.RMA_label.AutoSize = true;
            this.RMA_label.BackColor = System.Drawing.SystemColors.Control;
            this.RMA_label.Location = new System.Drawing.Point(3, 8);
            this.RMA_label.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.RMA_label.Name = "RMA_label";
            this.RMA_label.Size = new System.Drawing.Size(53, 12);
            this.RMA_label.TabIndex = 6;
            this.RMA_label.Text = "收件地址";
            // 
            // MU_text
            // 
            this.MU_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MU_text.Font = new System.Drawing.Font("宋体", 10F);
            this.MU_text.Location = new System.Drawing.Point(69, 141);
            this.MU_text.Name = "MU_text";
            this.MU_text.Size = new System.Drawing.Size(194, 23);
            this.MU_text.TabIndex = 5;
            // 
            // MP_text
            // 
            this.MP_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MP_text.Font = new System.Drawing.Font("宋体", 10F);
            this.MP_text.Location = new System.Drawing.Point(69, 168);
            this.MP_text.Name = "MP_text";
            this.MP_text.Size = new System.Drawing.Size(194, 23);
            this.MP_text.TabIndex = 6;
            // 
            // SMA_label
            // 
            this.SMA_label.AutoSize = true;
            this.SMA_label.BackColor = System.Drawing.SystemColors.Control;
            this.SMA_label.Location = new System.Drawing.Point(3, 36);
            this.SMA_label.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.SMA_label.Name = "SMA_label";
            this.SMA_label.Size = new System.Drawing.Size(53, 12);
            this.SMA_label.TabIndex = 8;
            this.SMA_label.Text = "发件地址";
            // 
            // MS_label
            // 
            this.MS_label.AutoSize = true;
            this.MS_label.BackColor = System.Drawing.SystemColors.Control;
            this.MS_label.Location = new System.Drawing.Point(3, 64);
            this.MS_label.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.MS_label.Name = "MS_label";
            this.MS_label.Size = new System.Drawing.Size(53, 12);
            this.MS_label.TabIndex = 3;
            this.MS_label.Text = "邮件主题";
            // 
            // MS_text
            // 
            this.MS_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MS_text.Font = new System.Drawing.Font("宋体", 10F);
            this.MS_text.Location = new System.Drawing.Point(61, 59);
            this.MS_text.Name = "MS_text";
            this.MS_text.Size = new System.Drawing.Size(202, 23);
            this.MS_text.TabIndex = 3;
            // 
            // SMA_text
            // 
            this.SMA_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SMA_text.Font = new System.Drawing.Font("宋体", 10F);
            this.SMA_text.Location = new System.Drawing.Point(61, 31);
            this.SMA_text.Name = "SMA_text";
            this.SMA_text.Size = new System.Drawing.Size(202, 23);
            this.SMA_text.TabIndex = 2;
            // 
            // host_text
            // 
            this.host_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.host_text.Font = new System.Drawing.Font("宋体", 10F);
            this.host_text.Location = new System.Drawing.Point(69, 195);
            this.host_text.Name = "host_text";
            this.host_text.Size = new System.Drawing.Size(194, 23);
            this.host_text.TabIndex = 7;
            // 
            // MB_label
            // 
            this.MB_label.AutoSize = true;
            this.MB_label.BackColor = System.Drawing.SystemColors.Control;
            this.MB_label.Location = new System.Drawing.Point(3, 91);
            this.MB_label.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.MB_label.Name = "MB_label";
            this.MB_label.Size = new System.Drawing.Size(53, 12);
            this.MB_label.TabIndex = 9;
            this.MB_label.Text = "邮件正文";
            // 
            // RMA_exp_text
            // 
            this.RMA_exp_text.AllowDrop = true;
            this.RMA_exp_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RMA_exp_text.Font = new System.Drawing.Font("宋体", 10F);
            this.RMA_exp_text.Location = new System.Drawing.Point(69, 3);
            this.RMA_exp_text.Multiline = true;
            this.RMA_exp_text.Name = "RMA_exp_text";
            this.RMA_exp_text.Size = new System.Drawing.Size(194, 23);
            this.RMA_exp_text.TabIndex = 7;
            this.RMA_exp_text.Text = "{邮箱}";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label_count);
            this.panel1.Controls.Add(this.button_send);
            this.panel1.Controls.Add(this.button_reset);
            this.panel1.Controls.Add(this.button_load);
            this.panel1.Location = new System.Drawing.Point(3, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 28);
            this.panel1.TabIndex = 17;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(77, 3);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 13;
            this.button_reset.Text = "第一条";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(199, 3);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 12;
            this.button_load.Text = "下一条";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_test2_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.groupBox4);
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Location = new System.Drawing.Point(290, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(439, 481);
            this.panel4.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.34426F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.65574F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(732, 487);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 187);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待发邮件";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.04969F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.95031F));
            this.tableLayoutPanel3.Controls.Add(this.RMA_label, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.RMA_text, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.MB_text, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.SMA_label, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.SMA_text, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.MS_label, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.MS_text, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.MB_label, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.33334F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(266, 161);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // MU_label
            // 
            this.MU_label.AutoSize = true;
            this.MU_label.BackColor = System.Drawing.SystemColors.Control;
            this.MU_label.Location = new System.Drawing.Point(3, 146);
            this.MU_label.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.MU_label.Name = "MU_label";
            this.MU_label.Size = new System.Drawing.Size(53, 12);
            this.MU_label.TabIndex = 12;
            this.MU_label.Text = "邮箱账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "收件地址";
            // 
            // MP_label
            // 
            this.MP_label.AutoSize = true;
            this.MP_label.BackColor = System.Drawing.SystemColors.Control;
            this.MP_label.Location = new System.Drawing.Point(3, 173);
            this.MP_label.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.MP_label.Name = "MP_label";
            this.MP_label.Size = new System.Drawing.Size(53, 12);
            this.MP_label.TabIndex = 14;
            this.MP_label.Text = "邮箱密码";
            // 
            // host_label
            // 
            this.host_label.AutoSize = true;
            this.host_label.BackColor = System.Drawing.SystemColors.Control;
            this.host_label.Location = new System.Drawing.Point(3, 200);
            this.host_label.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.host_label.Name = "host_label";
            this.host_label.Size = new System.Drawing.Size(53, 12);
            this.host_label.TabIndex = 16;
            this.host_label.Text = "SMTP地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "邮件主题";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "邮件正文";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(3, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 248);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数设置";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.18018F));
            this.tableLayoutPanel4.Controls.Add(this.host_label, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.host_text, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.MP_text, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.MP_label, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.MB_exp_text, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.MU_text, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.MU_label, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.RMA_exp_text, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.MS_exp_text, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(266, 222);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Msg_listbox);
            this.groupBox3.Location = new System.Drawing.Point(9, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 175);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "消息窗口";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dGViewExcel);
            this.groupBox4.Controls.Add(this.button_importExcel);
            this.groupBox4.Controls.Add(this.filepath_text);
            this.groupBox4.Location = new System.Drawing.Point(9, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 294);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Excel表";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(154, 1);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(41, 12);
            this.label_count.TabIndex = 12;
            this.label_count.Text = "计数君";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 511);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Location = new System.Drawing.Point(10, 100);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自助发邮件Ver1.0";
            ((System.ComponentModel.ISupportInitialize)(this.dGViewExcel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox Msg_listbox;
        private System.Windows.Forms.TextBox RMA_text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox MS_text;
        private System.Windows.Forms.Label MS_label;
        private System.Windows.Forms.Label RMA_label;
        private System.Windows.Forms.Label SMA_label;
        private System.Windows.Forms.Label MB_label;
        private System.Windows.Forms.TextBox MB_text;
        private System.Windows.Forms.TextBox SMA_text;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox MU_text;
        private System.Windows.Forms.TextBox MP_text;
        private System.Windows.Forms.TextBox host_text;
        private System.Windows.Forms.DataGridView dGViewExcel;
        private System.Windows.Forms.Button button_importExcel;
        private System.Windows.Forms.TextBox filepath_text;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.TextBox MS_exp_text;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox RMA_exp_text;
        private System.Windows.Forms.TextBox MB_exp_text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label host_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MP_label;
        private System.Windows.Forms.Label MU_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_count;
    }
}

