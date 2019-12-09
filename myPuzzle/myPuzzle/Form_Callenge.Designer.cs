namespace myPuzzle
{
    partial class Form_Callenge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_easy = new System.Windows.Forms.Button();
            this.btn_normal = new System.Windows.Forms.Button();
            this.btn_hard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_easy
            // 
            this.btn_easy.Location = new System.Drawing.Point(116, 47);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(75, 33);
            this.btn_easy.TabIndex = 0;
            this.btn_easy.Text = "简单";
            this.btn_easy.UseVisualStyleBackColor = true;
            this.btn_easy.Click += new System.EventHandler(this.btn_easy_Click);
            // 
            // btn_normal
            // 
            this.btn_normal.Location = new System.Drawing.Point(116, 86);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(75, 33);
            this.btn_normal.TabIndex = 1;
            this.btn_normal.Text = "普通";
            this.btn_normal.UseVisualStyleBackColor = true;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // btn_hard
            // 
            this.btn_hard.Location = new System.Drawing.Point(116, 125);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(75, 34);
            this.btn_hard.TabIndex = 2;
            this.btn_hard.Text = "困难";
            this.btn_hard.UseVisualStyleBackColor = true;
            this.btn_hard.Click += new System.EventHandler(this.btn_hard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "请选择难度";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(116, 195);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 36);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "取消";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form_Callenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 312);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hard);
            this.Controls.Add(this.btn_normal);
            this.Controls.Add(this.btn_easy);
            this.Name = "Form_Callenge";
            this.Text = "挑战模式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_easy;
        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.Button btn_hard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
    }
}