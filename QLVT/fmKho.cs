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
using System.Collections.Generic;
using QLVT.Class;
using System.Data.SqlClient;

namespace QLVT
{
    public partial class fmKho : Form
    {
        private ValidateKho validateKho;
        private String maCN;
        int vitri = 0;
        int type = 0;
        String sql;
        SqlCommand sqlcommand;
        bool isEdit;
        Stack<SqlCommand> undo = new Stack<SqlCommand>();
        Stack<SqlCommand> redo = new Stack<SqlCommand>();
        String makho;
        String tenkho;
        String diachi;
        String macn;

        public fmKho()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
            trangThai2();
            if (Program.mGroup != Program.nhomQuyen[1])
            {
                this.panel1.Visible = false;
            }

            if (Program.mGroup == Program.nhomQuyen[1])
            {
                
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            }

            this.validateKho = new ValidateKho();
        }

        private void delete(Stack<SqlCommand> cmd)
        {
            sql = "DELETE FROM Kho WHERE MAKHO = @MAKHO";
            sqlcommand = new SqlCommand(sql);
            sqlcommand.Parameters.AddWithValue("@MAKHO", makho);
            cmd.Push(sqlcommand);
        }

        private void edit(Stack<SqlCommand> cmd)
        {
            sql = "UPDATE Kho SET TENKHO = @TENKHO, DIACHI = @DIACHI, MACN = @MACN WHERE MAKHO = @MAKHO";
            sqlcommand = new SqlCommand(sql);
            sqlcommand.Parameters.AddWithValue("@MAKHO", makho);
            sqlcommand.Parameters.AddWithValue("@TENKHO", tenkho);
            sqlcommand.Parameters.AddWithValue("@DIACHI", diachi);
            sqlcommand.Parameters.AddWithValue("@MACN", this.maCN);
            cmd.Push(sqlcommand);
        }

        private void addNew(Stack<SqlCommand> cmd)
        {
            sql = "INSERT INTO Kho (MAKHO, TENKHO, DIACHI, MACN) VALUES ('" + makho + "',N'" + tenkho + "',N'" + diachi + "','" + macn + "')";
            sqlcommand = new SqlCommand(sql);
            cmd.Push(sqlcommand);
        }
       
