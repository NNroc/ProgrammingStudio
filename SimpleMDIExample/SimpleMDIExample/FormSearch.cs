using System;
using System.Windows.Forms;

namespace SimpleMDIExample
{
    public partial class FormSearch : Form
    {
        private RichTextBox _rtb;
        private int start = 0;
        private int count = 0;

        public FormSearch()
        {
            this.ControlBox = false;

            InitializeComponent();
        }

        public FormSearch(RichTextBox rtb) : this()
        {
            _rtb = rtb;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string str = textSearch.Text;
            if (start >= _rtb.Text.Length)
            {
                MessageBox.Show("已查找到尾部");
                start = 0;
            }
            else
            {
                if (start != -1)
                {
                    start = _rtb.Find(str, start, RichTextBoxFinds.MatchCase);
                }

                if (start == -1)
                {
                    if (count == 0)
                    {
                        MessageBox.Show("没有该字符");
                    }
                    else
                    {
                        MessageBox.Show("已查找到尾部！");
                        start = 0;
                        count = 0;
                    }
                }
                else
                {
                    start = start + str.Length;
                    count++;
                    _rtb.Focus();
                }
            }
        }
    }
}