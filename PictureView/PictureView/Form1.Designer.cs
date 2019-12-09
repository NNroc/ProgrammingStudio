namespace PictureView
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.OpenButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ZoomaddButton = new System.Windows.Forms.ToolStripButton();
            this.ZoomsubButton = new System.Windows.Forms.ToolStripButton();
            this.RestoreButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FrontButton = new System.Windows.Forms.ToolStripButton();
            this.NextButton = new System.Windows.Forms.ToolStripButton();
            this.DirectorytV = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainpBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.MainpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.OpenButton, this.toolStripSeparator1, this.ZoomaddButton, this.ZoomsubButton, this.RestoreButton,
                this.toolStripSeparator2, this.FrontButton, this.NextButton
            });
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(1009, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked +=
                new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(23, 22);
            this.OpenButton.Text = "toolStripButton1";
            this.OpenButton.ToolTipText = "打开";
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ZoomaddButton
            // 
            this.ZoomaddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomaddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomaddButton.Name = "ZoomaddButton";
            this.ZoomaddButton.Size = new System.Drawing.Size(23, 22);
            this.ZoomaddButton.Text = "toolStripButton2";
            this.ZoomaddButton.ToolTipText = "放大";
            this.ZoomaddButton.Click += new System.EventHandler(this.ZoomaddButton_Click);
            // 
            // ZoomsubButton
            // 
            this.ZoomsubButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomsubButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomsubButton.Name = "ZoomsubButton";
            this.ZoomsubButton.Size = new System.Drawing.Size(23, 22);
            this.ZoomsubButton.Text = "toolStripButton3";
            this.ZoomsubButton.ToolTipText = "缩小";
            this.ZoomsubButton.Click += new System.EventHandler(this.ZoomsubButton_Click);
            // 
            // RestoreButton
            // 
            this.RestoreButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RestoreButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(23, 22);
            this.RestoreButton.Text = "toolStripButton4";
            this.RestoreButton.ToolTipText = "还原";
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FrontButton
            // 
            this.FrontButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FrontButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrontButton.Name = "FrontButton";
            this.FrontButton.Size = new System.Drawing.Size(23, 22);
            this.FrontButton.Text = "toolStripButton5";
            this.FrontButton.ToolTipText = "上一张";
            this.FrontButton.Click += new System.EventHandler(this.FrontButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(23, 22);
            this.NextButton.Text = "toolStripButton6";
            this.NextButton.ToolTipText = "下一张";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // DirectorytV
            // 
            this.DirectorytV.Dock = System.Windows.Forms.DockStyle.Left;
            this.DirectorytV.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DirectorytV.Location = new System.Drawing.Point(0, 25);
            this.DirectorytV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DirectorytV.Name = "DirectorytV";
            this.DirectorytV.Size = new System.Drawing.Size(333, 574);
            this.DirectorytV.TabIndex = 1;
            this.DirectorytV.BeforeExpand +=
                new System.Windows.Forms.TreeViewCancelEventHandler(this.DirectorytV_BeforeExpand);
            this.DirectorytV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DirectorytV_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainpBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(333, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 574);
            this.panel1.TabIndex = 2;
            // 
            // MainpBox
            // 
            this.MainpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainpBox.Location = new System.Drawing.Point(0, 0);
            this.MainpBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainpBox.Name = "MainpBox";
            this.MainpBox.Size = new System.Drawing.Size(676, 574);
            this.MainpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MainpBox.TabIndex = 3;
            this.MainpBox.TabStop = false;
            this.MainpBox.Click += new System.EventHandler(this.MainpBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DirectorytV);
            this.Controls.Add(this.toolStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "图片浏览器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.MainpBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripButton OpenButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ZoomaddButton;
        private System.Windows.Forms.ToolStripButton ZoomsubButton;
        private System.Windows.Forms.ToolStripButton RestoreButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton FrontButton;
        private System.Windows.Forms.ToolStripButton NextButton;
        private System.Windows.Forms.TreeView DirectorytV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MainpBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}

