namespace QLVT.Reports
{
    partial class rpFmHoatDongNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mANVLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.rBtnDH = new System.Windows.Forms.RadioButton();
            this.rBtnPN = new System.Windows.Forms.RadioButton();
            this.rBtnPX = new System.Windows.Forms.RadioButton();
            this.qLVT_DATHANGDataSet1 = new QLVT.QLVT_DATHANGDataSet1();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT.QLVT_DATHANGDataSet1TableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(mANVLabel);
            this.panel1.Controls.Add(this.cmbMaNV);
            this.panel1.Controls.Add(this.rBtnPX);
            this.panel1.Controls.Add(this.rBtnPN);
            this.panel1.Controls.Add(this.rBtnDH);
            this.panel1.Controls.Add(this.txtHoTen);
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
            this.btnExit.Location = new System.Drawing.Point(671, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 51);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(166, 388);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(171, 51);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDenNgay.Location = new System.Drawing.Point(608, 220);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(234, 25);
            this.txtDenNgay.TabIndex = 7;
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTuNgay.Location = new System.Drawing.Point(242, 220);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(234, 25);
            this.txtTuNgay.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(608, 154);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(234, 25);
            this.txtHoTen.TabIndex = 12;
            // 
            // rBtnDH
            // 
            this.rBtnDH.AutoSize = true;
            this.rBtnDH.Location = new System.Drawing.Point(242, 316);
            this.rBtnDH.Name = "rBtnDH";
            this.rBtnDH.Size = new System.Drawing.Size(80, 21);
            this.rBtnDH.TabIndex = 13;
            this.rBtnDH.TabStop = true;
            this.rBtnDH.Text = "Đặt hàng";
            this.rBtnDH.UseVisualStyleBackColor = true;
            // 
            // rBtnPN
            // 
            this.rBtnPN.AutoSize = true;
            this.rBtnPN.Location = new System.Drawing.Point(493, 316);
            this.rBtnPN.Name = "rBtnPN";
            this.rBtnPN.Size = new System.Drawing.Size(91, 21);
            this.rBtnPN.TabIndex = 14;
            this.rBtnPN.TabStop = true;
            this.rBtnPN.Text = "Phiếu nhập";
            this.rBtnPN.UseVisualStyleBackColor = true;
            // 
            // rBtnPX
            // 
            this.rBtnPX.AutoSize = true;
            this.rBtnPX.Location = new System.Drawing.Point(754, 316);
            this.rBtnPX.Name = "rBtnPX";
            this.rBtnPX.Size = new System.Drawing.Size(88, 21);
            this.rBtnPX.TabIndex = 15;
            this.rBtnPX.TabStop = true;
            this.rBtnPX.Text = "Phiếu xuất";
            this.rBtnPX.UseVisualStyleBackColor = true;
            // 
            // qLVT_DATHANGDataSet1
            // 
            this.qLVT_DATHANGDataSet1.DataSetName = "QLVT_DATHANGDataSet1";
            this.qLVT_DATHANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.qLVT_DATHANGDataSet1;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(163, 157);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(56, 17);
            mANVLabel.TabIndex = 15;
            mANVLabel.Text = "Mã NV:";
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.DataSource = this.bdsNV;
            this.cmbMaNV.DisplayMember = "MANV";
            this.cmbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(242, 154);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(121, 25);
            this.cmbMaNV.TabIndex = 16;
            this.cmbMaNV.ValueMember = "MANV";
            this.cmbMaNV.SelectedIndexChanged += new System.EventHandler(this.cmbMaNV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Đến ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Họ tên NV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(341, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "HOẠT ĐỘNG NHÂN VIÊN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Loại phiếu:";
            // 
            // rpFmHoatDongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rpFmHoatDongNhanVien";
            this.Text = "rpFmHoatDongNhanVien";
            this.Load += new System.EventHandler(this.rpFmHoatDongNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
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
        private System.Windows.Forms.RadioButton rBtnDH;
        private System.Windows.Forms.TextBox txtHoTen;
        private QLVT_DATHANGDataSet1 qLVT_DATHANGDataSet1;
        private System.Windows.Forms.BindingSource bdsNV;
        private QLVT_DATHANGDataSet1TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}