namespace Calculator
{
    partial class Form1
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label lbTinhToan;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.btCong = new System.Windows.Forms.Button();
            this.txtSoThu1 = new System.Windows.Forms.TextBox();
            this.txtSoThu2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            lbTinhToan = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(119, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 24);
            label1.TabIndex = 3;
            label1.Text = "Tính Toán";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTinhToan
            // 
            lbTinhToan.AutoSize = true;
            lbTinhToan.ForeColor = System.Drawing.Color.Navy;
            lbTinhToan.Location = new System.Drawing.Point(29, 60);
            lbTinhToan.Name = "lbTinhToan";
            lbTinhToan.Size = new System.Drawing.Size(47, 13);
            lbTinhToan.TabIndex = 4;
            lbTinhToan.Text = "Số thứ 1";
            lbTinhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Navy;
            label2.Location = new System.Drawing.Point(29, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 13);
            label2.TabIndex = 5;
            label2.Text = "Số thứ 2";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Navy;
            label3.Location = new System.Drawing.Point(29, 155);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 13);
            label3.TabIndex = 7;
            label3.Text = "Kết quả";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCong
            // 
            this.btCong.BackColor = System.Drawing.Color.Green;
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btCong.ForeColor = System.Drawing.SystemColors.Window;
            this.btCong.Location = new System.Drawing.Point(109, 189);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(39, 39);
            this.btCong.TabIndex = 0;
            this.btCong.Text = "+";
            this.btCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCong.UseVisualStyleBackColor = false;
            // 
            // txtSoThu1
            // 
            this.txtSoThu1.Location = new System.Drawing.Point(96, 57);
            this.txtSoThu1.Name = "txtSoThu1";
            this.txtSoThu1.Size = new System.Drawing.Size(187, 20);
            this.txtSoThu1.TabIndex = 2;
            // 
            // txtSoThu2
            // 
            this.txtSoThu2.Location = new System.Drawing.Point(96, 103);
            this.txtSoThu2.Name = "txtSoThu2";
            this.txtSoThu2.Size = new System.Drawing.Size(187, 20);
            this.txtSoThu2.TabIndex = 6;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(96, 152);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(187, 20);
            this.txtKQ.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(325, 260);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtSoThu2);
            this.Controls.Add(label2);
            this.Controls.Add(lbTinhToan);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtSoThu1);
            this.Controls.Add(this.btCong);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.TextBox txtSoThu1;
        private System.Windows.Forms.TextBox txtSoThu2;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

