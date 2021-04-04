using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace QLVT
{
    public partial class fmDangNhap : Form
    {
        public fmDangNhap()
        {
            InitializeComponent();
        }

        private void fmDangNhap_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=TRUONGQUYNH;Initial Catalog=QLVT_DATHANG;Persist Security Info=True;User ID=sa;Password=123";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cbCN.DataSource = dt;
            cbCN.DisplayMember = "TENCN";
            cbCN.ValueMember = "TENSERVER";
            cbCN.SelectedIndex = 1;
            cbCN.SelectedIndex = 0;
        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCN.SelectedValue == null)
            {
                return;
            }                
            Program.servername = cbCN.SelectedValue.ToString();
            
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }

            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0)
            {
                return;
            }
            Program.mChinhanh = cbCN.SelectedIndex;
            
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if(Program.myReader == null)
            {
                return;
            }
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if(Convert.IsDBNull(Program.username) == true)
            {
                MessageBox.Show("Login bạn không có quyền truy cập dữ liệu\n Bạn xem lại username và password\n");
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

                       
            Program.fmChinh = new fmMain();
            Program.fmChinh.MANV.Text = "Mã nhân viên: " + Program.username;
            Program.fmChinh.HOTEN.Text = "Họ tên: " + Program.mHoten;
            Program.fmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;
            Program.fmChinh.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Trim() == "" && txtPass.Text.Trim() == "")
            {
                Close();
            }
            else
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(r == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

      
    }
}
