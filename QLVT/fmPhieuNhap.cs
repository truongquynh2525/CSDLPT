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
    public partial class fmPhieuNhap : Form
    {
        Boolean isEdit;
        int vitri = 0;
        private string maNV;
        private string maPN;
        private string tamMaPN;

        public fmPhieuNhap()
        {
            InitializeComponent();
            trangThai2();
            if (Program.mGroup != Program.nhomQuyen[1])
            {
                this.panel1.Visible = false;
            }


        }

        private void fmPhieuNhap_Load(object sender, EventArgs e)
        {
            qLVT_DATHANGDataSet1.EnforceConstraints = false;

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet1.PhieuNhap);

            this.v_DS_KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_KHOTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_KHO);

            this.maNV = Program.username;
            cmbCN.SelectedIndex = Program.mChinhanh;

            if (bdsPN.Count > 0)
            {
                cmbKho.SelectedValue = ((DataRowView)bdsPN[0])["MAKHO"];
                cmbMSDDH.SelectedValue = ((DataRowView)bdsPN[0])["MasoDDH"];
            }
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
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet1.PhieuNhap);
                }
            }
        }

        private void trangThai1()
        {
            gcPN.Enabled = false;
            txtMaPN.Enabled = txtNgay.Enabled = cmbMSDDH.Enabled = cmbKho.Enabled = true;

            btnGhi.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnRefesh.Enabled = btnUndo.Enabled = btnRedo.Enabled = false;

            cmbCN.Enabled = false;
        }

        private void trangThai2()
        {
            gcPN.Enabled = true;
            txtMaPN.Enabled = txtNgay.Enabled = cmbMSDDH.Enabled = cmbKho.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
            = btnRefesh.Enabled = btnUndo.Enabled = btnRedo.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;

            cmbCN.Enabled = true;
        }

        private void updateTableAdapter()
        {
            bdsPN.EndEdit();
            bdsPN.ResetCurrentItem();
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Update(this.qLVT_DATHANGDataSet1.PhieuNhap);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private string sinhMaPN(string MaPN)
        {
            string str = "PN";
            int num = int.Parse(MaPN.Substring(2, 6)) + 1;
            int lengOfNum = (num + "").Length;
            for (int i = 0; i < 6 - lengOfNum; i++)
            {
                str = str + "0";
            }
            str = str + num;
            return str;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThai1();
            txtMaPN.Enabled = false;
            string strLenh = "EXEC SP_SINHMA_PN";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader.Read())
            {
                this.maPN = Program.myReader.GetString(0);
            }
            if (this.maPN == "-1")
            {
                this.maPN = "PN000001";
            }
            else
            {
                this.maPN = sinhMaPN(this.maPN);
            }
            Program.myReader.Close();
            vitri = bdsPN.Position;
            bdsPN.AddNew();
            txtMaPN.Text = this.maPN;
            isEdit = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThai1();
            vitri = bdsPN.Position;
            txtMaPN.Enabled = false;
            isEdit = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "DECLARE @CHECK INT\n" +
                            "EXEC @CHECK = SP_KTMDDH_PN '" + cmbMSDDH.SelectedValue + "'\n" +
                            "SELECT @CHECK";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader.Read())
            {
                if (Program.myReader.GetInt32(0) == 1)
                {
                    MessageBox.Show("Đơn hàng này đã được lập phiếu!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                    cmbMSDDH.Focus();
                    Program.myReader.Close();
                    return;
                }
            }
            Program.myReader.Close();
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThai1();
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                bdsPN.RemoveCurrent();
                this.updateTableAdapter();
                MessageBox.Show("Xóa Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
            }

            trangThai2();
        }

        private void btnRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.updateTableAdapter();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!isEdit)
            {
                bdsPN.RemoveCurrent();
            }
            trangThai2();
        }


        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView1 = sender as GridView;
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MAPN"], this.maPN);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["NGAY"], txtNgay.Value.Date);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MANV"], this.maNV);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MAKHO"], cmbKho.SelectedValue);
        }

        private void btnCTPN_Click(object sender, EventArgs e)
        {
            this.tamMaPN = gridView1.GetRowCellValue(bdsPN.Position, "MAPN").ToString();
            new fmChiTietPhieuNhap(this.tamMaPN).Show();
        }

        private void cmbMSDDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMSDDH.SelectedValue != null)
            {
                String maDDH = cmbMSDDH.SelectedValue.ToString();

                int[] selectedRowHandles = gridView1.GetSelectedRows();
                if (selectedRowHandles.Length > 0)
                {
                    gridView1.SetRowCellValue(selectedRowHandles[0], "MasoDDH", maDDH);
                }

            }
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