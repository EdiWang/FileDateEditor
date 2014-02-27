using System;
using System.IO;
using System.Windows.Forms;

namespace FilePropertyModifier
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这里可以做些猥琐的事情
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "选择一个要修改日期的文件";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            try
            {
                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                dtpCreateTime.Value = fi.CreationTime;
                dtpModifyTime.Value = fi.LastWriteTime;
                dtpAccessTime.Value = fi.LastAccessTime;
                label1.Text = "原始文件信息已经载入!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("我操，程序发生异常！\n异常消息：" + ex.Message, "马勒戈壁的！");
            }

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dtpCreateTime.Value > dtpModifyTime.Value)
            {
                DialogResult d = MessageBox.Show("你填写的文件创建日期在修改日期之后，你确信要这样做吗？", "这是咩呀", MessageBoxButtons.YesNo);
                if (d == DialogResult.No)
                {
                    return;
                }
            }
            if (dtpCreateTime.Value > dtpAccessTime.Value)
            {
                DialogResult d = MessageBox.Show("你填写的文件创建日期在访问日期之后，你确信要这样做吗？", "这是咩呀", MessageBoxButtons.YesNo);
                if (d == DialogResult.No)
                {
                    return;
                }
            }
            try
            {
                string path = openFileDialog1.FileName;
                if (File.Exists(path))
                {
                    FileInfo fi = new FileInfo(path);
                    if (!fi.IsReadOnly)
                    {
                        File.SetCreationTime(path, dtpCreateTime.Value);
                        File.SetLastWriteTime(path, dtpModifyTime.Value);
                        File.SetLastAccessTime(path, dtpAccessTime.Value);
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

        private void dtpCreateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpModifyTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpAccessTime_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
