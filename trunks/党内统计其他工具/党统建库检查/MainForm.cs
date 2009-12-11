using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using com.echo.DB;
using System.Windows.Forms;
using System.IO;

namespace com.echo.Xt2005
{
    public partial class MainForm : Form
    {
        private com.echo.File.IniFile chkFile;
        private com.echo.File.IniFile msgFile;
        private IDataProvider myDb;
        private string sql;

        private DataSet ds;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OnCheckDB()
        {
            if (!ValidDB())
            {
                MessageBox.Show("XT2005 V2.0数据连接失败，请先启动XT2005 V2.0！");
                Close();
            }
        }

        private void GetChk()
        { 
            List<string> l = new List<string>();
            chkFile.ReadSections(l);
            cbType.Items.AddRange(l.ToArray());
        }

        private Boolean ValidDB()
        {
            myDb = DataProvider.CreateDataProvider(DataProvider.DataProviderType.KingbaseProvider);
            Object o = myDb.ExecuteScalar("SELECT COUNT(*) FROM USERS");
            if (o == null)
                return false;
            else
                return true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chkFile = new com.echo.File.IniFile(Application.StartupPath + "\\chk.ini");
            msgFile = new com.echo.File.IniFile(Application.StartupPath + "\\msg.ini");
            OnCheckDB();
            GetChk();
            GetTopUnit();
            MainForm.CheckForIllegalCrossThreadCalls = false;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCheck.Items.Clear();
            List<string> l = new List<string>();
            chkFile.ReadSection(cbType.Text, l);
            cbCheck.Items.AddRange(l.ToArray());
        }
        
        private void _dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            toolStripStatusLabel2.Text = "  记录数：" + _dataGrid.Rows.Count.ToString()+"  ";
        }

        private void OnTimer(object sender, EventArgs e)
        {
            lbTime.Text = "当前时间：" + DateTime.Now.ToString();
        }

        private void AddComboBoxColumns(string reftable, string fieldName, int index)
        {
            DataGridViewComboBoxColumn comboboxColumn;
            comboboxColumn = new DataGridViewComboBoxColumn();
            {
                comboboxColumn.DataPropertyName = fieldName;
                comboboxColumn.HeaderText = fieldName;
            }
            comboboxColumn.DataSource = myDb.RetriveDataSet("select code,code_name from " + reftable).Tables[0];
            comboboxColumn.ValueMember = "code";
            comboboxColumn.DisplayMember = "code_name";
            _dataGrid.Columns.Remove(fieldName);
            _dataGrid.Columns.Insert(index, comboboxColumn);
        }

        private void OnExport(object sender, EventArgs e)
        {
            ExportDataGridViewToExcel(_dataGrid);
        }

        /// <summary>
        /// 将DataGridView导出到Excel
        /// </summary>
        /// <param name="dgv"></param>
        public static void ExportDataGridViewToExcel(DataGridView dataGridview1)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "导出Excel文件到";

            saveFileDialog.ShowDialog();

