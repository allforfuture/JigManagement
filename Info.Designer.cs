namespace JigManagement
{
    partial class Info
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJigID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboExist_Update = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboLine_Update = new System.Windows.Forms.ComboBox();
            this.cboDataTypeID_Update = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(20, 263);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(801, 97);
            this.dgvData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jig号:";
            // 
            // txtJigID
            // 
            this.txtJigID.Location = new System.Drawing.Point(85, 17);
            this.txtJigID.Name = "txtJigID";
            this.txtJigID.ReadOnly = true;
            this.txtJigID.Size = new System.Drawing.Size(200, 21);
            this.txtJigID.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboExist_Update);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.cboLine_Update);
            this.groupBox2.Controls.Add(this.cboDataTypeID_Update);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(20, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 76);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改";
            // 
            // cboExist_Update
            // 
            this.cboExist_Update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExist_Update.FormattingEnabled = true;
            this.cboExist_Update.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cboExist_Update.Location = new System.Drawing.Point(357, 17);
            this.cboExist_Update.Name = "cboExist_Update";
            this.cboExist_Update.Size = new System.Drawing.Size(121, 20);
            this.cboExist_Update.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 42;
            this.label3.Text = "Exist：";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(503, 17);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 46);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "修改Jig";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // cboLine_Update
            // 
            this.cboLine_Update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLine_Update.FormattingEnabled = true;
            this.cboLine_Update.Location = new System.Drawing.Point(111, 46);
            this.cboLine_Update.Name = "cboLine_Update";
            this.cboLine_Update.Size = new System.Drawing.Size(121, 20);
            this.cboLine_Update.TabIndex = 41;
            // 
            // cboDataTypeID_Update
            // 
            this.cboDataTypeID_Update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataTypeID_Update.FormattingEnabled = true;
            this.cboDataTypeID_Update.Location = new System.Drawing.Point(111, 17);
            this.cboDataTypeID_Update.Name = "cboDataTypeID_Update";
            this.cboDataTypeID_Update.Size = new System.Drawing.Size(121, 20);
            this.cboDataTypeID_Update.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 39;
            this.label7.Text = "线别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "Data Type ID：";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtJigID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJigID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboExist_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboLine_Update;
        private System.Windows.Forms.ComboBox cboDataTypeID_Update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}