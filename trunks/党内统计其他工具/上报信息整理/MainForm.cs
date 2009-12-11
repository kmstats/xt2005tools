using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections;
using System.Diagnostics;

namespace com.echo.other
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OF.ShowDialog() == DialogResult.OK)
            {
                lbSelected.Items.Clear();
                foreach (string item in OF.FileNames)
                {
                    lbSelected.Items.Add(item);
                }
                btnDo.Enabled = lbSelected.Items.Count > 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rarExe = Application.StartupPath+"\\WinRar.exe"; //rar文件
            string modFile = Application.StartupPath+"\\model";   //模板文件 

            rarExe = ExtractShortPathName(rarExe);
            modFile = ExtractShortPathName(modFile)+"\\*.*";

            if (FB.ShowDialog() == DialogResult.OK)
            {
                ArrayList list = new ArrayList();
                pb.Visible = true;
                int i = 0;
                foreach (string item in lbSelected.Items)
                {
                    i += 1;
                    pb.Value = 100 / lbSelected.Items.Count * i;

                    // 1、拷贝
                    FileInfo f = new FileInfo(item);
                    string target = FB.SelectedPath + "\\" + f.Name;
                    File.Copy(item, target, true);
                    list.Add(target);

                    // 2、整理
                    if (new FileInfo(rarExe).Exists)
                    {
                        try
                        {
                		    Process p = new Process();
                            p.StartInfo.FileName = rarExe;

                            target = ExtractShortPathName(target);

                            string arguments = @"a -IBCK -o+ -ep -y -hpn*7E[A,y5_Vp8N+H -inul";
                            arguments += " " + target + " " + modFile;
                            p.StartInfo.Arguments = arguments;
                            p.Start();
                            while (!p.HasExited)
                            {
                                p.WaitForExit();
                            }
                        }
                        catch (Exception)
                        {
                            throw new Exception("出现错误！请检查上报信息数据！");
                        }
                        
                    }
                    else
                    {
                        throw new Exception("没有找到WinRar.exe，请检查您的目录中是否存在Winrar.exe!");
                    }
                }
                MessageBox.Show("整理完成！请查看输出目录。");
                pb.Value = 0;
                pb.Visible = false;
            }
        }

        /// <summary>
        /// 取得文件的短文件名
        /// </summary>
        /// <param name="path"></param>
        /// <param name="shortPath"></param>
        /// <param name="shortPathLength"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll ", CharSet = CharSet.Auto)]
        private static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)]     string path, [MarshalAs(UnmanagedType.LPTStr)]     StringBuilder shortPath, int shortPathLength);
        private static string ExtractShortPathName(string longName)
        {
            StringBuilder shortNameBuffer = new StringBuilder(256);
            int bufferSize = shortNameBuffer.Capacity;
            int result = GetShortPathName(longName, shortNameBuffer, bufferSize);
            return shortNameBuffer.ToString();
        }
    }
}
