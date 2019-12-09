namespace myContracts
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_add = new System.Windows.Forms.ToolStripButton();
            this.toolStript_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_search = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_backup = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_recover = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.professionTreeView = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_add,
            this.toolStript_edit,
            this.toolStrip_delete,
            this.toolStrip_search,
            this.toolStrip_backup,
            this.toolStrip_recover});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1252, 90);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_add
            // 
            this.toolStrip_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip_add.Image = global::myContracts.Properties.Resources.ADD1;
            this.toolStrip_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStrip_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_add.Name = "toolStrip_add";
            this.toolStrip_add.Size = new System.Drawing.Size(54, 87);
            this.toolStrip_add.Text = "添加";
            this.toolStrip_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStrip_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_add.Click += new System.EventHandler(this.toolStrip_add_Click);
            // 
            // toolStript_edit
            // 
            this.toolStript_edit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStript_edit.Image = global::myContracts.Properties.Resources.EDIT1;
            this.toolStript_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStript_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStript_edit.Name = "toolStript_edit";
            this.toolStript_edit.Size = new System.Drawing.Size(54, 87);
            this.toolStript_edit.Text = "编辑";
            this.toolStript_edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStript_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStript_edit.Click += new System.EventHandler(this.toolStript_edit_Click);
            // 
            // toolStrip_delete
            // 
            this.toolStrip_delete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip_delete.Image = global::myContracts.Properties.Resources.EDIT1;
            this.toolStrip_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStrip_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_delete.Name = "toolStrip_delete";
            this.toolStrip_delete.Size = new System.Drawing.Size(54, 87);
            this.toolStrip_delete.Text = "删除";
            this.toolStrip_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStrip_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_delete.Click += new System.EventHandler(this.toolStrip_delete_Click);
            // 
            // toolStrip_search
            // 
            this.toolStrip_search.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip_search.Image = global::myContracts.Properties.Resources.SEARCH1;
            this.toolStrip_search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStrip_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_search.Name = "toolStrip_search";
            this.toolStrip_search.Size = new System.Drawing.Size(54, 87);
            this.toolStrip_search.Text = "查找";
            this.toolStrip_search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStrip_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_search.Click += new System.EventHandler(this.toolStrip_search_Click);
            // 
            // toolStrip_backup
            // 
            this.toolStrip_backup.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip_backup.Image = global::myContracts.Properties.Resources.BACKUP1;
            this.toolStrip_backup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStrip_backup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_backup.Name = "toolStrip_backup";
            this.toolStrip_backup.Size = new System.Drawing.Size(54, 87);
            this.toolStrip_backup.Text = "备份";
            this.toolStrip_backup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStrip_backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_backup.Click += new System.EventHandler(this.toolStrip_backup_Click);
            // 
            // toolStrip_recover
            // 
            this.toolStrip_recover.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip_recover.Image = global::myContracts.Properties.Resources.RECOVER1;
            this.toolStrip_recover.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStrip_recover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_recover.Name = "toolStrip_recover";
            this.toolStrip_recover.Size = new System.Drawing.Size(54, 87);
            this.toolStrip_recover.Text = "恢复";
            this.toolStrip_recover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStrip_recover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_recover.Click += new System.EventHandler(this.toolStrip_recover_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(154, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 663);
            this.dataGridView1.TabIndex = 1;
            // 
            // professionTreeView
            // 
            this.professionTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.professionTreeView.Location = new System.Drawing.Point(0, 90);
            this.professionTreeView.Name = "professionTreeView";
            this.professionTreeView.Size = new System.Drawing.Size(156, 663);
            this.professionTreeView.TabIndex = 2;
            this.professionTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.professionTreeView_AfterSelect);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1252, 753);
            this.Controls.Add(this.professionTreeView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myContracts";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrip_add;
        private System.Windows.Forms.ToolStripButton toolStript_edit;
        private System.Windows.Forms.ToolStripButton toolStrip_delete;
        private System.Windows.Forms.ToolStripButton toolStrip_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStrip_backup;
        private System.Windows.Forms.ToolStripButton toolStrip_recover;
        private System.Windows.Forms.TreeView professionTreeView;
    }
}

