﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPuzzle
{
    public partial class Form_Original : Form
    {
        public Form_Original()
        {
            InitializeComponent();
        }

        //图片路径
        public string picpath = null;

        /// <summary>
        /// 打开正在拼图的图片原图
        /// </summary>
        private void Form_Original_Load(object sender, EventArgs e)
        {
            pb_Original.Image = CutPicture.Resize(picpath, 600, 600);
        }

    }
}