        private void fmKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_KHO' table. You can move, or remove it, as needed.
            this.v_DS_KHOTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_KHO);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet1.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet1.CTDDH);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet1.Kho);

            if (bdsKho.Count > 0)
            {
                this.maCN = ((DataRowView)bdsKho[0])["MACN"].ToString();
            }
            else
            {
                DialogResult rs = MessageBox.Show("Chi Nhánh Hiện Tại Vẫn Chưa Có Mã. " +
                    "Bạn Có Muốn Thêm Mã Chi Nhánh Là CN" + (Program.mChinhanh + 1) + " Không",
                    "THÔNG BÁO", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
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
            gcKHO.Enabled = false;
            txtDiaChi.Enabled = txtTenKho.Enabled  = true;
            txtMaKho.Enabled = false;

            btnGhi.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnIn.Enabled = btnRefesh.Enabled
                = btnUndo.Enabled = btnRedo.Enabled = false;
            cmbCN.Enabled = false;
        }

        private void trangThai2()
        {
            txtDiaChi.Enabled = txtMaKho.Enabled = txtTenKho.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
              = btnIn.Enabled = btnRefesh.Enabled
              = btnUndo.Enabled = btnRedo.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gcKHO.Enabled = true;
            cmbCN.Enabled = true;
        }

        private void updateTableAdapter()
        {
            bdsKho.EndEdit();
            bdsKho.ResetCurrentItem();
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Update(this.qLVT_DATHANGDataSet1.Kho);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.trangThai1();
            vitri = bdsKho.Position;
            bdsKho.AddNew();
            txtMaKho.Text = SP.sinhMaKho();
            isEdit = false;
            type = 1; //them
            
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaKho.Enabled = false;
            txtMaCN.Text = this.maCN;
            makho = txtMaKho.Text.Trim();
            Console.WriteLine(makho);
            tenkho = txtTenKho.Text.Trim();
            Console.WriteLine(tenkho);
            diachi = txtDiaChi.Text.Trim();
            Console.WriteLine(diachi);
            macn = this.maCN.Trim();
            Console.WriteLine(macn);
            isEdit = true;
            type = 2;
            this.trangThai1();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!validateKho.validate(txtMaKho,txtTenKho,txtDiaChi))
            {
                return;
            }
            try
            {
                if(type == 1)
                {
                    makho = txtMaKho.Text.Trim();
                    tenkho = txtTenKho.Text.Trim();
                    diachi = txtDiaChi.Text.Trim();
                    macn = this.maCN.Trim();
                    delete(undo);
                }
                if(type == 2)
                {
                    edit(undo);
                }
              
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
                if (txtMaKho.Text.Trim() == Program.username)
                {
                    MessageBox.Show("Tài khoản này đang được sử dụng!", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    type = 3;
                    makho = txtMaKho.Text.Trim();
                    tenkho = txtTenKho.Text.Trim();
                    diachi = txtDiaChi.Text.Trim();
                    macn = this.maCN.Trim();
                    addNew(undo);
                    bdsKho.RemoveCurrent();
                    this.updateTableAdapter();
                    MessageBox.Show("Xóa Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
            trangThai2();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!isEdit)
            {
                bdsKho.RemoveCurrent();
            }
            trangThai2();
        }

        private void btnRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet1.Kho);
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView1 = sender as GridView;
            gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["MACN"], this.maCN);
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

                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    //this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);
                    this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet1.Kho);
                    this.maCN = ((DataRowView)bdsKho[0])["MACN"].ToString();
                    
                }
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(undo.Count < 1)
            {
                return;
            }

            bdsKho.MoveLast();
            makho = txtMaKho.Text.Trim();
            tenkho = txtTenKho.Text.Trim();
            diachi = txtDiaChi.Text.Trim();
            macn = this.maCN.Trim();

            if (MessageBox.Show("Bạn có chắc chắn muốn phục hồi không ? ", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand sql = undo.Pop();

                bdsKho.MoveLast();
                try
                {
                    Program.KetNoi();
                    sql.Connection = Program.conn;
                    sql.ExecuteNonQuery();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet1.Kho);
                    bdsKho.MoveLast();
                    if (type == 1)
                    {
                        addNew(redo);
                    }
                    if(type == 2)
                    {
                        edit(redo);
                    }
                    if (type == 3)
                    {
                        bdsKho.MoveLast();
                        makho = txtMaKho.Text.Trim();
                        tenkho = txtTenKho.Text.Trim();
                        diachi = txtDiaChi.Text.Trim();
                        macn = this.maCN.Trim();
                        delete(redo);
                    }                 
                    Program.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Phục Hồi!" + ex, "Thông Báo", MessageBoxButtons.OK);
                    Program.conn.Close();
                }
            }
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (redo.Count < 1)
            {
                return;
            }
         
            bdsKho.MoveLast();
            makho = txtMaKho.Text.Trim();
            tenkho = txtTenKho.Text.Trim();
            diachi = txtDiaChi.Text.Trim();
            macn = this.maCN.Trim();
            if (MessageBox.Show("Bạn có chắc chắn muốn phục hồi không ? ", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand sql = redo.Pop();
                if (redo.Count == 1)
                {
                    if (type == 1)
                    {
                        type = 3;
                    }
                    if (type == 3)
                    {
                        type = 1;
                    }
                }

                bdsKho.MoveLast();
                try
                {
                    Program.KetNoi();
                    sql.Connection = Program.conn;
                    sql.ExecuteNonQuery();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet1.Kho);
                    if (type == 1)
                    {
                        addNew(undo);
                    }
                    if(type == 2)
                    {
                        edit(undo);
                    }
                    if (type == 3)
                    {
                        bdsKho.MoveLast();
                        makho = txtMaKho.Text.Trim();
                        tenkho = txtTenKho.Text.Trim();
                        diachi = txtDiaChi.Text.Trim();
                        macn = this.maCN.Trim();
                        delete(undo);
                    }               
                    Program.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Phục Hồi!" + ex, "Thông Báo", MessageBoxButtons.OK);
                    Program.conn.Close();
                }
            }
        }
    }
}
