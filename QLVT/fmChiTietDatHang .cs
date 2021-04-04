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

namespace QLVT
{
    public partial class fmChiTietDatHang : Form
    {
        private ValidateCTDH validateCTDH;
        private String maVT;
        private String maDDH;
        bool isEdit;
        int vitri = 0;

        public fmChiTietDatHang()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
            validateCTDH = new ValidateCTDH();

            this.trangThai2();
        }

        public fmChiTietDatHang(String maDDH)
        {
            InitializeComponent();
            this.maDDH = maDDH;
            this.Text = "Chi tiết đơn đặt hàng " + this.maDDH;
            gridView1.OptionsBehavior.Editable = false;

            this.gridView1.ActiveFilterString = "StartsWith([MasoDDH], \'" + this.maDDH + "\')";
            gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            colMasoDDH.OptionsFilter.AllowFilter = false;
            this.trangThai2();

            validateCTDH = new ValidateCTDH();
        }

        private void trangThai1()
        {
            gcCTDDH.Enabled = false;
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
            gcCTDDH.Enabled = true;
            
        }

        private void fmChiTietDatHang_Load(object sender, EventArgs e)
        {
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_VATTU' table. You can move, or remove it, as needed.
            this.v_DS_VATTUTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_VATTU);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet1.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet1.CTDDH);

            if(bdsCTDDH.Count>0)
            {
                cmbVatTu.SelectedValue = ((DataRowView)bdsCTDDH[0])["MAVT"];
            }
        }

        private void updateTableAdapter()
        {
            bdsCTDDH.EndEdit();
            bdsCTDDH.ResetCurrentItem();
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Update(this.qLVT_DATHANGDataSet1.CTDDH);
        }

      


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.trangThai1();
            vitri = bdsCTDDH.Position;
            bdsCTDDH.AddNew();

            isEdit = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsCTDDH.Position;
            isEdit = true;

            this.trangThai1();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!validateCTDH.validate(txtSoLg,txtDonGia))
            {
                return;
            }

            if (!isEdit)
            {
                if(SP.isCTDDH(this.maDDH, this.maVT))
                {
                    bdsCTDDH.RemoveCurrent();
                    DialogResult rs = MessageBox.Show("Vật tư này đã tồn tại bạn có muốn đặt thêm", "THÔNG BÁO", MessageBoxButtons.YesNo);
                    if(rs == DialogResult.Yes)
                    {
                        SP.updateCTDDH(this.maDDH, this.maVT, int.Parse(txtSoLg.Text), float.Parse(txtDonGia.Text));
                        this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet1.CTDDH);
                        this.trangThai2();
                        return;
                    }
                    else
                    {
                        this.trangThai2();
                        return;
                    }
                }
            }

            try
            {
                this.updateTableAdapter();
                MessageBox.Show("Ghi thành công", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi thất bại\n" + ex.Message + "", "THÔNG BÁO\n", MessageBoxButtons.OK);
            }

            this.trangThai2();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThai1();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bdsCTDDH.RemoveCurrent();
                this.updateTableAdapter();
                MessageBox.Show("Xóa Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
            }

            trangThai2();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!isEdit)
            {
                bdsCTDDH.RemoveCurrent();
            }
            trangThai2();
        }

        private void btnRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet1.CTDDH);
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView1 = sender as GridView;
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MAVT"], cmbVatTu.SelectedValue.ToString());
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MasoDDH"], this.maDDH);
        }

        private void cmbVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVatTu.SelectedValue != null)
            {
                this.maVT = cmbVatTu.SelectedValue.ToString();
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                if(selectedRowHandles.Length>0)
                {
                    gridView1.SetRowCellValue(selectedRowHandles[0], "MAKHO", this.maVT);
                }
            }
            
        }

        private void gcCTDDH_Click(object sender, EventArgs e)
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();
            string maKho = gridView1.GetRowCellValue(SelectedRowHandles[0], "MAVT").ToString();

            //Console.WriteLine(maKho);

            cmbVatTu.SelectedValue = maKho;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
