using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDateModifier.NetCore.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDig.Title = "选择一个要修改日期的文件";
            OpenFileDig.ShowDialog();
            TxtFilePath.Text = OpenFileDig.FileName;
            try
            {
                var fi = new FileInfo(OpenFileDig.FileName);
                DtpCreateTime.Value = fi.CreationTime;
                DtpModifyTime.Value = fi.LastWriteTime;
                DtpAccessTime.Value = fi.LastAccessTime;
                LblMessage.Text = "原始文件信息已经载入!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("我操，程序发生异常！\n异常消息：" + ex.Message, "马勒戈壁的！");
            }

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (DtpCreateTime.Value > DtpModifyTime.Value)
            {
                var d = MessageBox.Show("你填写的文件创建日期在修改日期之后，你确信要这样做吗？", "这是咩呀", MessageBoxButtons.YesNo);
                if (d == DialogResult.No)
                {
                    return;
                }
            }
            if (DtpCreateTime.Value > DtpAccessTime.Value)
            {
                var d = MessageBox.Show("你填写的文件创建日期在访问日期之后，你确信要这样做吗？", "这是咩呀", MessageBoxButtons.YesNo);
                if (d == DialogResult.No)
                {
                    return;
                }
            }
            try
            {
                var path = OpenFileDig.FileName;
                if (File.Exists(path))
                {
                    var fi = new FileInfo(path);
                    if (!fi.IsReadOnly)
                    {
                        File.SetCreationTime(path, DtpCreateTime.Value);
                        File.SetLastWriteTime(path, DtpModifyTime.Value);
                        File.SetLastAccessTime(path, DtpAccessTime.Value);
                        MessageBox.Show("修改成功 o(∩_∩)o", "本程序猥琐地笑了");
                    }
                    else
                    {
                        throw new Exception("这文件TM是只读的！只读的！！本程序的萨钢狗眼被刺瞎了！！！");
                    }
                }
                else
                {
                    throw new Exception("文件不存在，你按个JB按啊！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("我操，程序发生异常！\n异常消息：" + ex.Message, "马勒戈壁的！");
            }
        }
    }
}
