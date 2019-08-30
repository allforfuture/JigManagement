namespace JigManagement
{
    partial class Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.txtID2 = new System.Windows.Forms.TextBox();
            this.txtLot2 = new System.Windows.Forms.TextBox();
            this.txtID1 = new System.Windows.Forms.TextBox();
            this.txtLot1 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picQRcode2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picQRcode1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID0 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(230, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "打印标签";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.Color.White;
            this.pnlPrint.Controls.Add(this.txtID2);
            this.pnlPrint.Controls.Add(this.txtLot2);
            this.pnlPrint.Controls.Add(this.txtID1);
            this.pnlPrint.Controls.Add(this.txtLot1);
            this.pnlPrint.Controls.Add(this.txt6);
            this.pnlPrint.Controls.Add(this.txt5);
            this.pnlPrint.Controls.Add(this.txt4);
            this.pnlPrint.Controls.Add(this.txt3);
            this.pnlPrint.Controls.Add(this.txt2);
            this.pnlPrint.Controls.Add(this.txt1);
            this.pnlPrint.Controls.Add(this.label10);
            this.pnlPrint.Controls.Add(this.label11);
            this.pnlPrint.Controls.Add(this.picQRcode2);
            this.pnlPrint.Controls.Add(this.label4);
            this.pnlPrint.Controls.Add(this.label3);
            this.pnlPrint.Controls.Add(this.label2);
            this.pnlPrint.Controls.Add(this.label1);
            this.pnlPrint.Controls.Add(this.picQRcode1);
            this.pnlPrint.Controls.Add(this.label5);
            this.pnlPrint.Controls.Add(this.label6);
            this.pnlPrint.Controls.Add(this.label7);
            this.pnlPrint.Controls.Add(this.label8);
            this.pnlPrint.Controls.Add(this.label9);
            this.pnlPrint.Enabled = false;
            this.pnlPrint.Location = new System.Drawing.Point(18, 42);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(288, 321);
            this.pnlPrint.TabIndex = 16;
            // 
            // txtID2
            // 
            this.txtID2.Location = new System.Drawing.Point(71, 255);
            this.txtID2.Name = "txtID2";
            this.txtID2.Size = new System.Drawing.Size(100, 21);
            this.txtID2.TabIndex = 32;
            // 
            // txtLot2
            // 
            this.txtLot2.Location = new System.Drawing.Point(71, 228);
            this.txtLot2.Name = "txtLot2";
            this.txtLot2.Size = new System.Drawing.Size(100, 21);
            this.txtLot2.TabIndex = 31;
            // 
            // txtID1
            // 
            this.txtID1.Location = new System.Drawing.Point(71, 163);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(100, 21);
            this.txtID1.TabIndex = 30;
            // 
            // txtLot1
            // 
            this.txtLot1.Location = new System.Drawing.Point(71, 132);
            this.txtLot1.Name = "txtLot1";
            this.txtLot1.Size = new System.Drawing.Size(209, 21);
            this.txtLot1.TabIndex = 29;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(165, 101);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(115, 21);
            this.txt6.TabIndex = 28;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(71, 101);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(25, 21);
            this.txt5.TabIndex = 27;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(71, 70);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(209, 21);
            this.txt4.TabIndex = 26;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(71, 39);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(209, 21);
            this.txt3.TabIndex = 25;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(142, 8);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(138, 21);
            this.txt2.TabIndex = 24;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(71, 8);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(30, 21);
            this.txt1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "胶水批号:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "胶水ID:";
            // 
            // picQRcode2
            // 
            this.picQRcode2.BackColor = System.Drawing.Color.Transparent;
            this.picQRcode2.Location = new System.Drawing.Point(175, 231);
            this.picQRcode2.Name = "picQRcode2";
            this.picQRcode2.Size = new System.Drawing.Size(70, 70);
            this.picQRcode2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picQRcode2.TabIndex = 20;
            this.picQRcode2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "胶水批号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "胶水ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "有效日期:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "机种:";
            // 
            // picQRcode1
            // 
            this.picQRcode1.BackColor = System.Drawing.Color.Transparent;
            this.picQRcode1.Location = new System.Drawing.Point(175, 157);
            this.picQRcode1.Name = "picQRcode1";
            this.picQRcode1.Size = new System.Drawing.Size(70, 70);
            this.picQRcode1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picQRcode1.TabIndex = 15;
            this.picQRcode1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "组别:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "工位名称:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "有效期:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "胶水型号:";
            // 
            // txtID0
            // 
            this.txtID0.Location = new System.Drawing.Point(122, 12);
            this.txtID0.Name = "txtID0";
            this.txtID0.Size = new System.Drawing.Size(100, 21);
            this.txtID0.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 32;
            this.label12.Text = "输入打印的ID号:";
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 380);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtID0);
            this.Controls.Add(this.pnlPrint);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;            
            this.MaximizeBox = false;
            this.Name = "Print";
            this.Text = "Print";
            this.pnlPrint.ResumeLayout(false);
            this.pnlPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.PictureBox picQRcode1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picQRcode2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID2;
        private System.Windows.Forms.TextBox txtLot2;
        private System.Windows.Forms.TextBox txtID1;
        private System.Windows.Forms.TextBox txtLot1;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txtID0;
        private System.Windows.Forms.Label label12;
    }
}

