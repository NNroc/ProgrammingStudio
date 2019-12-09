namespace SimpleMDIExample
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(SimpleMDIExample.Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分割线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口层叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黏贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重做ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.新建NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.打开OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.保存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切Button = new System.Windows.Forms.ToolStripButton();
            this.复制Button = new System.Windows.Forms.ToolStripButton();
            this.黏贴Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoButton = new System.Windows.Forms.ToolStripButton();
            this.RedoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSCbBoxFontName = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.粗体toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.斜体toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.下划线toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.左对齐Button = new System.Windows.Forms.ToolStripButton();
            this.居中Button = new System.Windows.Forms.ToolStripButton();
            this.右对齐Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.文件ToolStripMenuItem, this.窗口ToolStripMenuItem, this.编辑ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1100, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.新建ToolStripMenuItem, this.打开ToolStripMenuItem, this.保存ToolStripMenuItem, this.分割线ToolStripMenuItem,
                this.关闭ToolStripMenuItem, this.退出ToolStripMenuItem
            });
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            this.分割线ToolStripMenuItem.Name = "分割线ToolStripMenuItem";
            this.分割线ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.分割线ToolStripMenuItem.Text = "分割线";
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.窗口层叠ToolStripMenuItem, this.水平平铺ToolStripMenuItem, this.垂直平铺ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.窗口ToolStripMenuItem.Text = "窗口";
            this.窗口层叠ToolStripMenuItem.Name = "窗口层叠ToolStripMenuItem";
            this.窗口层叠ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.窗口层叠ToolStripMenuItem.Text = "窗口层叠";
            this.窗口层叠ToolStripMenuItem.Click += new System.EventHandler(this.窗口层叠ToolStripMenuItem_Click);
            this.水平平铺ToolStripMenuItem.Name = "水平平铺ToolStripMenuItem";
            this.水平平铺ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.水平平铺ToolStripMenuItem.Text = "水平平铺";
            this.水平平铺ToolStripMenuItem.Click += new System.EventHandler(this.水平平铺ToolStripMenuItem_Click);
            this.垂直平铺ToolStripMenuItem.Name = "垂直平铺ToolStripMenuItem";
            this.垂直平铺ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.垂直平铺ToolStripMenuItem.Text = "垂直平铺";
            this.垂直平铺ToolStripMenuItem.Click += new System.EventHandler(this.垂直平铺ToolStripMenuItem_Click);
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.剪切ToolStripMenuItem, this.复制ToolStripMenuItem, this.黏贴ToolStripMenuItem, this.撤消ToolStripMenuItem,
                this.重做ToolStripMenuItem
            });
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.编辑ToolStripMenuItem.Text = "编辑";
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切Button_Click);
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制Button_Click);
            this.黏贴ToolStripMenuItem.Name = "黏贴ToolStripMenuItem";
            this.黏贴ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.黏贴ToolStripMenuItem.Text = "黏贴";
            this.黏贴ToolStripMenuItem.Click += new System.EventHandler(this.黏贴Button_Click);
            this.撤消ToolStripMenuItem.Name = "撤消ToolStripMenuItem";
            this.撤消ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.撤消ToolStripMenuItem.Text = "撤消";
            this.撤消ToolStripMenuItem.Click += new System.EventHandler(this.UndoButton_Click);
            this.重做ToolStripMenuItem.Name = "重做ToolStripMenuItem";
            this.重做ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.重做ToolStripMenuItem.Text = "重做";
            this.重做ToolStripMenuItem.Click += new System.EventHandler(this.RedoButton_Click);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.新建NToolStripButton, this.打开OToolStripButton, this.保存SToolStripButton, this.toolStripSeparator4,
                this.剪切Button, this.复制Button, this.黏贴Button, this.toolStripSeparator3, this.UndoButton, this.RedoButton,
                this.toolStripSeparator2, this.tSCbBoxFontName, this.toolStripButton1, this.toolStripButton2,
                this.粗体toolStripButton, this.斜体toolStripButton1, this.下划线toolStripButton1, this.toolStripSeparator5,
                this.左对齐Button, this.居中Button, this.右对齐Button, this.toolStripSeparator1, this.SearchButton
            });
            this.toolStrip1.Location = new System.Drawing.Point(0, 34);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1100, 32);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.新建NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新建NToolStripButton.Image = ((System.Drawing.Image) (resources.GetObject("新建NToolStripButton.Image")));
            this.新建NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripButton.Name = "新建NToolStripButton";
            this.新建NToolStripButton.Size = new System.Drawing.Size(24, 29);
            this.新建NToolStripButton.Text = "新建(&N)";
            this.新建NToolStripButton.Click += new System.EventHandler(this.新建NToolStripButton_Click);
            this.打开OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.打开OToolStripButton.Image = ((System.Drawing.Image) (resources.GetObject("打开OToolStripButton.Image")));
            this.打开OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripButton.Name = "打开OToolStripButton";
            this.打开OToolStripButton.Size = new System.Drawing.Size(24, 29);
            this.打开OToolStripButton.Text = "打开(&O)";
            this.打开OToolStripButton.Click += new System.EventHandler(this.打开OToolStripButton_Click);
            this.保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.保存SToolStripButton.Image = ((System.Drawing.Image) (resources.GetObject("保存SToolStripButton.Image")));
            this.保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripButton.Name = "保存SToolStripButton";
            this.保存SToolStripButton.Size = new System.Drawing.Size(24, 29);
            this.保存SToolStripButton.Text = "保存(&S)";
            this.保存SToolStripButton.Click += new System.EventHandler(this.保存SToolStripButton_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            this.剪切Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪切Button.Image = ((System.Drawing.Image) (resources.GetObject("剪切Button.Image")));
            this.剪切Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切Button.Name = "剪切Button";
            this.剪切Button.Size = new System.Drawing.Size(24, 29);
            this.剪切Button.Text = "toolStripButton2";
            this.剪切Button.ToolTipText = "剪切";
            this.剪切Button.Click += new System.EventHandler(this.剪切Button_Click);
            this.复制Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.复制Button.Image = ((System.Drawing.Image) (resources.GetObject("复制Button.Image")));
            this.复制Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制Button.Name = "复制Button";
            this.复制Button.Size = new System.Drawing.Size(24, 29);
            this.复制Button.Text = "toolStripButton3";
            this.复制Button.ToolTipText = "复制";
            this.复制Button.Click += new System.EventHandler(this.复制Button_Click);
            this.黏贴Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.黏贴Button.Image = ((System.Drawing.Image) (resources.GetObject("黏贴Button.Image")));
            this.黏贴Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.黏贴Button.Name = "黏贴Button";
            this.黏贴Button.Size = new System.Drawing.Size(24, 29);
            this.黏贴Button.Text = "toolStripButton4";
            this.黏贴Button.ToolTipText = "黏贴";
            this.黏贴Button.Click += new System.EventHandler(this.黏贴Button_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoButton.Image = ((System.Drawing.Image) (resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(24, 29);
            this.UndoButton.Text = "toolStripButton5";
            this.UndoButton.ToolTipText = "撤消";
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            this.RedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoButton.Image = ((System.Drawing.Image) (resources.GetObject("RedoButton.Image")));
            this.RedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(24, 29);
            this.RedoButton.Text = "toolStripButton1";
            this.RedoButton.ToolTipText = "重做";
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            this.tSCbBoxFontName.Name = "tSCbBoxFontName";
            this.tSCbBoxFontName.Size = new System.Drawing.Size(165, 32);
            this.tSCbBoxFontName.Click += new System.EventHandler(this.tSCbBoxFontName_Click);
            this.tSCbBoxFontName.TextChanged += new System.EventHandler(this.tSCbBoxFontName_TextChanged);
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 29);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 29);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            this.粗体toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粗体toolStripButton.Image = ((System.Drawing.Image) (resources.GetObject("粗体toolStripButton.Image")));
            this.粗体toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粗体toolStripButton.Name = "粗体toolStripButton";
            this.粗体toolStripButton.Size = new System.Drawing.Size(24, 29);
            this.粗体toolStripButton.Text = "toolStripButton1";
            this.粗体toolStripButton.ToolTipText = "加粗";
            this.粗体toolStripButton.Click += new System.EventHandler(this.粗体toolStripButton_Click);
            this.斜体toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.斜体toolStripButton1.Image = ((System.Drawing.Image) (resources.GetObject("斜体toolStripButton1.Image")));
            this.斜体toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.斜体toolStripButton1.Name = "斜体toolStripButton1";
            this.斜体toolStripButton1.Size = new System.Drawing.Size(24, 29);
            this.斜体toolStripButton1.Text = "toolStripButton1";
            this.斜体toolStripButton1.ToolTipText = "斜体";
            this.斜体toolStripButton1.Click += new System.EventHandler(this.斜体toolStripButton1_Click);
            this.下划线toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.下划线toolStripButton1.Image =
                ((System.Drawing.Image) (resources.GetObject("下划线toolStripButton1.Image")));
            this.下划线toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.下划线toolStripButton1.Name = "下划线toolStripButton1";
            this.下划线toolStripButton1.Size = new System.Drawing.Size(24, 29);
            this.下划线toolStripButton1.Text = "toolStripButton1";
            this.下划线toolStripButton1.ToolTipText = "下划线";
            this.下划线toolStripButton1.Click += new System.EventHandler(this.下划线toolStripButton1_Click);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 32);
            this.左对齐Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.左对齐Button.Image = ((System.Drawing.Image) (resources.GetObject("左对齐Button.Image")));
            this.左对齐Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.左对齐Button.Name = "左对齐Button";
            this.左对齐Button.Size = new System.Drawing.Size(24, 29);
            this.左对齐Button.Text = "toolStripButton2";
            this.左对齐Button.ToolTipText = "左对齐";
            this.左对齐Button.Click += new System.EventHandler(this.左对齐Button_Click);
            this.居中Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.居中Button.Image = ((System.Drawing.Image) (resources.GetObject("居中Button.Image")));
            this.居中Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.居中Button.Name = "居中Button";
            this.居中Button.Size = new System.Drawing.Size(24, 29);
            this.居中Button.Text = "toolStripButton6";
            this.居中Button.ToolTipText = "居中";
            this.居中Button.Click += new System.EventHandler(this.居中Button_Click);
            this.右对齐Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.右对齐Button.Image = ((System.Drawing.Image) (resources.GetObject("右对齐Button.Image")));
            this.右对齐Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.右对齐Button.Name = "右对齐Button";
            this.右对齐Button.Size = new System.Drawing.Size(24, 29);
            this.右对齐Button.Text = "toolStripButton7";
            this.右对齐Button.ToolTipText = "右对齐";
            this.右对齐Button.Click += new System.EventHandler(this.右对齐Button_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchButton.Image = ((System.Drawing.Image) (resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(24, 29);
            this.SearchButton.Text = "toolStripButton1";
            this.SearchButton.ToolTipText = "搜索";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "简单的多文档文本编辑器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分割线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口层叠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 新建NToolStripButton;
        private System.Windows.Forms.ToolStripButton 打开OToolStripButton;
        private System.Windows.Forms.ToolStripButton 保存SToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 粗体toolStripButton;
        private System.Windows.Forms.ToolStripButton 斜体toolStripButton1;
        private System.Windows.Forms.ToolStripButton 下划线toolStripButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripComboBox tSCbBoxFontName;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 剪切Button;
        private System.Windows.Forms.ToolStripButton 复制Button;
        private System.Windows.Forms.ToolStripButton 黏贴Button;
        private System.Windows.Forms.ToolStripButton UndoButton;
        private System.Windows.Forms.ToolStripButton RedoButton;
        private System.Windows.Forms.ToolStripButton 左对齐Button;
        private System.Windows.Forms.ToolStripButton 居中Button;
        private System.Windows.Forms.ToolStripButton 右对齐Button;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黏贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤消ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重做ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

