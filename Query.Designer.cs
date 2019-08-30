namespace JigManagement
{
    partial class Query
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.chkID1 = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkGroup2 = new System.Windows.Forms.CheckBox();
            this.chkWorkLocation3 = new System.Windows.Forms.CheckBox();
            this.chkModel4 = new System.Windows.Forms.CheckBox();
            this.chkLot5 = new System.Windows.Forms.CheckBox();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtWorkLocation = new System.Windows.Forms.TextBox();
            this.chkUserID6 = new System.Windows.Forms.CheckBox();
            this.chkAction7 = new System.Windows.Forms.CheckBox();
            this.chkTime9 = new System.Windows.Forms.CheckBox();
            this.chkLine8 = new System.Windows.Forms.CheckBox();
            this.gbxQuery = new System.Windows.Forms.GroupBox();
            this.cboAction = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbxQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 166);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(988, 384);
            this.dgv.TabIndex = 0;
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Dgv_DataBindingComplete);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(718, 20);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(52, 123);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // chkID1
            // 
            this.chkID1.AutoSize = true;
            this.chkID1.Location = new System.Drawing.Point(18, 20);
            this.chkID1.Name = "chkID1";
            this.chkID1.Size = new System.Drawing.Size(72, 16);
            this.chkID1.TabIndex = 2;
            this.chkID1.Text = "胶水ID：";
            this.chkID1.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(109, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 3;
            // 
            // chkGroup2
            // 
            this.chkGroup2.AutoSize = true;
            this.chkGroup2.Location = new System.Drawing.Point(18, 55);
            this.chkGroup2.Name = "chkGroup2";
            this.chkGroup2.Size = new System.Drawing.Size(60, 16);
            this.chkGroup2.TabIndex = 4;
            this.chkGroup2.Text = "组别：";
            this.chkGroup2.UseVisualStyleBackColor = true;
            // 
            // chkWorkLocation3
            // 
            this.chkWorkLocation3.AutoSize = true;
            this.chkWorkLocation3.Location = new System.Drawing.Point(18, 90);
            this.chkWorkLocation3.Name = "chkWorkLocation3";
            this.chkWorkLocation3.Size = new System.Drawing.Size(60, 16);
            this.chkWorkLocation3.TabIndex = 6;
            this.chkWorkLocation3.Text = "工位：";
            this.chkWorkLocation3.UseVisualStyleBackColor = true;
            // 
            // chkModel4
            // 
            this.chkModel4.AutoSize = true;
            this.chkModel4.Location = new System.Drawing.Point(18, 125);
            this.chkModel4.Name = "chkModel4";
            this.chkModel4.Size = new System.Drawing.Size(60, 16);
            this.chkModel4.TabIndex = 5;
            this.chkModel4.Text = "型号：";
            this.chkModel4.UseVisualStyleBackColor = true;
            // 
            // chkLot5
            // 
            this.chkLot5.AutoSize = true;
            this.chkLot5.Location = new System.Drawing.Point(302, 20);
            this.chkLot5.Name = "chkLot5";
            this.chkLot5.Size = new System.Drawing.Size(60, 16);
            this.chkLot5.TabIndex = 7;
            this.chkLot5.Text = "批号：";
            this.chkLot5.UseVisualStyleBackColor = true;
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(379, 20);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(100, 21);
            this.txtLot.TabIndex = 13;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(109, 54);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(100, 21);
            this.txtGroup.TabIndex = 10;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(109, 122);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 21);
            this.txtModel.TabIndex = 12;
            // 
            // txtWorkLocation
            // 
            this.txtWorkLocation.Location = new System.Drawing.Point(109, 88);
            this.txtWorkLocation.Name = "txtWorkLocation";
            this.txtWorkLocation.Size = new System.Drawing.Size(100, 21);
            this.txtWorkLocation.TabIndex = 11;
            // 
            // chkUserID6
            // 
            this.chkUserID6.AutoSize = true;
            this.chkUserID6.Location = new System.Drawing.Point(302, 55);
            this.chkUserID6.Name = "chkUserID6";
            this.chkUserID6.Size = new System.Drawing.Size(60, 16);
            this.chkUserID6.TabIndex = 14;
            this.chkUserID6.Text = "工号：";
            this.chkUserID6.UseVisualStyleBackColor = true;
            // 
            // chkAction7
            // 
            this.chkAction7.AutoSize = true;
            this.chkAction7.Location = new System.Drawing.Point(302, 90);
            this.chkAction7.Name = "chkAction7";
            this.chkAction7.Size = new System.Drawing.Size(60, 16);
            this.chkAction7.TabIndex = 15;
            this.chkAction7.Text = "操作：";
            this.chkAction7.UseVisualStyleBackColor = true;
            // 
            // chkTime9
            // 
            this.chkTime9.AutoSize = true;
            this.chkTime9.Checked = true;
            this.chkTime9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTime9.Location = new System.Drawing.Point(567, 20);
            this.chkTime9.Name = "chkTime9";
            this.chkTime9.Size = new System.Drawing.Size(84, 16);
            this.chkTime9.TabIndex = 17;
            this.chkTime9.Text = "时间范围：";
            this.chkTime9.UseVisualStyleBackColor = true;
            // 
            // chkLine8
            // 
            this.chkLine8.AutoSize = true;
            this.chkLine8.Location = new System.Drawing.Point(302, 125);
            this.chkLine8.Name = "chkLine8";
            this.chkLine8.Size = new System.Drawing.Size(60, 16);
            this.chkLine8.TabIndex = 16;
            this.chkLine8.Text = "线别：";
            this.chkLine8.UseVisualStyleBackColor = true;
            // 
            // gbxQuery
            // 
            this.gbxQuery.Controls.Add(this.cboAction);
            this.gbxQuery.Controls.Add(this.dtpEnd);
            this.gbxQuery.Controls.Add(this.label1);
            this.gbxQuery.Controls.Add(this.dtpStart);
            this.gbxQuery.Controls.Add(this.txtLine);
            this.gbxQuery.Controls.Add(this.btnQuery);
            this.gbxQuery.Controls.Add(this.txtUserID);
            this.gbxQuery.Controls.Add(this.chkID1);
            this.gbxQuery.Controls.Add(this.chkTime9);
            this.gbxQuery.Controls.Add(this.chkGroup2);
            this.gbxQuery.Controls.Add(this.chkLine8);
            this.gbxQuery.Controls.Add(this.chkWorkLocation3);
            this.gbxQuery.Controls.Add(this.chkAction7);
            this.gbxQuery.Controls.Add(this.chkModel4);
            this.gbxQuery.Controls.Add(this.chkUserID6);
            this.gbxQuery.Controls.Add(this.chkLot5);
            this.gbxQuery.Controls.Add(this.txtLot);
            this.gbxQuery.Controls.Add(this.txtID);
            this.gbxQuery.Controls.Add(this.txtGroup);
            this.gbxQuery.Controls.Add(this.txtWorkLocation);
            this.gbxQuery.Controls.Add(this.txtModel);
            this.gbxQuery.Location = new System.Drawing.Point(12, 7);
            this.gbxQuery.Name = "gbxQuery";
            this.gbxQuery.Size = new System.Drawing.Size(776, 153);
            this.gbxQuery.TabIndex = 18;
            this.gbxQuery.TabStop = false;
            this.gbxQuery.Text = "查询";
            // 
            // cboAction
            // 
            this.cboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAction.FormattingEnabled = true;
            this.cboAction.Items.AddRange(new object[] {
            "deliver",
            "return"});
            this.cboAction.Location = new System.Drawing.Point(379, 88);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(100, 20);
            this.cboAction.TabIndex = 24;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(567, 85);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(127, 21);
            this.dtpEnd.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "to";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(567, 42);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(127, 21);
            this.dtpStart.TabIndex = 21;
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(379, 121);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(100, 21);
            this.txtLine.TabIndex = 20;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(379, 54);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 21);
            this.txtUserID.TabIndex = 18;
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 562);
            this.Controls.Add(this.gbxQuery);
            this.Controls.Add(this.dgv);
            this.Name = "Query";
            this.Text = "Query";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbxQuery.ResumeLayout(false);
            this.gbxQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.CheckBox chkID1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkGroup2;
        private System.Windows.Forms.CheckBox chkWorkLocation3;
        private System.Windows.Forms.CheckBox chkModel4;
        private System.Windows.Forms.CheckBox chkLot5;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtWorkLocation;
        private System.Windows.Forms.CheckBox chkUserID6;
        private System.Windows.Forms.CheckBox chkAction7;
        private System.Windows.Forms.CheckBox chkTime9;
        private System.Windows.Forms.CheckBox chkLine8;
        private System.Windows.Forms.GroupBox gbxQuery;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cboAction;
    }
}