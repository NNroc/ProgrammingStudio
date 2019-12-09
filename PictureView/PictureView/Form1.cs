using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //文件夹下所有图片文件的完整路径
        private List<string> pathList = new List<string> ();
        //下标
        private int CurPictureID;
        private void AddDirectories(TreeNode node)
        {
            try
            {
                //获取当前节点路径
                DirectoryInfo dir = new DirectoryInfo(GetPathFromNode(node));
                DirectoryInfo[] e = dir.GetDirectories();
                for (int i = 0; i < e.Length; i++)
                {
                    string name = e[i].Name;
                    if (!name.Equals(".") && !name.Equals(".."))
                    {
                        TreeNode newNode = new TreeNode(name);
                        newNode.Name = e[i].FullName.ToLower();
                        node.Nodes.Add(newNode);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillDirectorytV ()
        {
            //创建根路径
            TreeNode computer = new TreeNode();
            computer.Name = "computer";
            computer.Text = "计算机";

            //添加到文件列表视窗
            DirectorytV.Nodes.Add(computer);

            //获取设备盘符
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                TreeNode cRoot = new TreeNode(drive);
                computer.Nodes.Add(cRoot);
                AddDirectories(cRoot);
            }
            computer.Expand();
            //绑定 TreeView 控件的事件 BeforeExpand
            DirectorytV.BeforeExpand += new TreeViewCancelEventHandler(DirectorytV_BeforeExpand);
        }

        private string GetPathFromNode(TreeNode node)
        {
            if (node.Parent == null)
            {
                return node.Text;
            }

            return Path.Combine(GetPathFromNode(node.Parent), node.Text);
        }

        private void ShowImages(string filePath)
        {
            string filename;
            pathList.Clear();
            CurPictureID = 0;
            DirectoryInfo di = new DirectoryInfo(filePath);
            FileInfo[] afi = di.GetFiles("*.* ");
            for (int i = 0; i < afi.Length; i++)
            {
                filename = afi[i].Name.ToLower();
                if (filename.Contains(".jpg") || filename.Contains(".jpeg") ||
                    filename.Contains(".bmp") || filename.Contains(".png") ||
                    filename.Contains(".ico"))
                {
                    pathList.Add(afi[i].FullName.ToLower());
                }
            }
        }

        private void DirectorytV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "计算机")
            {
                return;
            }

            string path = e.Node.Name;
            ShowImages(path);
            if (pathList.Count > 0)
            {
                //显示第一个图片
                MainpBox.Image = Image.FromFile(pathList[0]);
                panel1.AutoScrollMinSize = new System.Drawing.Size(MainpBox.Image.Width,
                    MainpBox.Image.Height);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FillDirectorytV();
            MainpBox.Image = null;
            WindowState = FormWindowState.Maximized;
        }
        
        private void DirectorytV_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            //获取展开的节点与节点路径
            TreeNode selected_Node = DirectorytV.SelectedNode;
            int childNum = selected_Node.GetNodeCount(true);
            string path = DirectorytV.SelectedNode.FullPath;

            //获取子树
            for (int i = 1; i < childNum; i++)
            {
                
            }
        }
        
        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "打开图像文件";
            of.Filter = "图像文件|*.bmp;*.jpg;*.jpge;*.png;*.ico";
            if (of.ShowDialog() == DialogResult.OK)
            {
                string fn = of.FileName.Trim().ToLower();
                try
                {
                    if (fn != "")
                    {
                        MainpBox.Image = Image.FromFile(fn);
                        panel1.AutoScrollMinSize=new System.Drawing.Size(MainpBox.Image.Width,MainpBox.Image.Height);
                        ShowImages(Path.GetDirectoryName(fn));
                        for (int i = 0; i < pathList.Count; i++)
                        {
                            if (fn == pathList[i])
                            {
                                CurPictureID = i;
                                break;
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ZoomaddButton_Click(object sender, EventArgs e)
        {
            if (MainpBox.Image == null)
            {
                return;
            }

            Image image = Image.FromFile(pathList[CurPictureID]);
            int width = Convert.ToInt32(MainpBox.Image.Width * 1.1);
            int height = Convert.ToInt32(MainpBox.Image.Height * 1.1);
            image = new Bitmap(image, width, height);
            MainpBox.Image = image;
            panel1.AutoScrollMinSize = new System.Drawing.Size(width, height);
        }

        private void ZoomsubButton_Click(object sender, EventArgs e)
        {
            if (MainpBox.Image == null)
            {
                return;
            }

            Image image = Image.FromFile(pathList[CurPictureID]);
            int width = Convert.ToInt32(MainpBox.Image.Width / 1.1);
            int height = Convert.ToInt32(MainpBox.Image.Height / 1.1);
            image = new Bitmap(image, width, height);
            MainpBox.Image = image;
            panel1.AutoScrollMinSize = new System.Drawing.Size(width, height);
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            if (MainpBox.Image == null)
            {
                return;
            }
            
            MainpBox.Image = Image.FromFile(pathList[CurPictureID]);
            panel1.AutoScrollMinSize = new System.Drawing.Size(MainpBox.Image.Width, MainpBox.Image.Height);
        }

        private void FrontButton_Click(object sender, EventArgs e)
        {
            if (CurPictureID != 0)
            {
                MainpBox.Image = Image.FromFile(pathList[--CurPictureID]);
                panel1.AutoScrollMinSize = new System.Drawing.Size(MainpBox.Image.Width, MainpBox.Image.Height);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (CurPictureID != pathList.Count - 1)
            {
                MainpBox.Image = Image.FromFile(pathList[++CurPictureID]);
                panel1.AutoScrollMinSize = new System.Drawing.Size(MainpBox.Image.Width, MainpBox.Image.Height);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void MainpBox_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
