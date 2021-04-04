using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLVT.Reports;
namespace QLVT
{
    public partial class fmMain : DevExpress.XtraEditors.XtraForm
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnDangnhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(fmDangNhap));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                fmDangNhap f = new fmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(fmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                fmNhanVien f = new fmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(fmDatHang));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                fmDatHang f = new fmDatHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btKHO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(fmKho));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                fmKho f = new fmKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát", "THÔNG  BÁO", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Close();
            }
         
        }

        private void btnVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(fmVatTu));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                fmVatTu f = new fmVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(fmPhieuNhap));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                fmPhieuNhap f = new fmPhieuNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(fmPhieuXuat));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                fmPhieuXuat f = new fmPhieuXuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            //this.tableAdapterManager.Connection.ConnectionString = Program.connstr;
            //this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);


        }

        private void fmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
           
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new fmDangNhap().Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(rpFmNhanVien));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                rpFmNhanVien f = new rpFmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void dsvt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(rpFmVatTu));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                rpFmVatTu f = new rpFmVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(rpFmChiTietNhapXuat));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                rpFmChiTietNhapXuat f = new rpFmChiTietNhapXuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(rpFmHoatDongNhanVien));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                rpFmHoatDongNhanVien f = new rpFmHoatDongNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(rpFmTongHopNhapXuat));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                rpFmTongHopNhapXuat f = new rpFmTongHopNhapXuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form fm = this.CheckExists(typeof(rpFmDSDDHChuaCoPhieuNhap));
            if (fm != null)
            {
                fm.Activate();
            }
            else
            {
                rpFmDSDDHChuaCoPhieuNhap f = new rpFmDSDDHChuaCoPhieuNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
