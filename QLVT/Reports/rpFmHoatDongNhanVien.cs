using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Reports
{
    public partial class rpFmHoatDongNhanVien : Form
    {
        private int maNV;
        private String diaChi;
        private DateTime ngaySinh;
        private float Luong;
        public rpFmHoatDongNhanVien()
        {
            InitializeComponent();
        }

        public void timTenNV()
        {
            string strLenh = "EXEC SP_TIMTHONGTIN_NV " + this.maNV;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if(Program.myReader == null )
            {
                return;
            }
            if (Program.myReader.Read())
            {
                this.txtHoTen.Text = Program.myReader.GetString(0);
                this.diaChi = Program.myReader.GetString(1);
                this.ngaySinh = Program.myReader.GetDateTime(2);
                this.Luong = (float)(Program.myReader.GetDouble(3));
            }
            Program.myReader.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            String loai = "";
            if(rBtnDH.Checked)
            {
                loai = "DH"; 
            }
            if(rBtnPN.Checked)
            {
                loai = "PN";
            }
            if(rBtnPX.Checked)
            {
                loai = "PX";
            }
            reportHoatDongNhanVien rp = new reportHoatDongNhanVien(this.maNV, DateTime.Parse(this.txtTuNgay.Text.Trim()), DateTime.Parse(this.txtDenNgay.Text.Trim()), loai);
            rp.lbTittle.Text = "HOẠT ĐỘNG NHÂN VIÊN";
            rp.lbInfo.Text = "Mã số: " + this.maNV + "\tTên: " + this.txtHoTen.Text + "\tLương: " + Luong;
            rp.lbInfo1.Text = "Địa chỉ: " + this.diaChi + "\tNgày sinh: " + this.ngaySinh + "\tLoại: " + loai;
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rpFmHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet1.NhanVien);
            cmbMaNV.SelectedIndex = 0;
            rBtnDH.Checked = true;
            this.maNV = int.Parse(cmbMaNV.SelectedValue.ToString());
            timTenNV();
        }

        private void cmbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMaNV.SelectedValue != null)
            {
                this.maNV = int.Parse(cmbMaNV.SelectedValue.ToString());
                timTenNV();
            }
        }
    }
}
