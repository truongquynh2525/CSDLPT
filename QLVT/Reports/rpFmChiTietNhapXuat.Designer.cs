namespace QLVT.Reports
{
    partial class rpFmChiTietNhapXuat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rBtnPN = new System.Windows.Forms.RadioButton();
            this.rBtnPX = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtnPX);
            this.panel1.Controls.Add(this.rBtnPN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.txtDenNgay);
            this.panel1.Controls.Add(this.txtTuNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 588);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(684, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(340, 340);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(167, 41);
            this.btnXem.TabIndex = 10;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDenNgay.Location = new System.Drawing.Point(667, 167);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(200, 25);
            this.txtDenNgay.TabIndex = 9;
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTuNgay.Location = new System.Drawing.Point(340, 169);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(200, 25);
            this.txtTuNgay.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(340, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "CHI TIẾT HOẠT ĐỘNG NHẬP XUẤT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Từ ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đến ngày:";
            // 
            // rBtnPN
            // 
            this.rBtnPN.AutoSize = true;
            this.rBtnPN.Location = new System.Drawing.Point(340, 251);
            this.rBtnPN.Name = "rBtnPN";
            this.rBtnPN.Size = new System.Drawing.Size(91, 21);
            this.rBtnPN.TabIndex = 18;
            this.rBtnPN.TabStop = true;
            this.rBtnPN.Text = "Phiếu nhập";
            this.rBtnPN.UseVisualStyleBackColor = true;
            // 
            // rBtnPX
            // 
            this.rBtnPX.AutoSize = true;
            this.rBtnPX.Location = new System.Drawing.Point(667, 253);
            this.rBtnPX.Name = "rBtnPX";
            this.rBtnPX.Size = new System.Drawing.Size(88, 21);
            this.rBtnPX.TabIndex = 20;
            this.rBtnPX.TabStop = true;
            this.rBtnPX.Text = "Phiếu xuất";
            this.rBtnPX.UseVisualStyleBackColor = true;
            // 
            // rpFmChiTietNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rpFmChiTietNhapXuat";
            this.Text = "rpFmChiTietNhapXuat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker txtDenNgay;
        private System.Windows.Forms.DateTimePicker txtTuNgay;
        private System.Windows.Forms.RadioButton rBtnPX;
        private System.Windows.Forms.RadioButton rBtnPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}