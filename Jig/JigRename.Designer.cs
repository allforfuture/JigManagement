namespace JigManagement.Jig
{
    partial class JigRename
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
            this.btnRename = new System.Windows.Forms.Button();
            this.txtJigID_old = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJigID_new = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(126, 123);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 57);
            this.btnRename.TabIndex = 47;
            this.btnRename.Text = "变更";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // txtJigID_old
            // 
            this.txtJigID_old.Location = new System.Drawing.Point(151, 35);
            this.txtJigID_old.Name = "txtJigID_old";
            this.txtJigID_old.Size = new System.Drawing.Size(200, 21);
            this.txtJigID_old.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 45;
            this.label5.Text = "旧Jig号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "新Jig号：";
            // 
            // txtJigID_new
            // 
            this.txtJigID_new.Location = new System.Drawing.Point(151, 80);
            this.txtJigID_new.Name = "txtJigID_new";
            this.txtJigID_new.Size = new System.Drawing.Size(200, 21);
            this.txtJigID_new.TabIndex = 46;
            // 
            // JigRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 198);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.txtJigID_new);
            this.Controls.Add(this.txtJigID_old);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "JigRename";
            this.Text = "JigRename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox txtJigID_old;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJigID_new;
    }
}