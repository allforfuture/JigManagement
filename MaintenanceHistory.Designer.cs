namespace JigManagement
{
    partial class MaintenanceHistory
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkWorkType = new System.Windows.Forms.CheckBox();
            this.cboWorkType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtJigID = new System.Windows.Forms.TextBox();
            this.chkJigID = new System.Windows.Forms.CheckBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.chkUser = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.chkComments = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtComments);
            this.groupBox2.Controls.Add(this.chkComments);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.chkUser);
            this.groupBox2.Controls.Add(this.chkWorkType);
            this.groupBox2.Controls.Add(this.cboWorkType);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.chkTime);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtJigID);
            this.groupBox2.Controls.Add(this.chkJigID);
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 137);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查找维修记录";
            // 
            // chkWorkType
            // 
            this.chkWorkType.AutoSize = true;
            this.chkWorkType.Location = new System.Drawing.Point(659, 26);
            this.chkWorkType.Name = "chkWorkType";
            this.chkWorkType.Size = new System.Drawing.Size(15, 14);
            this.chkWorkType.TabIndex = 46;
            this.chkWorkType.UseVisualStyleBackColor = true;
            // 
            // cboWorkType
            // 
            this.cboWorkType.FormattingEnabled = true;
            this.cboWorkType.Items.AddRange(new object[] {
            "MAINTENANCE"});
            this.cboWorkType.Location = new System.Drawing.Point(436, 23);
            this.cboWorkType.Name = "cboWorkType";
            this.cboWorkType.Size = new System.Drawing.Size(200, 20);
            this.cboWorkType.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = "Work Type：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "JIG号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "日期：";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(71, 55);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(121, 21);
            this.dtpStart.TabIndex = 23;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(71, 92);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(121, 21);
            this.dtpEnd.TabIndex = 23;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Checked = true;
            this.chkTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTime.Location = new System.Drawing.Point(277, 62);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(15, 14);
            this.chkTime.TabIndex = 24;
            this.chkTime.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(742, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 41);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtJigID
            // 
            this.txtJigID.Location = new System.Drawing.Point(71, 23);
            this.txtJigID.Name = "txtJigID";
            this.txtJigID.Size = new System.Drawing.Size(200, 21);
            this.txtJigID.TabIndex = 28;
            // 
            // chkJigID
            // 
            this.chkJigID.AutoSize = true;
            this.chkJigID.Location = new System.Drawing.Point(277, 26);
            this.chkJigID.Name = "chkJigID";
            this.chkJigID.Size = new System.Drawing.Size(15, 14);
            this.chkJigID.TabIndex = 29;
            this.chkJigID.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 162);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(888, 340);
            this.dgvData.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "User：";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(436, 58);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 21);
            this.txtUser.TabIndex = 48;
            // 
            // chkUser
            // 
            this.chkUser.AutoSize = true;
            this.chkUser.Location = new System.Drawing.Point(659, 62);
            this.chkUser.Name = "chkUser";
            this.chkUser.Size = new System.Drawing.Size(15, 14);
            this.chkUser.TabIndex = 49;
            this.chkUser.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 50;
            this.label4.Text = "Comments：";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(436, 85);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(200, 42);
            this.txtComments.TabIndex = 51;
            // 
            // chkComments
            // 
            this.chkComments.AutoSize = true;
            this.chkComments.Location = new System.Drawing.Point(659, 92);
            this.chkComments.Name = "chkComments";
            this.chkComments.Size = new System.Drawing.Size(15, 14);
            this.chkComments.TabIndex = 52;
            this.chkComments.UseVisualStyleBackColor = true;
            // 
            // MaintenanceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvData);
            this.Name = "MaintenanceHistory";
            this.Text = "MaintenanceHistory";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkWorkType;
        private System.Windows.Forms.ComboBox cboWorkType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.CheckBox chkTime;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtJigID;
        private System.Windows.Forms.CheckBox chkJigID;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.CheckBox chkComments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.CheckBox chkUser;
    }
}