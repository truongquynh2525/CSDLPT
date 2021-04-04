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
using QLVT.Validate;

namespace QLVT
{
    public partial class fmVatTu : Form
    {
        private ValidateVatTu validateVatTu;
        int vitri=0;
        bool isEdit;

        public fmVatTu()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
            trangThai2();

            if (Program.mGroup == Program.nhomQuyen[1])
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            }

            this.validateVatTu = new ValidateVatTu();
        }

        private void fmVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet1.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet1.Vattu);

        }

        private void trangThai1()
        {
            

            gcVATTU.Enabled = false;
            txtMAVT.Enabled = txtTENVT.Enabled = txtSLT.Enabled = txtDVT.Enabled = true;

            btnGhi.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnIn.Enabled = btnRefesh.Enabled
                = btnUndo.Enabled = btnRedo.Enabled = false;
           
        }

        private void trangThai2()
        {
            txtMAVT.Enabled = txtTENVT.Enabled = txtSLT.Enabled = txtDVT.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
              = btnIn.Enabled = btnRefesh.Enabled
              = btnUndo.Enabled = btnRedo.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gcVATTU.Enabled = true;
 
        }

        private void updateTableAdapter()
        {
            bdsVT.EndEdit();
            bdsVT.ResetCurrentItem();
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Update(this.qLVT_DATHANGDataSet1.Vattu);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.trangThai1();
            vitri = bdsVT.Position;
            bdsVT.AddNew();

            isEdit = false;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVT.Position;
            isEdit = true;

            this.trangThai1();
            txtMAVT.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!this.validateVatTu.validate(txtMAVT,txtTENVT,txtDVT,txtSLT))
            {
                return;
            }

            if (!isEdit)
            {
                String strLenh = "DECLARE @return_value int \n" +
                                "EXEC @return_value = [dbo].[sp_KiemtraMaVT_TonTai] \n" +
                                "@MAVT =N'" + txtMAVT.Text + "'\n" +
                                "SELECT  'Return Value' = @return_value \n";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null)
                {
                    return;
                }
                if (Program.myReader.Read())
                {
                    if (Program.myReader.GetInt32(0) == 1)
                    {
                        MessageBox.Show("Vật tư đã tồn tại", "THÔNG BÁO", MessageBoxButtons.OK);
                        this.trangThai1();
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
            if (gridView1.GetFocusedDataRow()["TrangThaiXoa"].ToString() == "0")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa", "THÔNG BÁO", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (txtMAVT.Text.Trim() == Program.username)
                    {
                        MessageBox.Show("Tài khoản này đang được sử dụng!", "THÔNG BÁO", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        bdsVT.RemoveCurrent();
                        this.updateTableAdapter();
                        MessageBox.Show("Xóa Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không Thể Xóa", "THÔNG BÁO", MessageBoxButtons.OK);
            }



            trangThai2();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!isEdit)
            {
                bdsVT.RemoveCurrent();
            }
            trangThai2();
        }

        private void btnRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet1.Vattu);
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView1 = sender as GridView;
           
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["TrangThaiXoa"], 0);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
