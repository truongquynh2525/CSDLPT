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

    public partial class fmChiTietPhieuXuat : Form
    {
        bool isEdit;
        int vitri = 0;
        private String maPX;
        private ValidateCTPX validateCTPX;

        public fmChiTietPhieuXuat(String maPX)
        {
            InitializeComponent();
            this.maPX = maPX;
            this.Text = "Chi tiết phiếu xuất " + this.maPX;
            gridView1.OptionsBehavior.Editable = false;

            this.gridView1.ActiveFilterString = "StartsWith([MAPX], \'" + this.maPX + "\')";
            gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            colMAPX.OptionsFilter.AllowFilter = false;
            this.trangThai2();

            this.validateCTPX = new ValidateCTPX();
        }

        private void trangThai1()
        {
            gcCTPX.Enabled = false;
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
            gcCTPX.Enabled = true;

        }

        private void fmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            qLVT_DATHANGDataSet1.EnforceConstraints = false;
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet1.CTPX);

            this.v_DS_KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_KHOTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_KHO);

            cmbVatTu.SelectedIndex = 1;
            cmbVatTu.SelectedIndex = 0;
        }

        private void updateTableAdapter()
        {
            bdsCTPX.EndEdit();
            bdsCTPX.ResetCurrentItem();
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Update(this.qLVT_DATHANGDataSet1.CTPX);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.trangThai1();
            vitri = bdsCTPX.Position;
            bdsCTPX.AddNew();

            isEdit = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsCTPX.Position;
            isEdit = true;

            this.trangThai1();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThai1();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "THÔNG BÁO XÓA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bdsCTPX.RemoveCurrent();
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
            if(!validateCTPX.validate(txtSoLg,txtDonGia))
            {
                return;
            }

            int soLg = int.Parse(txtSoLg.Text.ToString().Trim());
            float donGia = float.Parse(txtDonGia.Text.ToString().Trim());
            if (soLg <= 0)
            {
                MessageBox.Show("Số lượng không phù hợp", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtSoLg.Focus();
                return;
            }
            if (donGia < 0)
            {
                MessageBox.Show("Đơn giá không phù hợp", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return;
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
                bdsCTPX.RemoveCurrent();
            }
            trangThai2();
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView1 = sender as GridView;
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MAPX"], this.maPX);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MAVT"], cmbVatTu.SelectedValue);
        }
    }
}