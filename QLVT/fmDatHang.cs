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
    public partial class fmDatHang : Form
    {
        bool isEdit=true;
        int vitri = 0;
        private string maDDH;
        private ValidateDH validateDH;

        public fmDatHang()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
            trangThai2();
            if (Program.mGroup != Program.nhomQuyen[1])
            {
                this.panel1.Visible = false;
            }

            if (Program.mGroup == Program.nhomQuyen[2])
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled ;
            }

            if (Program.mGroup == Program.nhomQuyen[1])
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            }
        }

        private void fmDatHang_Load(object sender, EventArgs e)
        {
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet1.DatHang);
            
            cmbCN.SelectedIndex = Program.mChinhanh;

            if (bdsDH.Count > 0)
            {
                cmbKho.SelectedValue = ((DataRowView)bdsDH[0])["MAKHO"];
            }    
            else
            {
                btnCTDH.Enabled = false;
            }

            validateDH = new ValidateDH();
        }

        private void trangThai1()
        {
            gcDH.Enabled = false;
            txtNgay.Enabled = txtNhaCC.Enabled = true;
            cmbKho.Enabled = true;


//            txtMaDDH.Enabled = false;

            // btnCTDH.Enabled = true;

            btnGhi.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnIn.Enabled = btnRefesh.Enabled
                = btnUndo.Enabled = btnRedo.Enabled = false;
            cmbCN.Enabled = false;

           // btnCTDH.Enabled = true;
        }

        private void trangThai2()
        {
            gcDH.Enabled = true;
            txtMaDDH.Enabled = txtNgay.Enabled = txtNhaCC.Enabled = false;
            cmbKho.Enabled = false;
            // btnCTDH.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
              = btnIn.Enabled = btnRefesh.Enabled
              = btnUndo.Enabled = btnRedo.Enabled = true;

            btnGhi.Enabled = btnHuy.Enabled = false;

            cmbCN.Enabled = true;

         
            this.isEdit = true;
        }

        private string sinhMaDH()
        {
            String maDH="";
            string strLenh = "EXEC SP_SINHMA_DH";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader.Read())
            {
                maDH = Program.myReader.GetString(0);
                txtMaDDH.Text = this.maDDH;
            }
            Program.myReader.Close();

            string str = "MDDH";
            int num = int.Parse(maDH.Substring(4, 4)) + 1;
            int lengOfNum = (num + "").Length;
            for (int i = 0; i < 4 - lengOfNum; i++)
            {
                str = str + "0";
            }
            str = str + num;
            return str;
        }

        private void updateTableAdapter()
        {
            bdsDH.EndEdit();
            bdsDH.ResetCurrentItem();
           // this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Update(this.qLVT_DATHANGDataSet1.DatHang);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.trangThai1();
            btnCTDH.Enabled = true;

            vitri = bdsDH.Position;
            bdsDH.AddNew();
            isEdit = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDH.Position;
            isEdit = true;

            this.trangThai1();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!this.validateDH.validate(txtNhaCC))
            {
                return;
            }

            if (!isEdit)
            {
                if (SP.isDDH(txtMaDDH.Text))
                {
                    MessageBox.Show("Đơn Hàng đã tồn tại", "THÔNG BÁO", MessageBoxButtons.OK);
                    this.trangThai1();
                    btnCTDH.Enabled = false;
                    return;
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
            if (!SP.isDelDatHang(this.maDDH))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa", "THÔNG BÁO", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (txtMaDDH.Text.Trim() == Program.username)
                    {
                        MessageBox.Show("Tài khoản này đang được sử dụng!", "THÔNG BÁO", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        bdsDH.RemoveCurrent();
                        this.updateTableAdapter();
                        MessageBox.Show("Xóa Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                }

                if (bdsDH.Count <= 0)
                {
                    btnCTDH.Enabled = false;
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
                bdsDH.RemoveCurrent();
            }
            trangThai2();
        }

        private void btnRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet1.DatHang);
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            this.maDDH = sinhMaDH();
            txtMaDDH.Text = this.maDDH;

            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MasoDDH"], this.maDDH);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["TrangThaiXoa"], 0);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MANV"], Program.username);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["NGAY"], txtNgay.Value.Date);
        }

        private void cbCN_SelectedIndexChanged(object sender, EventArgs e)
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
                    MessageBox.Show("Loi");
                }
                else
                {

                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    //this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);
                    this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet1.DatHang);
                    // this.maCN = ((DataRowView)bdsDH[0])["MACN"].ToString();
                    //this.v_DS_KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                    //this.v_DS_KHOTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_KHO);
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCTDH_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                if (SP.isDDH(txtMaDDH.Text))
                {
                    MessageBox.Show("Nhân viên đã tồn tại", "THÔNG BÁO", MessageBoxButtons.OK);
                    this.trangThai1();
                    return;
                }
            }

            try
            {
                this.updateTableAdapter();

                new fmChiTietDatHang(txtMaDDH.Text).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi thất bại\n" + ex.Message + "", "THÔNG BÁO\n", MessageBoxButtons.OK);
            }
            this.trangThai2();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcDH_Click(object sender, EventArgs e)
        {
            int[] selectedRowHandles = gridView1.GetSelectedRows();
            if(selectedRowHandles.Length>0)
            {
                string maKho = gridView1.GetRowCellValue(selectedRowHandles[0], "MAKHO").ToString();

                //Console.WriteLine(maKho);

                cmbKho.SelectedValue = maKho;
                btnCTDH.Enabled = true;
            }
         
        }

        private void cmbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKho.SelectedValue != null)
            {
                String maKho = cmbKho.SelectedValue.ToString();

                
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                if(selectedRowHandles.Length>0)
                {
                    gridView1.SetRowCellValue(selectedRowHandles[0], "MAKHO", maKho);
                }
              
            }
        }
    }
}
