namespace com.echo.Xt2005
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._MainMenu = new System.Windows.Forms.MenuStrip();
            this._systemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ToolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnResult = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbCheck = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this._StatusBar = new System.Windows.Forms.StatusStrip();
            this.pb = new System.Windows.Forms.ToolStripProgressBar();
            this.lbUnit = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbMsg = new System.Windows.Forms.GroupBox();
            this._msgBox = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._listResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this._dataGrid = new System.Windows.Forms.DataGridView();
            this._popMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._acMain = new com.echo.Controls.Actions.ActionList();
            this.acExit = new com.echo.Controls.Actions.Action();
            this.acMsg = new com.echo.Controls.Actions.Action();
            this.acResult = new com.echo.Controls.Actions.Action();
            this.acAll = new com.echo.Controls.Actions.Action();
            this._MainMenu.SuspendLayout();
            this._ToolBar.SuspendLayout();
            this._StatusBar.SuspendLayout();
            this.gbMsg.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).BeginInit();
            this._popMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._acMain)).BeginInit();
            this.SuspendLayout();
            // 
            // _MainMenu
            // 
            this._MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._systemMenu,
            this.帮助HToolStripMenuItem});
            this._MainMenu.Location = new System.Drawing.Point(0, 0);
            this._MainMenu.Name = "_MainMenu";
            this._MainMenu.Size = new System.Drawing.Size(1156, 24);
            this._MainMenu.TabIndex = 0;
            this._MainMenu.Text = "menuStrip1";
            // 
            // _systemMenu
            // 
            this._systemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuExit});
            this._systemMenu.Name = "_systemMenu";
            this._systemMenu.Size = new System.Drawing.Size(59, 20);
            this._systemMenu.Text = "系统(&S)";
            // 
            // _menuExit
            // 
            this._acMain.SetAction(this._menuExit, this.acExit);
            this._menuExit.Image = global::com.echo.Xt2005.Properties.Resources.Kombine_toolbar_017;
            this._menuExit.Name = "_menuExit";
            this._menuExit.Size = new System.Drawing.Size(112, 22);
            this._menuExit.Text = "退出(&X)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)...";
            // 
            // _ToolBar
            // 
            this._ToolBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._ToolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnResult,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.cbType,
            this.toolStripLabel2,
            this.cbCheck,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this._ToolBar.Location = new System.Drawing.Point(0, 24);
            this._ToolBar.Name = "_ToolBar";
            this._ToolBar.Size = new System.Drawing.Size(1156, 39);
            this._ToolBar.Stretch = true;
            this._ToolBar.TabIndex = 1;
            this._ToolBar.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this._acMain.SetAction(this.toolStripButton1, this.acMsg);
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::com.echo.Xt2005.Properties.Resources.Kombine_toolbar_043;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "隐藏消息提示(&M)";
            // 
            // btnResult
            // 
            this._acMain.SetAction(this.btnResult, this.acResult);
            this.btnResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnResult.Image = global::com.echo.Xt2005.Properties.Resources.Kombine_toolbar_007;
            this.btnResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(36, 36);
            this.btnResult.Text = "隐藏结果(&R)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 36);
            this.toolStripLabel1.Text = "分类";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 39);
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 36);
            this.toolStripLabel2.Text = " 检查";
            // 
            // cbCheck
            // 
            this.cbCheck.AutoSize = false;
            this.cbCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.Size = new System.Drawing.Size(250, 20);
            this.cbCheck.SelectedIndexChanged += new System.EventHandler(this.cbCheck_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton2
            // 
            this._acMain.SetAction(this.toolStripButton2, this.acAll);
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::com.echo.Xt2005.Properties.Resources.Kombine_toolbar_015;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "批量检查";
            // 
            // _StatusBar
            // 
            this._StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pb,
            this.lbUnit,
            this.lbTime,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this._StatusBar.Location = new System.Drawing.Point(0, 669);
            this._StatusBar.Name = "_StatusBar";
            this._StatusBar.Size = new System.Drawing.Size(1156, 22);
            this._StatusBar.TabIndex = 2;
            this._StatusBar.Text = "statusStrip1";
            // 
            // pb
            // 
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(400, 16);
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb.Visible = false;
            // 
            // lbUnit
            // 
            this.lbUnit.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbUnit.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(915, 17);
            this.lbUnit.Spring = true;
            // 
            // lbTime
            // 
            this.lbTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbTime.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(135, 17);
            this.toolStripStatusLabel1.Text = "  服务器：LOCALHOST  ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel2.Text = "  记录数：0  ";
            // 
            // gbMsg
            // 
            this.gbMsg.Controls.Add(this._msgBox);
            this.gbMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMsg.Location = new System.Drawing.Point(0, 63);
            this.gbMsg.Name = "gbMsg";
            this.gbMsg.Size = new System.Drawing.Size(1156, 100);
            this.gbMsg.TabIndex = 3;
            this.gbMsg.TabStop = false;
            this.gbMsg.Text = "信息提示";
            // 
            // _msgBox
            // 
            this._msgBox.BackColor = System.Drawing.Color.LightBlue;
            this._msgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._msgBox.Location = new System.Drawing.Point(3, 17);
            this._msgBox.Name = "_msgBox";
            this._msgBox.ReadOnly = true;
            this._msgBox.Size = new System.Drawing.Size(1150, 80);
            this._msgBox.TabIndex = 0;
            this._msgBox.Text = "";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 163);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1156, 5);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 168);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._listResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._dataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1156, 501);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // _listResult
            // 
            this._listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this._listResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listResult.FullRowSelect = true;
            this._listResult.Location = new System.Drawing.Point(0, 0);
            this._listResult.MultiSelect = false;
            this._listResult.Name = "_listResult";
            this._listResult.Size = new System.Drawing.Size(258, 501);
            this._listResult.TabIndex = 0;
            this._listResult.UseCompatibleStateImageBehavior = false;
            this._listResult.View = System.Windows.Forms.View.Details;
            this._listResult.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this._listResult_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "内容";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "记录数";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "类别";
            // 
            // _dataGrid
            // 
            this._dataGrid.AllowUserToAddRows = false;
            this._dataGrid.AllowUserToDeleteRows = false;
            this._dataGrid.AllowUserToResizeRows = false;
            this._dataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this._dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGrid.ContextMenuStrip = this._popMenu;
            this._dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGrid.Location = new System.Drawing.Point(0, 0);
            this._dataGrid.Name = "_dataGrid";
            this._dataGrid.ReadOnly = true;
            this._dataGrid.RowHeadersVisible = false;
            this._dataGrid.RowTemplate.Height = 23;
            this._dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGrid.Size = new System.Drawing.Size(893, 501);
            this._dataGrid.TabIndex = 0;
            this._dataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this._dataGrid_DataBindingComplete);
            // 
            // _popMenu
            // 
            this._popMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExport});
            this._popMenu.Name = "_popMenu";
            this._popMenu.Size = new System.Drawing.Size(155, 26);
            this._popMenu.Opening += new System.ComponentModel.CancelEventHandler(this._popMenu_Opening);
            // 
            // menuExport
            // 
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(154, 22);
            this.menuExport.Text = "导出到Excel(&E)";
            this.menuExport.Click += new System.EventHandler(this.OnExport);
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            this._timer.Interval = 1000;
            this._timer.Tick += new System.EventHandler(this.OnTimer);
            // 
            // _acMain
            // 
            this._acMain.Actions.Add(this.acExit);
            this._acMain.Actions.Add(this.acMsg);
            this._acMain.Actions.Add(this.acResult);
            this._acMain.Actions.Add(this.acAll);
            this._acMain.ContainerControl = this;
            // 
            // acExit
            // 
            this.acExit.Image = global::com.echo.Xt2005.Properties.Resources.Kombine_toolbar_017;
            this.acExit.Text = "退出(&X)";
            this.acExit.Execute += new System.EventHandler(this.OnExit);
            // 
            // acMsg
            // 
            this.acMsg.Image = global::com.echo.Xt2005.Properties.Resources.Kombine_toolbar_043;
            this.acMsg.Text = "隐藏消息提示(&M)";
            this.acMsg.Update += new System.EventHandler(this.acMsg_Update);
            this.acMsg.Execute += new System.EventHandler(this.acMsg_Execute);
            // 
            // acResult
            // 
            this.acResult.Image = global::com.echo.Xt2005.Properties.Resources.Kombine_toolbar_007;
            this.acResult.Text = "隐藏结果(&R)";
            this.acResult.Update += new System.EventHandler(this.acResult_Update);
            this.acResult.Execute += new System.EventHandler(this.acResult_Execute);
            // 
            // acAll
            // 
            this.acAll.Image = global::com.echo.Xt2005.Properties.Resources.Kombine_toolbar_015;
            this.acAll.Text = "批量检查";
            this.acAll.Execute += new System.EventHandler(this.acAll_Execute);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 691);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gbMsg);
            this.Controls.Add(this._StatusBar);
            this.Controls.Add(this._ToolBar);
            this.Controls.Add(this._MainMenu);
            this.MainMenuStrip = this._MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xt2005建库规范检查";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._MainMenu.ResumeLayout(false);
            this._MainMenu.PerformLayout();
            this._ToolBar.ResumeLayout(false);
            this._ToolBar.PerformLayout();
            this._StatusBar.ResumeLayout(false);
            this._StatusBar.PerformLayout();
            this.gbMsg.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).EndInit();
            this._popMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._acMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _MainMenu;
        private System.Windows.Forms.ToolStripMenuItem _systemMenu;
        private System.Windows.Forms.ToolStrip _ToolBar;
        private System.Windows.Forms.StatusStrip _StatusBar;
        private System.Windows.Forms.ToolStripMenuItem _menuExit;
        private System.Windows.Forms.GroupBox gbMsg;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox _msgBox;
        private System.Windows.Forms.ListView _listResult;
        private System.Windows.Forms.DataGridView _dataGrid;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbCheck;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbTime;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.ContextMenuStrip _popMenu;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private com.echo.Controls.Actions.ActionList _acMain;
        private com.echo.Controls.Actions.Action acExit;
        private com.echo.Controls.Actions.Action acMsg;
        private com.echo.Controls.Actions.Action acResult;
        private System.Windows.Forms.ToolStripStatusLabel lbUnit;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripProgressBar pb;
        private com.echo.Controls.Actions.Action acAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

