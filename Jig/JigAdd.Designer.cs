namespace JigManagement.Jig
{
    partial class JigAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboLine_Add = new System.Windows.Forms.ComboBox();
            this.cboDataTypeID_Add = new System.Windows.Forms.ComboBox();
            this.txtJigID_Add = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 57);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cboLine_Add
            // 
            this.cboLine_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLine_Add.FormattingEnabled = true;
            this.cboLine_Add.Location = new System.Drawing.Point(145, 115);
            this.cboLine_Add.Name = "cboLine_Add";
            this.cboLine_Add.Size = new System.Drawing.Size(121, 20);
            this.cboLine_Add.TabIndex = 44;
            // 
            // cboDataTypeID_Add
            // 
            this.cboDataTypeID_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataTypeID_Add.FormattingEnabled = true;
            this.cboDataTypeID_Add.Location = new System.Drawing.Point(145, 73);
            this.cboDataTypeID_Add.Name = "cboDataTypeID_Add";
            this.cboDataTypeID_Add.Size = new System.Drawing.Size(121, 20);
            this.cboDataTypeID_Add.TabIndex = 43;
            // 
            // txtJigID_Add
            // 
            this.txtJigID_Add.Location = new System.Drawing.Point(102, 31);
            this.txtJigID_Add.Name = "txtJigID_Add";
            this.txtJigID_Add.Size = new System.Drawing.Size(200, 21);
            this.txtJigID_Add.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "线别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "Data Type ID：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "Jig号：";
            // 
            // JigAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 258);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboLine_Add);
            this.Controls.Add(this.cboDataTypeID_Add);
            this.Controls.Add(this.txtJigID_Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "JigAdd";
            this.Text = "JigAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboLine_Add;
        private System.Windows.Forms.ComboBox cboDataTypeID_Add;
        private System.Windows.Forms.TextBox txtJigID_Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}