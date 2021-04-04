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

namespace QLVT
{
    public partial class fmPhieuXuat : Form
    {
        bool isEdit =true;
        int vitri = 0;
        private string maPX ;

        public fmPhieuXuat()
        {
            InitializeComponent();
            trangThai2();
            if (Program.mGroup != Program.nhomQuyen[1])
            {
                this.panel1.Visible = false;
            }
        }

        private void fmPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);
            qLVT_DATHANGDataSet1.EnforceConstraints = false;
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet1.PhieuXuat);

            this.v_DS_KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_KHOTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_KHO);

            if (bdsPX.Count > 0)
            {
                cmbKho.SelectedValue = ((DataRowView)bdsPX[0])["MAKHO"];
            }

            cmbCN.SelectedIndex = Program.mChinhanh;

        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedValue != null)
            {
                Program.servername = cmbCN.SelectedValue.ToString();

                if (cmbCN.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }

                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                }
                else
                {
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet1.PhieuXuat);
                }
            }
        }
        
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void trangThai1()
        {
            gcPX.Enabled = false;
            txtMaPX.Enabled = txtNgay.Enabled = true;
            txtHoTenKH.Enabled = false;

            btnGhi.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnRefesh.Enabled = btnUndo.Enabled = btnRedo.Enabled = false;

            cmbKho.Enabled = true;

            cmbCN.Enabled = false;
        }

        private void trangThai2()
        {
            gcPX.Enabled = true;
            txtMaPX.Enabled = txtNgay.Enabled = txtHoTenKH.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
            = btnRefesh.Enabled = btnUndo.Enabled = btnRedo.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;

            cmbKho.Enabled = false;

            cmbCN.Enabled = true;
        }

        private void updateTableAdapter()
        {
            bdsPX.EndEdit();
            bdsPX.ResetCurrentItem();
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Update(this.qLVT_DATHANGDataSet1.PhieuXuat);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThai1();
            txtMaPX.Enabled = false;
            string strLenh = "EXEC SP_SINHMA_PX";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader.Read())
            {
                this.maPX = Program.myReader.GetString(0);
            }
            if (this.maPX == "-1")
            {
                this.maPX = "PX01";
            }
            else
            {
                int num = int.Parse(maPX.Substring(2, 4)) + 1;
                string str = "PX";
                if (num < 10)
                {
                    str = "PX0";
                }
                this.maPX = str + num;
            }

            vitri = bdsPX.Position;
            bdsPX.AddNew();
            txtMaPX.Text = this.maPX;
            isEdit = false;
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView1 = sender as GridView;
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MAPX"], this.maPX);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["NGAY"], txtNgay.Value.Date);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MANV"], Program.username);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThai1();
            vitri = bdsPX.Position;
            txtMaPX.Enabled = false;
            isEdit = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtHoTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Nhập tên khách hàng", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtHoTenKH.Focus();
                return;
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

        private void btnCTPX_Click(object sender, EventArgs e)
        {
            String tamMaPX = gridView1.GetRowCellValue(bdsPX.Position, "MAPX").ToString();
            new fmChiTietPhieuXuat(tamMaPX).Show();
        }

        private void cmbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKho.SelectedValue != null)
            {
                String maKho = cmbKho.SelectedValue.ToString();


                int[] selectedRowHandles = gridView1.GetSelectedRows();
                if (selectedRowHandles.Length > 0)
                {
                    gridView1.SetRowCellValue(selectedRowHandles[0], "MAKHO", maKho);
                }

            }
        }
    }
}