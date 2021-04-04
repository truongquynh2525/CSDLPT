using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using QLVT.Validate;

namespace QLVT
{
    public partial class fmChiTietPhieuNhap : Form
    {
        bool isEdit;
        int vitri = 0;
        private String maPN;
        private ValidateCTPN validateCTPN;

        public fmChiTietPhieuNhap(String maPN)
        {
            InitializeComponent();
            this.maPN = maPN;
            this.Text = "Chi tiết phiếu nhập " + this.maPN;
            gridView1.OptionsBehavior.Editable = false;

            this.gridView1.ActiveFilterString = "StartsWith([MAPN], \'" + this.maPN + "\')";
            gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            colMAPN.OptionsFilter.AllowFilter = false;
            this.trangThai2();

            validateCTPN = new ValidateCTPN();
        }

        private void trangThai1()
        {
            gcCTPN.Enabled = false;
            cmbVatTu.Enabled = txtSoLg.Enabled = txtDonGia.Enabled = true;

            btnGhi.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                 = btnRefesh.Enabled
                = btnUndo.Enabled = btnRedo.Enabled = false;

        }

        private void trangThai2()
        {
            cmbVatTu.Enabled = txtSoLg.Enabled = txtDonGia.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
              = btnRefesh.Enabled
              = btnUndo.Enabled = btnRedo.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gcCTPN.Enabled = true;

        }

        private void fmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            qLVT_DATHANGDataSet1.EnforceConstraints = false;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet1.CTPN);

            this.v_DS_VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_VATTUTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_VATTU);

            cmbVatTu.SelectedIndex = 0;
        }

        private void updateTableAdapter()
        {
            bdsCTPN.EndEdit();
            bdsCTPN.ResetCurrentItem();
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Update(this.qLVT_DATHANGDataSet1.CTPN);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.trangThai1();
            vitri = bdsCTPN.Position;
            bdsCTPN.AddNew();

            isEdit = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsCTPN.Position;
            isEdit = true;

            this.trangThai1();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThai1();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "THÔNG BÁO XÓA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bdsCTPN.RemoveCurrent();
                this.updateTableAdapter();
                MessageBox.Show("Xóa Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
            }

            trangThai2();
        }

        private void btnRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.updateTableAdapter();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!this.validateCTPN.validate(txtSoLg,txtDonGia))
            {
                return;
            }

            int soLg = int.Parse(txtSoLg.Text.ToString().Trim());
            float donGia = float.Parse(txtDonGia.Text.ToString().Trim().Replace(",", ""));

            if (soLg < 0 || soLg > 9999)
            {
                MessageBox.Show("Số lượng không phù hợp", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtSoLg.Focus();
            }
            if (donGia <= 0 || donGia > 99999999)
            {
                MessageBox.Show("Đơn giá không phù hợp", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtDonGia.Focus();
            }
            try
            {
                this.updateTableAdapter();
                MessageBox.Show("Ghi thành công", "THÔNG BÁO GHI", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi thất bại\n" + ex.Message + "", "THÔNG BÁO GHI\n", MessageBoxButtons.OK);
            }
            this.trangThai2();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!isEdit)
            {
                bdsCTPN.RemoveCurrent();
            }
            trangThai2();
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView1 = sender as GridView;
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MAPN"], this.maPN);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MAVT"], cmbVatTu.SelectedValue);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}