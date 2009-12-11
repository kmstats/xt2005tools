using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.echo.XT2007
{
    public partial class mainForm : Form
    {
        private MyDataSet ds;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            ds = new MyDataSet();

            userTableAdapter.Fill(ds.User);

            if (!ValidDB())
            { 
                MessageBox.Show("XT2005 V2.0数据连接失败，请先启动XT2005 V2.0！");
                Close();
            }

            FillTree();
        }

        /// <summary>
        /// 填充树，取得信息集，及表字段
        /// </summary>
        private void FillTree()
        {
            //取得表
            dict_TableTableAdapter.FillByTName(ds.Dict_Table);
            foreach (DataRow item in ds.Dict_Table.Rows)
            {
                TreeNode node = mainTree.Nodes.Add("(" + item.Field<String>("tname") + ")" + item.Field<String>("Caption"));
                node.Name = item.Field<String>("tname");
                node.ToolTipText = node.Text;


                dict_ColumnTableAdapter.FillByTName(ds.Dict_Column, item.Field<String>("tname"));
                foreach (DataRow r in ds.Dict_Column.Rows)
                {
                    TreeNode subNode = node.Nodes.Add("(" + r.Field<string>("cname") + ")" + r.Field<String>("CAPTION"));
                    subNode.ToolTipText = subNode.Text;
                }
            }
        }

        /// <summary>
        /// 数据库合法校验
        /// </summary>
        /// <returns></returns>
        private Boolean ValidDB()
        {
            Boolean result = false;
            try
            {
                result = ds.User.Rows.Count > 0;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        private void mainTree_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if ((sender as TreeNode).Level == 1)
            {
                e.Action = DragAction.Continue;
            }
            else
            {
                e.Action = DragAction.Cancel;
            }
        }

        private void mainTree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void mainTree_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void toolStrip1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void toolStrip1_DragDrop(object sender, DragEventArgs e)
        {
            //TreeNode node = CType(e.Data.GetData("System.windows.forms.TreeNode"), TreeNode);
            //toolStrip1.Items.Add(node.Name);
        }
    }
}
