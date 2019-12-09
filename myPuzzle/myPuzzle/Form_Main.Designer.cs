namespace myPuzzle
{
    partial class Form_Main
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
            this.pnlContainor = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_RestTime = new System.Windows.Forms.Label();
            this.lab_AllTime = new System.Windows.Forms.Label();
            this.btn_Challenge = new System.Windows.Forms.Button();
            this.lab_Usetime = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Changepic = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_Originalpic = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.timer_usetime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.pnlContainor)).BeginInit();
            this.pnlContainor.Panel2.SuspendLayout();
            this.pnlContainor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainor
            // 
            this.pnlContainor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainor.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.pnlContainor.Location = new System.Drawing.Point(0, 0);
            this.pnlContainor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContainor.Name = "pnlContainor";
            // 
            // pnlContainor.Panel1
            // 
            this.pnlContainor.Panel1.Tag = "Left";
            // 
            // pnlContainor.Panel2
            // 
            this.pnlContainor.Panel2.Controls.Add(this.label1);
            this.pnlContainor.Panel2.Controls.Add(this.lab_RestTime);
            this.pnlContainor.Panel2.Controls.Add(this.lab_AllTime);
            this.pnlContainor.Panel2.Controls.Add(this.btn_Challenge);
            this.pnlContainor.Panel2.Controls.Add(this.lab_Usetime);
            this.pnlContainor.Panel2.Controls.Add(this.numericUpDown1);
            this.pnlContainor.Panel2.Controls.Add(this.btn_Reset);
            this.pnlContainor.Panel2.Controls.Add(this.btn_Changepic);
            this.pnlContainor.Panel2.Controls.Add(this.btn_import);
            this.pnlContainor.Panel2.Controls.Add(this.btn_Originalpic);
            this.pnlContainor.Panel2.Tag = "Right";
            this.pnlContainor.Size = new System.Drawing.Size(1624, 1050);
            this.pnlContainor.SplitterDistance = 600;
            this.pnlContainor.SplitterWidth = 5;
            this.pnlContainor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(73, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "切割片数(n*n)：";
            // 
            // lab_RestTime
            // 
            this.lab_RestTime.AutoSize = true;
            this.lab_RestTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lab_RestTime.Location = new System.Drawing.Point(70, 496);
            this.lab_RestTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_RestTime.Name = "lab_RestTime";
            this.lab_RestTime.Size = new System.Drawing.Size(0, 24);
            this.lab_RestTime.TabIndex = 9;
            // 
            // lab_AllTime
            // 
            this.lab_AllTime.AutoSize = true;
            this.lab_AllTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lab_AllTime.Location = new System.Drawing.Point(71, 544);
            this.lab_AllTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_AllTime.Name = "lab_AllTime";
            this.lab_AllTime.Size = new System.Drawing.Size(0, 24);
            this.lab_AllTime.TabIndex = 8;
            // 
            // btn_Challenge
            // 
            this.btn_Challenge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Challenge.Location = new System.Drawing.Point(76, 386);
            this.btn_Challenge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Challenge.Name = "btn_Challenge";
            this.btn_Challenge.Size = new System.Drawing.Size(308, 48);
            this.btn_Challenge.TabIndex = 7;
            this.btn_Challenge.Text = "挑战模式";
            this.btn_Challenge.UseVisualStyleBackColor = true;
            this.btn_Challenge.Click += new System.EventHandler(this.btn_Challenge_Click);
            // 
            // lab_Usetime
            // 
            this.lab_Usetime.AutoSize = true;
            this.lab_Usetime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lab_Usetime.Location = new System.Drawing.Point(70, 448);
            this.lab_Usetime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Usetime.Name = "lab_Usetime";
            this.lab_Usetime.Size = new System.Drawing.Size(0, 24);
            this.lab_Usetime.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(312, 128);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {20, 0, 0, 0});
            this.numericUpDown1.Minimum = new decimal(new int[] {2, 0, 0, 0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 30);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {3, 0, 0, 0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Location = new System.Drawing.Point(246, 296);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(137, 48);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "图片重排";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Changepic
            // 
            this.btn_Changepic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Changepic.Location = new System.Drawing.Point(76, 296);
            this.btn_Changepic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Changepic.Name = "btn_Changepic";
            this.btn_Changepic.Size = new System.Drawing.Size(137, 48);
            this.btn_Changepic.TabIndex = 2;
            this.btn_Changepic.Text = "切换图片";
            this.btn_Changepic.UseVisualStyleBackColor = true;
            this.btn_Changepic.Click += new System.EventHandler(this.btn_Changepic_Click);
            // 
            // btn_import
            // 
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_import.Location = new System.Drawing.Point(246, 208);
            this.btn_import.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(137, 48);
            this.btn_import.TabIndex = 1;
            this.btn_import.Text = "试玩新图";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_Originalpic
            // 
            this.btn_Originalpic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Originalpic.Location = new System.Drawing.Point(76, 208);
            this.btn_Originalpic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Originalpic.Name = "btn_Originalpic";
            this.btn_Originalpic.Size = new System.Drawing.Size(137, 48);
            this.btn_Originalpic.TabIndex = 0;
            this.btn_Originalpic.Text = "查看原图";
            this.btn_Originalpic.UseVisualStyleBackColor = true;
            this.btn_Originalpic.Click += new System.EventHandler(this.btn_Originalpic_Click);
            // 
            // timer_usetime
            // 
            this.timer_usetime.Tick += new System.EventHandler(this.timer_usetime_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1624, 1050);
            this.Controls.Add(this.pnlContainor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myPuzzle";
            this.pnlContainor.Panel2.ResumeLayout(false);
            this.pnlContainor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pnlContainor)).EndInit();
            this.pnlContainor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer pnlContainor;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Changepic;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_Originalpic;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label lab_Usetime;
        private System.Windows.Forms.Button btn_Challenge;
        private System.Windows.Forms.Label lab_AllTime;
        private System.Windows.Forms.Timer timer_usetime;
        private System.Windows.Forms.Label lab_RestTime;
        private System.Windows.Forms.Label label1;
    }
}