            Stream myStream;
            myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("gb2312"));
            string str = "";
            try
            {
                //写标题  
                for (int i = 0; i < dataGridview1.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        str += "\t";
                    }
                    str += dataGridview1.Columns[i].HeaderText;
                }

                sw.WriteLine(str);
                //写内容 
                for (int j = 0; j < dataGridview1.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 0; k < dataGridview1.Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            tempStr += "\t";
                        }
                        if (dataGridview1.Rows[j].Cells[k].Value != null)
                            if (dataGridview1.Rows[j].Cells[k] is DataGridViewComboBoxCell)
                                tempStr += (dataGridview1.Rows[j].Cells[k] as DataGridViewComboBoxCell).FormattedValue;
                            else
                                tempStr += dataGridview1.Rows[j].Cells[k].Value.ToString();

                    }
                    sw.WriteLine(tempStr);
                }
                sw.Close();
                myStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
            MessageBox.Show("导出到Excel成功！");
        }

        private void _popMenu_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = _dataGrid.Rows.Count == 0;
        }

        private void _listResult_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (_listResult.SelectedItems.Count == 1)
            {
                cbType.SelectedIndex = cbType.Items.IndexOf(_listResult.SelectedItems[0].SubItems[3].Text);
                cbCheck.SelectedIndex = cbCheck.Items.IndexOf(_listResult.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void cbCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = chkFile.ReadString(cbType.Text, cbCheck.Text, "");
            OnCheck();
        }

        private void OnCheck()
        {
            Cursor.Current = Cursors.WaitCursor;
            _listResult.Refresh();
            _StatusBar.Refresh();


            pb.Visible = true;
            pb.Width = 400;

            System.Threading.Thread th = new System.Threading.Thread(new System.Threading.ThreadStart(GetDS));
            th.Start();
            while (th.IsAlive)
            {
                _StatusBar.Refresh();
                System.Threading.Thread.Sleep(1); 
            }

            FillDS();

            Cursor.Current = Cursors.Default;
        }


        private void acMsg_Execute(object sender, EventArgs e)
        {
            gbMsg.Visible = !gbMsg.Visible;
            acMsg.Image = gbMsg.Visible ? Properties.Resources.Kombine_toolbar_043 : Properties.Resources.Kombine_toolbar_020;
        }

        private void acMsg_Update(object sender, EventArgs e)
        {
            acMsg.Text = gbMsg.Visible ? "隐藏消息提示" : "显示消息提示";
        }

        private void acResult_Execute(object sender, EventArgs e)
        {
            acResult.Image = splitContainer1.Panel1Collapsed ? Properties.Resources.Kombine_toolbar_025 : Properties.Resources.Kombine_toolbar_007;
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
        }

        private void acResult_Update(object sender, EventArgs e)
        {
            acResult.Text = splitContainer1.Panel1Collapsed ? "显示结果" : "隐藏结果";
        }

        private void GetTopUnit()
        {
            lbUnit.Text = "当前检查单位： "+myDb.ExecuteScalar("select D0107||' '||D0101 as a from D01 where D0127=''").ToString();
        }

        private void GetDS()
        {
            ds = myDb.RetriveDataSet(sql);
        }

        private void FillDS()
        {
            _dataGrid.DataSource = ds.Tables[0];
            List<string> l = new List<string>();

            foreach (DataGridViewColumn col in _dataGrid.Columns)
            {
                l.Add(col.HeaderText);
            }

            int i = 0;
            foreach (string col in l)
            {
                try
                {
                    System.Data.DataSet dss = myDb.RetriveDataSet("select tname,caption,reftable,refcol from t_dict_column where cname='" + col + "'");
                    string reft = dss.Tables[0].Rows[0]["reftable"].ToString();
                    if (reft != "" && (reft.StartsWith("K") || reft.StartsWith("Z") || reft.StartsWith("G")))
                    {
                        AddComboBoxColumns(dss.Tables[0].Rows[0]["reftable"].ToString(), col, i);
                    }
                }
                catch (Exception)
                {
                }
                i++;
            }

            foreach (DataGridViewColumn col in _dataGrid.Columns)
            {
                try
                {
                    col.HeaderText = myDb.ExecuteScalar("select Caption from t_dict_column where cname='" + col.HeaderText + "'").ToString();  // 中文字段名
                }
                catch (Exception)
                {
                }
            }

            _dataGrid.AutoResizeColumns();
            _dataGrid.Columns[0].Frozen = true;

            if (_dataGrid.Rows.Count > 0 && _listResult.FindItemWithText(cbCheck.Text) == null)   //加入记录list
            {
                ListViewItem item = new ListViewItem();
                item.Text = cbCheck.Text;
                item.SubItems.Add(sql);
                item.SubItems.Add(_dataGrid.Rows.Count.ToString());
                item.SubItems.Add(cbType.Text);
                _listResult.Items.Add(item);
            }
            
            pb.Visible = false;
            _msgBox.Text = msgFile.ReadString(cbType.Text, cbCheck.Text, "");
        }

        private void acAll_Execute(object sender, EventArgs e)
        {
            _listResult.Items.Clear();

            foreach (string t in cbType.Items)
            {
                cbType.SelectedIndex = cbType.Items.IndexOf(t);
                foreach (string c in cbCheck.Items)
                {
                    cbCheck.SelectedIndex = cbCheck.Items.IndexOf(c);
                }
            }
        }
    }
}
