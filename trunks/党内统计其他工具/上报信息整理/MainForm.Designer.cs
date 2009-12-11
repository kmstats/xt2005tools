namespace com.echo.other
{
    partial class mainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMsg = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OF = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSelected = new System.Windows.Forms.ListBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.FB = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMsg
            // 
            this.lbMsg.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMsg.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMsg.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbMsg.Location = new System.Drawing.Point(12, 9);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(614, 67);
            this.lbMsg.TabIndex = 0;
            this.lbMsg.Text = "    本工具用于将 XT2005 V2.0 生成的信息上报文件中的除组织信息、单位信息外的信息删除，以保证上级单位接收信息有较高的速度。本工具适用于只关注于组织" +
                "和单位信息的需求。";
            this.lbMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(15, 383);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(109, 40);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "选择文件(&L)";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDo
            // 
            this.btnDo.Enabled = false;
            this.btnDo.Location = new System.Drawing.Point(151, 383);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(109, 40);
            this.btnDo.TabIndex = 2;
            this.btnDo.Text = "整理文件(&A)";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(517, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "退出(&X)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OF
            // 
            this.OF.DefaultExt = "rar";
            this.OF.Filter = "XT2005 V2.0上报文件|*.rar";
            this.OF.Multiselect = true;
            this.OF.Title = "选择一个或多个 XT2005 V2.0 上报文件";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSelected);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 279);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已选择的上报文件";
            // 
            // lbSelected
            // 
            this.lbSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSelected.FormattingEnabled = true;
            this.lbSelected.HorizontalScrollbar = true;
            this.lbSelected.ItemHeight = 12;
            this.lbSelected.Location = new System.Drawing.Point(3, 17);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(611, 256);
            this.lbSelected.TabIndex = 0;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.SystemColors.Control;
            this.pb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb.Location = new System.Drawing.Point(0, 433);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(641, 23);
            this.pb.TabIndex = 6;
            this.pb.Visible = false;
            // 
            // FB
            // 
            this.FB.Description = "请选择整理后的文件保存目录";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 456);
            this.ControlBox = false;
            this.Controls.Add(this.pb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lbMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XT2005 V2.0 上报信息整理";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog OF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbSelected;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.FolderBrowserDialog FB;
    }
}

