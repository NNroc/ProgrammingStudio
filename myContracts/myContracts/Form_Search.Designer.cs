namespace myContracts
{
    partial class Form_Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_searchitem = new System.Windows.Forms.ComboBox();
            this.txt_searchtext = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找学生:";
            // 
            // cb_searchitem
            // 
            this.cb_searchitem.FormattingEnabled = true;
            this.cb_searchitem.Items.AddRange(new object[] {"学生编号", "学生姓名"});
            this.cb_searchitem.Location = new System.Drawing.Point(207, 32);
            this.cb_searchitem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_searchitem.Name = "cb_searchitem";
            this.cb_searchitem.Size = new System.Drawing.Size(163, 32);
            this.cb_searchitem.TabIndex = 2;
            this.cb_searchitem.Text = "学生编号";
            this.cb_searchitem.SelectedIndexChanged += new System.EventHandler(this.cb_searchitem_SelectedIndexChanged);
            // 
            // txt_searchtext
            // 
            this.txt_searchtext.Location = new System.Drawing.Point(413, 32);
            this.txt_searchtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_searchtext.Name = "txt_searchtext";
            this.txt_searchtext.Size = new System.Drawing.Size(204, 30);
            this.txt_searchtext.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(687, 32);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(103, 37);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "查找";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(825, 32);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(103, 37);
            this.bt_close.TabIndex = 4;
            this.bt_close.Text = "关闭";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(997, 624);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 720);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_searchtext);
            this.Controls.Add(this.cb_searchitem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Search";
            this.Text = "Form_Search";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_searchitem;
        private System.Windows.Forms.TextBox txt_searchtext;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}