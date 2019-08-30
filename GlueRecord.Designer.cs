namespace JigManagement
{
    partial class GlueRecord
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.cboAction = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxCheck = new System.Windows.Forms.GroupBox();
            this.cboCheckLot = new System.Windows.Forms.ComboBox();
            this.cboCheckModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCheckAssy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCheckName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(131, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "确定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(82, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 21);
            this.txtID.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "胶水ID：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLine);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboModel);
            this.groupBox1.Location = new System.Drawing.Point(15, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 85);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "使用地方";
            // 
            // cboLine
            // 
            this.cboLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLine.FormattingEnabled = true;
            this.cboLine.Location = new System.Drawing.Point(70, 55);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(200, 20);
            this.cboLine.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "机种：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "线别：";
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(70, 25);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(200, 20);
            this.cboModel.TabIndex = 16;
            this.cboModel.SelectedIndexChanged += new System.EventHandler(this.CboModel_SelectedIndexChanged);
            // 
            // cboAction
            // 
            this.cboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAction.FormattingEnabled = true;
            this.cboAction.Location = new System.Drawing.Point(82, 49);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(200, 20);
            this.cboAction.TabIndex = 18;
            this.cboAction.SelectedIndexChanged += new System.EventHandler(this.CboAction_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "操作：";
            // 
            // gbxCheck
            // 
            this.gbxCheck.Controls.Add(this.cboCheckLot);
            this.gbxCheck.Controls.Add(this.cboCheckModel);
            this.gbxCheck.Controls.Add(this.label1);
            this.gbxCheck.Controls.Add(this.cboCheckAssy);
            this.gbxCheck.Controls.Add(this.label6);
            this.gbxCheck.Controls.Add(this.groupBox1);
            this.gbxCheck.Controls.Add(this.cboCheckName);
            this.gbxCheck.Controls.Add(this.label7);
            this.gbxCheck.Controls.Add(this.label8);
            this.gbxCheck.Enabled = false;
            this.gbxCheck.Location = new System.Drawing.Point(23, 81);
            this.gbxCheck.Name = "gbxCheck";
            this.gbxCheck.Size = new System.Drawing.Size(318, 293);
            this.gbxCheck.TabIndex = 32;
            this.gbxCheck.TabStop = false;
            this.gbxCheck.Text = "验证";
            // 
            // cboCheckLot
            // 
            this.cboCheckLot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCheckLot.FormattingEnabled = true;
            this.cboCheckLot.Location = new System.Drawing.Point(108, 148);
            this.cboCheckLot.Name = "cboCheckLot";
            this.cboCheckLot.Size = new System.Drawing.Size(200, 20);
            this.cboCheckLot.TabIndex = 30;
            // 
            // cboCheckModel
            // 
            this.cboCheckModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCheckModel.FormattingEnabled = true;
            this.cboCheckModel.Location = new System.Drawing.Point(108, 25);
            this.cboCheckModel.Name = "cboCheckModel";
            this.cboCheckModel.Size = new System.Drawing.Size(200, 20);
            this.cboCheckModel.TabIndex = 27;
            this.cboCheckModel.SelectedIndexChanged += new System.EventHandler(this.CboCheckModel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "机种：";
            // 
            // cboCheckAssy
            // 
            this.cboCheckAssy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCheckAssy.FormattingEnabled = true;
            this.cboCheckAssy.Location = new System.Drawing.Point(108, 66);
            this.cboCheckAssy.Name = "cboCheckAssy";
            this.cboCheckAssy.Size = new System.Drawing.Size(200, 20);
            this.cboCheckAssy.TabIndex = 28;
            this.cboCheckAssy.SelectedIndexChanged += new System.EventHandler(this.CboCheckAssy_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "组别：";
            // 
            // cboCheckName
            // 
            this.cboCheckName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCheckName.FormattingEnabled = true;
            this.cboCheckName.Location = new System.Drawing.Point(108, 107);
            this.cboCheckName.Name = "cboCheckName";
            this.cboCheckName.Size = new System.Drawing.Size(200, 20);
            this.cboCheckName.TabIndex = 29;
            this.cboCheckName.SelectedIndexChanged += new System.EventHandler(this.CboCheckName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "工位名称：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "胶水型号：";
            // 
            // GlueRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 436);
            this.Controls.Add(this.cboAction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbxCheck);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Name = "GlueRecord";
            this.Text = "GlueRecord";
            this.Load += new System.EventHandler(this.BigGlueReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxCheck.ResumeLayout(false);
            this.gbxCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAction;
        private System.Windows.Forms.GroupBox gbxCheck;
        private System.Windows.Forms.ComboBox cboCheckLot;
        private System.Windows.Forms.ComboBox cboCheckModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCheckAssy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCheckName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}