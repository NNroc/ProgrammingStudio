using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Web;
using Microsoft.VisualBasic;

namespace SimpleMDIExample
{
    public partial class Form1 : Form
    {
        public int _Num = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tSCbBoxFontName.Items.Clear();
            InstalledFontCollection ifc = new InstalledFontCollection();
            FontFamily[] ffs = ifc.Families;
            foreach (FontFamily ff in ffs)
                tSCbBoxFontName.Items.Add(ff.GetName(1));
            LayoutMdi(MdiLayout.Cascade);
            Text = "多文档文本编辑器";
            WindowState = FormWindowState.Maximized;
        }

        private void 窗口层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
            this.窗口层叠ToolStripMenuItem.Checked = true;
            this.水平平铺ToolStripMenuItem.Checked = false;
            this.垂直平铺ToolStripMenuItem.Checked = false;
        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
            this.窗口层叠ToolStripMenuItem.Checked = false;
            this.水平平铺ToolStripMenuItem.Checked = true;
            this.垂直平铺ToolStripMenuItem.Checked = false;
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
            this.窗口层叠ToolStripMenuItem.Checked = false;
            this.水平平铺ToolStripMenuItem.Checked = false;
            this.垂直平铺ToolStripMenuItem.Checked = true;
        }

        private void NewDoc()
        {
            FrmDoc fd = new FrmDoc();
            fd.MdiParent = this;
            fd.Text = "文档" + _Num;
            fd.WindowState = FormWindowState.Maximized;
            fd.Show();
            fd.Activate();
            _Num++;
        }

        private void 新建NToolStripButton_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "文本文件(*.txt)|*.txt|RTF格式(*.rtf)|*.rtf|所有文件(*.*)|*.*";
            openfiledialog1.Multiselect = false;
            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewDoc();
                    _Num--;
                    if (openfiledialog1.FilterIndex == 1)
                    {
                        ((FrmDoc) this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                        ((FrmDoc) this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.PlainText);

                    ((FrmDoc) this.ActiveMdiChild).Text = openfiledialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            openfiledialog1.Dispose();
        }

        private void 保存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                SaveFileDialog savefiledialog1 = new SaveFileDialog
                {
                    Filter = "文本文件(*.txt)|*.txt|RTF格式(*.rtf)|*.rtf|所有文件(*.*)|*.*"
                };
                if (savefiledialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (savefiledialog1.FilterIndex == 1)
                            ((FrmDoc) this.ActiveMdiChild).rTBDoc.SaveFile
                                (savefiledialog1.FileName, RichTextBoxStreamType.RichText);
                        else
                            ((FrmDoc) this.ActiveMdiChild).rTBDoc.SaveFile
                                (savefiledialog1.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("保存成功！", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                savefiledialog1.Dispose();
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                if (MessageBox.Show("确定要关闭当前文档吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                    DialogResult.OK)
                {
                    ((FrmDoc) this.ActiveMdiChild).Close();
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出应用程序吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                DialogResult.OK)
            {
                foreach (FrmDoc fd in this.MdiChildren)
                    fd.Close();
                Application.Exit();
            }
        }

        private void tSCbBoxFontName_TextChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                RichTextBox tempRTB = new RichTextBox();
                int RtbStart = ((FrmDoc) this.ActiveMdiChild).rTBDoc.SelectionStart;
                int len = ((FrmDoc) this.ActiveMdiChild).rTBDoc.SelectionLength;
                int tempRtbStart = 0;
                Font font = ((FrmDoc) this.ActiveMdiChild).rTBDoc.SelectionFont;
                if (len <= 0 && null != font)
                {
                    ((FrmDoc) this.ActiveMdiChild).rTBDoc.SelectAll();
                    tempRTB.Rtf = ((FrmDoc) this.ActiveMdiChild).rTBDoc.SelectedRtf;
                    len = ((FrmDoc) this.ActiveMdiChild).rTBDoc.SelectionLength;
                    for (int i = 0; i < len; i++)
                    {
                        tempRTB.Select(tempRtbStart + i, 0);

                        tempRTB.SelectionFont = new Font(tSCbBoxFontName.Text, tempRTB.SelectionFont.Size,
                            tempRTB.SelectionFont.Style);
                    }

                    ((FrmDoc) this.ActiveMdiChild).rTBDoc.Focus();
                    return;
                }

                tempRTB.Rtf = ((FrmDoc) this.ActiveMdiChild).rTBDoc.SelectedRtf;
                for (int i = 0; i < len; i++)
                {
                    tempRTB.Select(tempRtbStart + i, 1);

                    tempRTB.SelectionFont = new Font(tSCbBoxFontName.Text, tempRTB.SelectionFont.Size,
                        tempRTB.SelectionFont.Style);
                }

                tempRTB.Select(tempRtbStart, len);
                ((FrmDoc) this.ActiveMdiChild).rTBDoc.SelectedRtf = tempRTB.SelectedRtf;
                ((FrmDoc) this.ActiveMdiChild).rTBDoc.Select(RtbStart, len);
                ((FrmDoc) this.ActiveMdiChild).rTBDoc.Focus();
                tempRTB.Dispose();
            }
        }

        private void ChangeRTBFontStyle(RichTextBox rtb, FontStyle style)
        {
            //改变字体样式
            if (style != FontStyle.Bold &&
                style != FontStyle.Italic &&
                style != FontStyle.Underline)
                throw new System.InvalidProgramException("字体格式错误！");
            RichTextBox tempRTB = new RichTextBox();
            int curRtbStart = rtb.SelectionStart;
            int len = rtb.SelectionLength;
            int tempRtbStart = 0;
            Font font = rtb.SelectionFont;

            if (len <= 0 && font != null)
            {
                if (style == FontStyle.Bold && font.Bold ||
                    style == FontStyle.Italic && font.Italic ||
                    style == FontStyle.Underline && font.Underline)
                    rtb.Font = new Font(font, font.Style ^ style);
                else if (style == FontStyle.Bold && !font.Bold ||
                         style == FontStyle.Italic && !font.Italic ||
                         style == FontStyle.Underline && !font.Underline)
                    rtb.Font = new Font(font, font.Style | style);
                return;
            }

            tempRTB.Rtf = rtb.SelectedRtf;
            tempRTB.Select(len - 1, 1);

            Font tempFont = (Font) tempRTB.SelectionFont.Clone();
            for (int i = 0; i < len; i++)
            {
                tempRTB.Select(tempRtbStart + i, 1);
                if (style == FontStyle.Bold && font.Bold ||
                    style == FontStyle.Italic && font.Italic ||
                    style == FontStyle.Underline && font.Underline)
                    tempRTB.SelectionFont = new Font(tempRTB.SelectionFont, tempRTB.SelectionFont.Style ^ style);
                else if (style == FontStyle.Bold && !font.Bold ||
                         style == FontStyle.Italic && !font.Italic ||
                         style == FontStyle.Underline && !font.Underline)
                    tempRTB.SelectionFont = new Font(tempRTB.SelectionFont, tempRTB.SelectionFont.Style | style);
            }

            tempRTB.Select(tempRtbStart, len);
            rtb.SelectedRtf = tempRTB.SelectedRtf;
            rtb.Select(curRtbStart, len);
            rtb.Focus();
            tempRTB.Dispose();
        }

        private void 粗体toolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRTBFontStyle(((FrmDoc) this.ActiveMdiChild).rTBDoc, FontStyle.Bold);
        }

        private void 斜体toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRTBFontStyle(((FrmDoc) this.ActiveMdiChild).rTBDoc, FontStyle.Italic);
        }

        private void 下划线toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRTBFontStyle(((FrmDoc) this.ActiveMdiChild).rTBDoc, FontStyle.Underline);
        }

        public RichTextBox textStorage = new RichTextBox();

        private void 剪切Button_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = ((FrmDoc) this.ActiveMdiChild).rTBDoc;
            textStorage.Rtf = rtb.SelectedRtf;
            rtb.SelectedRtf = "";
        }

        private void 复制Button_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = ((FrmDoc) this.ActiveMdiChild).rTBDoc;
            textStorage.Rtf = rtb.SelectedRtf;
        }

        private void 黏贴Button_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = ((FrmDoc) this.ActiveMdiChild).rTBDoc;
            textStorage.Select(0, textStorage.TextLength);
            rtb.SelectedRtf = textStorage.SelectedRtf;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            ((FrmDoc) this.ActiveMdiChild).rTBDoc.Undo();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            ((FrmDoc) this.ActiveMdiChild).rTBDoc.Redo();
        }

        private void ChangeTextAlgin(RichTextBox rtb, int way)
        {
            switch (way)
            {
                case 0:
                    rtb.SelectionAlignment = HorizontalAlignment.Left;
                    break;
                case 1:
                    rtb.SelectionAlignment = HorizontalAlignment.Center;
                    break;
                case 2:
                    rtb.SelectionAlignment = HorizontalAlignment.Right;
                    break;
                default:
                    break;
            }
        }

        private void 左对齐Button_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeTextAlgin(((FrmDoc) this.ActiveMdiChild).rTBDoc, 0);
        }

        private void 居中Button_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeTextAlgin(((FrmDoc) this.ActiveMdiChild).rTBDoc, 1);
        }

        private void 右对齐Button_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeTextAlgin(((FrmDoc) this.ActiveMdiChild).rTBDoc, 2);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch(((FrmDoc) this.ActiveMdiChild).rTBDoc);
            formSearch.Show();
        }

        private void tSCbBoxFontName_Click(object sender, EventArgs e)
        {
            return;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "文本文件(*.txt)|*.txt|RTF格式(*.rtf)|*.rtf|所有文件(*.*)|*.*";
            openfiledialog1.Multiselect = false;
            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewDoc();
                    _Num--;
                    if (openfiledialog1.FilterIndex == 1)
                    {
                        ((FrmDoc) this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                        ((FrmDoc) this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.PlainText);

                    ((FrmDoc) this.ActiveMdiChild).Text = openfiledialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            openfiledialog1.Dispose();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                SaveFileDialog savefiledialog1 = new SaveFileDialog
                {
                    Filter = "文本文件(*.txt)|*.txt|RTF格式(*.rtf)|*.rtf|所有文件(*.*)|*.*"
                };
                if (savefiledialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (savefiledialog1.FilterIndex == 1)
                            ((FrmDoc) this.ActiveMdiChild).rTBDoc.SaveFile
                                (savefiledialog1.FileName, RichTextBoxStreamType.RichText);
                        else
                            ((FrmDoc) this.ActiveMdiChild).rTBDoc.SaveFile
                                (savefiledialog1.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("保存成功！", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                savefiledialog1.Dispose();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = ((FrmDoc) this.ActiveMdiChild).rTBDoc;
            if (rtb.SelectionFont.Size <= 95)
            {
                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size + 5,
                    rtb.SelectionFont.Style);
            }
            else
            {
                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, 100,
                    rtb.SelectionFont.Style);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = ((FrmDoc) this.ActiveMdiChild).rTBDoc;
            if (rtb.SelectionFont.Size > 10)
            {
                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size - 5,
                    rtb.SelectionFont.Style);
            }
            else if (rtb.SelectionFont.Size <= 10)
            {
                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, 5,
                    rtb.SelectionFont.Style);
            }
        }
    }
}