using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using QLVT.Validate;

namespace QLVT
{
    public partial class fmNhanVien : Form
    {
        Boolean isEdit ;
        int vitri = 0;
        private string maCN = "CN1";
        private ValidateNhanVien validateNhanVien;
        private Stack st = new Stack();
        private int[] leng;

        public fmNhanVien()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
            txtMACN.Text = this.maCN;
            trangThai2();

            if (Program.mGroup == Program.nhomQuyen[2])
            {
                btnDK.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = false;
            }
            else
            {
                btnDK.Enabled = true;
            }

            if (Program.mGroup == Program.nhomQuyen[1])
            {
                this.panel1.Visible = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            }
            else
                this.panel1.Visible = false;

            this.validateNhanVien = new ValidateNhanVien();

        }

        private void fmNhanVien_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet1.NhanVien);

            leng = gridView1.GetSelectedRows();

            if (bdsNV.Count > 0)
            {
                this.maCN = ((DataRowView)bdsNV[0])["MACN"].ToString();
                String maNV= ((DataRowView)bdsNV[0])["MANV"].ToString();
                this.checkAcount(maNV);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Chi Nhánh Hiện Tại Vẫn Chưa Có Mã. " +
                    "Bạn Có Muốn Cho Mã Chi Nhánh Là CN"+(Program.mChinhanh+1)+" Không", 
                    "THÔNG BÁO", MessageBoxButtons.YesNo);
                if(rs==DialogResult.Yes)
                {
                    this.maCN = "CN" + (Program.mChinhanh + 1);
                }
                else
                {
                    this.BeginInvoke(new MethodInvoker(Close));
                }
            }
           
            cmbCN.SelectedIndex = Program.mChinhanh;
           
        }

        private void trangThai1()
        {
            gcNV.Enabled = false;
            txtDIACHI.Enabled = txtHO.Enabled = txtLUONG.Enabled = txtMACN.Enabled
           = txtMANV.Enabled = txtTEN.Enabled = txtNGAYSINH.Enabled = true;

            btnGhi.Enabled = btnHuy.Enabled  = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled 
                = btnIn.Enabled = btnRefesh.Enabled
                = btnUndo.Enabled = btnRedo.Enabled = false;
            cmbCN.Enabled = false;

            if (Program.mGroup != Program.nhomQuyen[2])
            {
                btnDK.Enabled = false;
            }
           
        }

        private void trangThai2()
        {
            txtDIACHI.Enabled = txtHO.Enabled = txtLUONG.Enabled = txtMACN.Enabled
          = txtMANV.Enabled = txtTEN.Enabled = txtNGAYSINH.Enabled = false;
            btnDK.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
              = btnIn.Enabled = btnRefesh.Enabled
              = btnUndo.Enabled = btnRedo.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gcNV.Enabled = true;
            cmbCN.Enabled = true;

            if (Program.mGroup != Program.nhomQuyen[2])
            {
                btnThem.Enabled = btnXoa.Enabled = false;
            }
        }

        private void checkAcount(String maNV)
        {
            if (SP.isAccount(maNV))
            {
                btnDK.Enabled = false;
                btnDK.Text = "Đã Đăng Kí";
            }
            else
            {
                btnDK.Enabled = true;
                btnDK.Text = "Đăng Kí";
            }
        }

        private void updateTableAdapter()
        {
            bdsNV.EndEdit();
            bdsNV.ResetCurrentItem();
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Update(this.qLVT_DATHANGDataSet1.NhanVien);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.trangThai1();
            vitri = bdsNV.Position;
            bdsNV.AddNew();
          
            isEdit = false;

            txtMACN.Text = this.maCN;
            txtTTX.Text = "0";
            txtLUONG.Text = "7,000,000.00";
            btnDK.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            isEdit = true;
            
            this.trangThai1();
            txtMANV.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!validateNhanVien.validate(txtMANV,txtHO,txtTEN,txtDIACHI,txtLUONG))
            {
                return;
            }

            try
            {
                st.Push(gridView1.GetDataRow(leng[vitri]));
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
            foreach(var stackItem in st)
            {
                Console.WriteLine(stackItem);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThai1();
            if (gridView1.GetFocusedDataRow()["TrangThaiXoa"].ToString() == "0")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa", "THÔNG BÁO", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (txtMANV.Text.Trim() == Program.username)
                    {
                        MessageBox.Show("Tài khoản này đang được sử dụng!", "THÔNG BÁO", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        bdsNV.RemoveCurrent();
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
            if(!isEdit)
            {
                bdsNV.RemoveCurrent();
            }
            trangThai2();
        }

        private void btnRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet1.NhanVien);
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView1 = sender as GridView;
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MACN"], this.maCN);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["TrangThaiXoa"],0);
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["NGAYSINH"], txtNGAYSINH.Value.Date);
        }

        private void cbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedValue!=null)
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
                   
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    //this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);
                    this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet1.NhanVien);
                    this.maCN = ((DataRowView)bdsNV[0])["MACN"].ToString();
                }
            }
          
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            String loginName = txtHO.Text + txtTEN.Text + txtMANV.Text;
            String userName = txtMANV.Text;
            if(Program.mGroup==Program.nhomQuyen[0])
            {
                new fmRegister(loginName,userName).Show();
            }
            else if (Program.mGroup == Program.nhomQuyen[1])
            {
                new fmRegister(loginName, userName, Program.nhomQuyen[1]).Show();
            }
            
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcNV_Click(object sender, EventArgs e)
        {
            int[] selectedRowHandles = gridView1.GetSelectedRows();
            if (selectedRowHandles.Length > 0)
            {
                string maNV = gridView1.GetRowCellValue(selectedRowHandles[0], "MANV").ToString();
                this.checkAcount(maNV);

            }
        }
    }
}
