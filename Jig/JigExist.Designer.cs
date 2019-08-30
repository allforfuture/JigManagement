namespace JigManagement.Jig
{
    partial class JigExist
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
            this.txtJigID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNotExist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJigID
            // 
            this.txtJigID.Location = new System.Drawing.Point(123, 45);
            this.txtJigID.Name = "txtJigID";
            this.txtJigID.Size = new System.Drawing.Size(200, 21);
            this.txtJigID.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 42;
            this.label5.Text = "报废Jig号：";
            // 
            // btnNotExist
            // 
            this.btnNotExist.Location = new System.Drawing.Point(123, 90);
            this.btnNotExist.Name = "btnNotExist";
            this.btnNotExist.Size = new System.Drawing.Size(75, 57);
            this.btnNotExist.TabIndex = 44;
            this.btnNotExist.Text = "报废";
            this.btnNotExist.UseVisualStyleBackColor = true;
            this.btnNotExist.Click += new System.EventHandler(this.BtnNotExist_Click);
            // 
            // JigExist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 196);
            this.Controls.Add(this.btnNotExist);
            this.Controls.Add(this.txtJigID);
            this.Controls.Add(this.label5);
            this.Name = "JigExist";
            this.Text = "JigExist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJigID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNotExist;
    }
}