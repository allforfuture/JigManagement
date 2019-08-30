namespace JigManagement
{
    partial class BigGlueItem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.txtGlueID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLot = new System.Windows.Forms.ComboBox();
            this.btnSave_Big = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboExp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAssy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtLot);
            this.groupBox1.Controls.Add(this.txtGlueID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboLot);
            this.groupBox1.Controls.Add(this.btnSave_Big);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboExp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboAssy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 358);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "装大胶水";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "分配大胶水ID：";
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(121, 256);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(200, 21);
            this.txtLot.TabIndex = 35;
            // 
            // txtGlueID
            // 
            this.txtGlueID.Location = new System.Drawing.Point(118, 291);
            this.txtGlueID.Name = "txtGlueID";
            this.txtGlueID.ReadOnly = true;
            this.txtGlueID.Size = new System.Drawing.Size(203, 21);
            this.txtGlueID.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 34;
            this.label7.Text = "批号：";
            // 
            // cboLot
            // 
            this.cboLot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLot.FormattingEnabled = true;
            this.cboLot.Location = new System.Drawing.Point(121, 139);
            this.cboLot.Name = "cboLot";
            this.cboLot.Size = new System.Drawing.Size(200, 20);
            this.cboLot.TabIndex = 15;
            this.cboLot.SelectedIndexChanged += new System.EventHandler(this.CboLot_SelectedIndexChanged);
            // 
            // btnSave_Big
            // 
            this.btnSave_Big.Location = new System.Drawing.Point(130, 318);
            this.btnSave_Big.Name = "btnSave_Big";
            this.btnSave_Big.Size = new System.Drawing.Size(75, 23);
            this.btnSave_Big.TabIndex = 16;
            this.btnSave_Big.Text = "装大胶水";
            this.btnSave_Big.UseVisualStyleBackColor = true;
            this.btnSave_Big.Click += new System.EventHandler(this.BtnSave_Big_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "机种：";
            // 
            // cboColor
            // 
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(121, 217);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(200, 20);
            this.cboColor.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "组别：";
            // 
            // cboExp
            // 
            this.cboExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExp.FormattingEnabled = true;
            this.cboExp.Location = new System.Drawing.Point(121, 178);
            this.cboExp.Name = "cboExp";
            this.cboExp.Size = new System.Drawing.Size(200, 20);
            this.cboExp.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "工位名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "胶水型号：";
            // 
            // cboName
            // 
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(121, 100);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(200, 20);
            this.cboName.TabIndex = 14;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.CboName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "有效期(小时)：";
            // 
            // cboAssy
            // 
            this.cboAssy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssy.FormattingEnabled = true;
            this.cboAssy.Location = new System.Drawing.Point(121, 61);
            this.cboAssy.Name = "cboAssy";
            this.cboAssy.Size = new System.Drawing.Size(200, 20);
            this.cboAssy.TabIndex = 13;
            this.cboAssy.SelectedIndexChanged += new System.EventHandler(this.CboAssy_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "颜色：";
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(121, 22);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(200, 20);
            this.cboModel.TabIndex = 12;
            this.cboModel.SelectedIndexChanged += new System.EventHandler(this.CboModel_SelectedIndexChanged);
            // 
            // BigGlueItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 374);
            this.Controls.Add(this.groupBox1);
            this.Name = "BigGlueItem";
            this.Text = "BigGlueItem";
            this.Load += new System.EventHandler(this.BigGlueIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.ComboBox cboAssy;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.ComboBox cboLot;
        private System.Windows.Forms.ComboBox cboExp;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Button btnSave_Big;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGlueID;
    }
}