using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace myPuzzle
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            InitGame();
            this.Paint += new PaintEventHandler(Puzzle_Paint);
        }

        //图片列表
        PictureBox[] pictureList = null;

        //图片位置字典
        SortedDictionary<string, Bitmap> pictureLocationDict = new SortedDictionary<string, Bitmap>();

        //位置表
        Point[] pointList = null;

        //图片控件字典
        SortedDictionary<string, PictureBox> pictureBoxLocationDict = new SortedDictionary<string, PictureBox>();

        //拼图时间
        int second = 0;

        //难度时间
        int toptime = 0;

        //拖曳的图片
        PictureBox currentPictureBox = null;

        //被迫需要移动的图片
        PictureBox haveToPictureBox = null;

        //原位置
        Point oldLocation = Point.Empty;

        //新位置
        Point newLocation = Point.Empty;

        //鼠标按下坐标 的相对位置
        Point mouseDownPoint = Point.Empty;

        //显示拖动效果的矩形
        Rectangle rect = Rectangle.Empty;

        //是否正在拖曳
        bool isDrag = false;

        //图片位置
        public string priginalpicpath;

        //源图片位置
        public string originalpicpath;

        /// <summary>
        /// 每个方向上要切割成的块数
        /// </summary>
        private int ImgNumbers
        {
            get
            {
                return (int)this.numericUpDown1.Value;
            }
        }

        /// <summary>
        /// 要切割成的正方形图片边长         
        /// </summary>
        private int SideLength
        {
            get
            {
                return 600 / this.ImgNumbers;
            }
        }

        /// <summary>
        /// 创建画板
        /// </summary>
        private void Puzzle_Paint(object sender, PaintEventArgs e)
        {
            if (rect != Rectangle.Empty)
            {
                if (isDrag)
                {
                    e.Graphics.DrawRectangle(Pens.Red, rect);
                }
                else
                {
                    e.Graphics.DrawRectangle(new Pen(this.BackColor), rect);
                }
            }
        }

            /// <summary>
            /// 生成图片框矩阵，并初始化每个图片框的位置放在panel控件上
            /// </summary>
            private void InitRandomPictureBox()
        {
            pnlContainor.Panel1.Controls.Clear();
            pictureList = new PictureBox[ImgNumbers * ImgNumbers];
            pointList = new Point[ImgNumbers * ImgNumbers];
            for (int i = 0; i < this.ImgNumbers; i++)
            {
                for (int j = 0; j < this.ImgNumbers; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Name = "pictureBox" + (j + i * ImgNumbers + 1).ToString();
                    pic.Location = new Point(j * SideLength, i * SideLength);
                    pic.Size = new Size(SideLength, SideLength);
                    pic.Visible = true;
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    pic.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
                    pic.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
                    pic.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
                    pnlContainor.Panel1.Controls.Add(pic);
                    pictureList[j + i * ImgNumbers] = pic;
                    pointList[j + i * ImgNumbers] = new Point(j * SideLength, i * SideLength);
                }
            }
        }

        /// <summary>
        /// 切割图片并保存在CutPicture.BitMapList，并加载
        /// </summary>
        public void Flow(string path, bool disorder)
        {
            InitRandomPictureBox();
            Image bm = CutPicture.Resize(path, 600, 600);
            CutPicture.BitMapList = new List<Bitmap>();
            for (int y = 0; y < 600; y += SideLength)
            {
                for (int x = 0; x < 600; x += SideLength)
                {
                    Bitmap temp = CutPicture.Cut(bm, x, y, SideLength, SideLength);
                    CutPicture.BitMapList.Add(temp);
                }
            }
            ImportBitMap(disorder);
        }

        /// <summary>
        /// 加载图片
        /// </summary>
        public void ImportBitMap(bool disorder)
        {
            try
            {
                int i = 0;
                foreach (PictureBox item in pictureList)
                {
                    Bitmap temp = CutPicture.BitMapList[i];
                    item.Image = temp;
                    i++;
                }
                if (disorder)
                    ResetPictureLocation();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        /// <summary>
        /// 重新设置图片位置
        /// </summary>
        public void ResetPictureLocation()
        {
            Point[] disorderList = (Point[])pointList.Clone();
            Point temp;
            Random rand = new Random();
            int p, i;
            for (i = 0; i < disorderList.Length; i++)
            {
                p = rand.Next(disorderList.Length - 1);
                temp = disorderList[i];
                disorderList[i] = disorderList[p];
                disorderList[p] = temp;
            }
            i = 0;
            foreach (PictureBox item in pictureList)
            {
                item.Location = disorderList[i++];
            }
        }

        /// <summary>
        /// 初始化游戏资源
        /// </summary>
        public void InitGame()
        {
            
            if (!Directory.Exists(Application.StartupPath.ToString() + "\\Picture"))
            {
                Directory.CreateDirectory(Application.StartupPath.ToString() + "\\picture");
            }
            
            Properties.Resources._0.Save(Application.StartupPath.ToString() + "\\Picture\\0.jpg");
            Properties.Resources.hh.Save(Application.StartupPath.ToString() + "\\Picture\\1.jpg");
            Properties.Resources._1.Save(Application.StartupPath.ToString() + "\\Picture\\2.jpg");
            Properties.Resources._2.Save(Application.StartupPath.ToString() + "\\Picture\\3.jpg");
            Properties.Resources._3.Save(Application.StartupPath.ToString() + "\\Picture\\4.jpg");
            Properties.Resources._4.Save(Application.StartupPath.ToString() + "\\Picture\\5.jpg");
            Properties.Resources.success.Save(Application.StartupPath.ToString() + "\\Picture\\6.jpg");
            Properties.Resources.choose.Save(Application.StartupPath.ToString() + "\\Picture\\7.jpg");
            
            Random r = new Random();
            int i = r.Next(7);
            originalpicpath = Application.StartupPath.ToString() + "\\Picture\\" + i.ToString() + ".jpg";
            Flow(originalpicpath, true);
        }

        /// <summary>
        /// 获取图片框位置
        /// </summary>
        public PictureBox GetPictureBoxByLocation(int x, int y)
        {
            PictureBox pic = null;
            foreach (PictureBox item in pictureList)
            {
                if (x >= item.Location.X && y >= item.Location.Y && item.Location.X + SideLength > x && item.Location.Y + SideLength > y)
                {
                    pic = item;
                }
            }
            return pic;
        }

        /// <summary>
        /// 按下鼠标事件
        /// </summary>
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            oldLocation = new Point(e.X, e.Y);
            currentPictureBox = GetPictureBoxByHashCode(sender.GetHashCode().ToString());
            MoseDown(currentPictureBox, sender, e);
        }
        public void MoseDown(PictureBox pic, object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldLocation = e.Location;
                rect = pic.Bounds;
            }
        }
        public PictureBox GetPictureBoxByHashCode(string hashcode)
        {
            PictureBox pic = null;
            foreach (PictureBox item in pictureList)
            {
                if (hashcode == item.GetHashCode().ToString())
                {
                    pic = item;
                }
            }
            return pic;
        }

        /// <summary>
        /// 移动鼠标事件
        /// </summary>
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrag = true;
                rect.Location = Location;
                this.Refresh();
            }
        }
        private Point getPointToForm(Point p)
        {
            return this.PointToClient(pnlContainor.Panel1.PointToScreen(p));
        }

        /// <summary>
        /// 释放鼠标
        /// </summary>
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentPictureBox != null)
            {
                oldLocation = new Point(currentPictureBox.Location.X, currentPictureBox.Location.Y);
                if (oldLocation.X + e.X > pnlContainor.Panel1.Width || oldLocation.Y + e.Y > pnlContainor.Panel1.Height || oldLocation.X + e.X < 0 || oldLocation.Y + e.Y < 0)
                {
                    return;
                }
                haveToPictureBox = GetPictureBoxByLocation(oldLocation.X + e.X, oldLocation.Y + e.Y);
                newLocation = new Point(haveToPictureBox.Location.X, haveToPictureBox.Location.Y);
                haveToPictureBox.Location = oldLocation;
                PictureMouseUp(currentPictureBox, sender, e);
                if (Judge())
                {
                    timer_usetime.Stop();
                    MessageBox.Show("拼图成功！\n你用时:" + second + "s", "确认后重玩", MessageBoxButtons.OK);
                    btn_import.Enabled = true;
                    btn_Changepic.Enabled = true;
                    numericUpDown1.Enabled = true;
                    btn_ChallengeStop_Click(btn_Challenge,new EventArgs());
                    ResetPictureLocation();
                }
            }
        }
        public void PictureMouseUp (PictureBox pic, object sender,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isDrag)
                {
                    isDrag = false;
                    pic.Location = newLocation;
                    this.Refresh();
                }
                reset();
            }
        }
        private void reset()
        {
            mouseDownPoint = Point.Empty;
            rect = Rectangle.Empty;
            isDrag = false;
        }
        public bool Judge()
        {
            bool result = true;
            int i = 0;
            foreach (PictureBox item in pictureList)
            {
                if (item.Location != pointList[i])
                {
                    result = false;
                }
                i++;
            }
            return result;
        }

        
        /// <summary>
        /// 试玩新图
        /// </summary>
        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog new_picture = new OpenFileDialog();
            if (new_picture.ShowDialog() == DialogResult.OK)
            {
                new_picture.OpenFile();
                originalpicpath = new_picture.FileName;
                CutPicture.PicturePath = new_picture.FileName;
                Flow(CutPicture.PicturePath, true);
            }
            
        }

        /// <summary>
        /// 图片重排
        /// </summary>
        private void btn_Reset_Click (object sender,EventArgs e)
        {
            Flow(originalpicpath, true);
        }

        /// <summary>
        /// 查看原图
        /// </summary>
        private void btn_Originalpic_Click(object sender,EventArgs e)
        {
            Form_Original original = new Form_Original();
            original.picpath = originalpicpath;
            original.ShowDialog();
        }

        /// <summary>
        /// 更换图片
        /// </summary>
        private void btn_Changepic_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(7);
            originalpicpath = Application.StartupPath.ToString() + "\\Picture\\" + i.ToString() + ".jpg";
            Flow(originalpicpath, true);
        }

        /// <summary>
        /// 开始挑战
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Challenge_Click(object sender, EventArgs e)
        {
            Form_Callenge challengeBox = new Form_Callenge(this);
            challengeBox.Show();
            this.Enabled = false;
        }
        
        public void startGame()
        {
            timer_usetime.Interval = 1000;
            lab_Usetime.Text = "已用时间: 0s";
            lab_AllTime.Text = "总时间: " + toptime + "s";
            lab_RestTime.Text = "剩余时间: " + toptime + "s";
            second = 0;
            timer_usetime.Start();
            btn_Challenge.Click -= new EventHandler(btn_Challenge_Click);
            btn_Challenge.Click += new EventHandler(btn_ChallengeStop_Click);
            btn_import.Enabled = false;
            btn_Changepic.Enabled = false;
            numericUpDown1.Enabled = false;
            btn_Challenge.Text = "结束挑战";
        }

        private void btn_ChallengeStop_Click(object sender, EventArgs e)
        {
            timer_usetime.Stop();
            lab_Usetime.Text = "";
            lab_RestTime.Text = "";
            lab_AllTime.Text = "";
            btn_Challenge.Click += new EventHandler(btn_Challenge_Click);
            btn_Challenge.Click -= new EventHandler(btn_ChallengeStop_Click);
            btn_import.Enabled = true;
            btn_Changepic.Enabled = true;
            numericUpDown1.Enabled = true;
            btn_Challenge.Text = "开始挑战";
        }

        private void timer_usetime_Tick(object sender, EventArgs e)
        {
            second++;
            lab_Usetime.Text = "已用时间: " + second.ToString() + "s";
            lab_RestTime.Text = "剩余时间: " + (toptime - second) + "s";
            if (second >= toptime)
            {
                lab_Usetime.Text = "";
                lab_RestTime.Text = "";
                lab_AllTime.Text = "";
                timer_usetime.Stop();
                MessageBox.Show("挑战失败");
                btn_import.Enabled = true;
                btn_Changepic.Enabled = true;
                numericUpDown1.Enabled = true;
                btn_ChallengeStop_Click(btn_Challenge, new EventArgs());
            }
        }

        /// <summary>
        /// 选择难度
        /// </summary>
        public void DifficultChoose (int level)
        {
            switch (level)
            {
                case 1:
                    toptime = 30;
                    break;
                case 2:
                    toptime = 20;
                    break;
                case 3:
                    toptime = 10;
                    break;
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            return;
        }
    }
}
