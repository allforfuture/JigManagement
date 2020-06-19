namespace JigManagement
{
    partial class JigManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JigManagement));
            this.切换用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jig添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jig报废ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jig变更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jig维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维修记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJigID = new System.Windows.Forms.TextBox();
            this.chkJigID = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboReason = new System.Windows.Forms.ComboBox();
            this.chkExist = new System.Windows.Forms.CheckBox();
            this.chkLine = new System.Windows.Forms.CheckBox();
            this.chkDataTypeID = new System.Windows.Forms.CheckBox();
            this.cboExist = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.cboDataTypeID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkReason = new System.Windows.Forms.CheckBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 切换用户ToolStripMenuItem
            // 
            this.切换用户ToolStripMenuItem.Name = "切换用户ToolStripMenuItem";
            this.切换用户ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.切换用户ToolStripMenuItem.Text = "切换用户";
            this.切换用户ToolStripMenuItem.Click += new System.EventHandler(this.切换用户ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切换用户ToolStripMenuItem,
            this.jigToolStripMenuItem,
            this.维修记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 25);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jigToolStripMenuItem
            // 
            this.jigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jig添加ToolStripMenuItem,
            this.jig报废ToolStripMenuItem,
            this.jig变更ToolStripMenuItem,
            this.jig维护ToolStripMenuItem});
            this.jigToolStripMenuItem.Name = "jigToolStripMenuItem";
            this.jigToolStripMenuItem.Size = new System.Drawing.Size(36, 21);
            this.jigToolStripMenuItem.Text = "Jig";
            // 
            // jig添加ToolStripMenuItem
            // 
            this.jig添加ToolStripMenuItem.Enabled = false;
            this.jig添加ToolStripMenuItem.Name = "jig添加ToolStripMenuItem";
            this.jig添加ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.jig添加ToolStripMenuItem.Text = "Jig添加";
            this.jig添加ToolStripMenuItem.Click += new System.EventHandler(this.Jig添加ToolStripMenuItem_Click);
            // 
            // jig报废ToolStripMenuItem
            // 
            this.jig报废ToolStripMenuItem.Enabled = false;
            this.jig报废ToolStripMenuItem.Name = "jig报废ToolStripMenuItem";
            this.jig报废ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.jig报废ToolStripMenuItem.Text = "Jig报废";
            this.jig报废ToolStripMenuItem.Click += new System.EventHandler(this.Jig报废ToolStripMenuItem_Click);
            // 
            // jig变更ToolStripMenuItem
            // 
            this.jig变更ToolStripMenuItem.Enabled = false;
            this.jig变更ToolStripMenuItem.Name = "jig变更ToolStripMenuItem";
            this.jig变更ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.jig变更ToolStripMenuItem.Text = "Jig变更";
            this.jig变更ToolStripMenuItem.Click += new System.EventHandler(this.Jig变更ToolStripMenuItem_Click);
            // 
            // jig维护ToolStripMenuItem
            // 
            this.jig维护ToolStripMenuItem.Enabled = false;
            this.jig维护ToolStripMenuItem.Name = "jig维护ToolStripMenuItem";
            this.jig维护ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.jig维护ToolStripMenuItem.Text = "Jig维护";
            this.jig维护ToolStripMenuItem.Click += new System.EventHandler(this.Jig维护ToolStripMenuItem_Click);
            // 
            // 维修记录ToolStripMenuItem
            // 
            this.维修记录ToolStripMenuItem.Name = "维修记录ToolStripMenuItem";
            this.维修记录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.维修记录ToolStripMenuItem.Text = "维修记录";
            this.维修记录ToolStripMenuItem.Click += new System.EventHandler(this.维修记录ToolStripMenuItem_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 158);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(738, 577);
            this.dgvData.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(637, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 41);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "JIG号：";
            // 
            // txtJigID
            // 
            this.txtJigID.Location = new System.Drawing.Point(99, 17);
            this.txtJigID.Name = "txtJigID";
            this.txtJigID.Size = new System.Drawing.Size(200, 21);
            this.txtJigID.TabIndex = 28;
            // 
            // chkJigID
            // 
            this.chkJigID.AutoSize = true;
            this.chkJigID.Location = new System.Drawing.Point(305, 20);
            this.chkJigID.Name = "chkJigID";
            this.chkJigID.Size = new System.Drawing.Size(15, 14);
            this.chkJigID.TabIndex = 29;
            this.chkJigID.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.chkExist);
            this.groupBox2.Controls.Add(this.chkDate);
            this.groupBox2.Controls.Add(this.chkLine);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkDataTypeID);
            this.groupBox2.Controls.Add(this.chkReason);
            this.groupBox2.Controls.Add(this.cboExist);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboReason);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboLine);
            this.groupBox2.Controls.Add(this.cboDataTypeID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtJigID);
            this.groupBox2.Controls.Add(this.chkJigID);
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查找Jig的NG对象";
            // 
            // cboReason
            // 
            this.cboReason.FormattingEnabled = true;
            this.cboReason.Location = new System.Drawing.Point(382, 46);
            this.cboReason.Name = "cboReason";
            this.cboReason.Size = new System.Drawing.Size(150, 20);
            this.cboReason.TabIndex = 49;
            // 
            // chkExist
            // 
            this.chkExist.AutoSize = true;
            this.chkExist.Checked = true;
            this.chkExist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExist.Location = new System.Drawing.Point(509, 20);
            this.chkExist.Name = "chkExist";
            this.chkExist.Size = new System.Drawing.Size(15, 14);
            this.chkExist.TabIndex = 48;
            this.chkExist.UseVisualStyleBackColor = true;
            // 
            // chkLine
            // 
            this.chkLine.AutoSize = true;
            this.chkLine.Location = new System.Drawing.Point(226, 78);
            this.chkLine.Name = "chkLine";
            this.chkLine.Size = new System.Drawing.Size(15, 14);
            this.chkLine.TabIndex = 47;
            this.chkLine.UseVisualStyleBackColor = true;
            // 
            // chkDataTypeID
            // 
            this.chkDataTypeID.AutoSize = true;
            this.chkDataTypeID.Location = new System.Drawing.Point(226, 49);
            this.chkDataTypeID.Name = "chkDataTypeID";
            this.chkDataTypeID.Size = new System.Drawing.Size(15, 14);
            this.chkDataTypeID.TabIndex = 46;
            this.chkDataTypeID.UseVisualStyleBackColor = true;
            // 
            // cboExist
            // 
            this.cboExist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExist.Items.AddRange(new object[] {
            "TRUE",
            "FALSE",
            "NULL"});
            this.cboExist.Location = new System.Drawing.Point(382, 17);
            this.cboExist.Name = "cboExist";
            this.cboExist.Size = new System.Drawing.Size(121, 20);
            this.cboExist.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 44;
            this.label10.Text = "Exist：";
            // 
            // cboLine
            // 
            this.cboLine.FormattingEnabled = true;
            this.cboLine.Location = new System.Drawing.Point(99, 75);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(121, 20);
            this.cboLine.TabIndex = 41;
            // 
            // cboDataTypeID
            // 
            this.cboDataTypeID.FormattingEnabled = true;
            this.cboDataTypeID.Location = new System.Drawing.Point(99, 46);
            this.cboDataTypeID.Name = "cboDataTypeID";
            this.cboDataTypeID.Size = new System.Drawing.Size(121, 20);
            this.cboDataTypeID.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 39;
            this.label8.Text = "线别：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = "Data Type ID：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 49;
            this.label3.Text = "原因：";
            // 
            // chkReason
            // 
            this.chkReason.AutoSize = true;
            this.chkReason.Location = new System.Drawing.Point(538, 49);
            this.chkReason.Name = "chkReason";
            this.chkReason.Size = new System.Drawing.Size(15, 14);
            this.chkReason.TabIndex = 49;
            this.chkReason.UseVisualStyleBackColor = true;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(636, 76);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(15, 14);
            this.chkDate.TabIndex = 49;
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(382, 72);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(121, 21);
            this.dtpStart.TabIndex = 49;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(509, 72);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(121, 21);
            this.dtpEnd.TabIndex = 50;
            // 
            // JigManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 747);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "JigManagement";
            this.Text = "JigManagement";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 切换用户ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJigID;
        private System.Windows.Forms.CheckBox chkJigID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.ComboBox cboDataTypeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboExist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkExist;
        private System.Windows.Forms.CheckBox chkLine;
        private System.Windows.Forms.CheckBox chkDataTypeID;
        private System.Windows.Forms.ToolStripMenuItem jigToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jig维护ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jig添加ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jig报废ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jig变更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维修记录ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkReason;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
    }
}

