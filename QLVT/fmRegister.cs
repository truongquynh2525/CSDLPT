using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT
{
    public partial class fmRegister : DevExpress.XtraEditors.XtraForm
    {
        private String loginName;
        private String userName;
        private String role;

        public fmRegister()
        {
            InitializeComponent();
        }

        public fmRegister(String loginName, String userName)
        {
            InitializeComponent();

            this.loginName = loginName;
            this.userName = userName;
         

            txtLogin.Text = loginName;
            txtUser.Text = userName;

            cmbRole.Items.Add(Program.nhomQuyen[0]);
            cmbRole.Items.Add(Program.nhomQuyen[2]);
            cmbRole.SelectedIndex = 0;
        }

        public fmRegister(String loginName, String userName, String role)
        {
            InitializeComponent();

            this.loginName = loginName;
            this.userName = userName;
            this.role = role;

            cmbRole.Items.Add(Program.nhomQuyen[1]);
            cmbRole.Enabled = false;
            cmbRole.SelectedIndex = 0;

            txtLogin.Text = loginName;
            txtUser.Text = userName;
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            if(txtPass.Text!=txtCPass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            if(SP.register(this.loginName, this.userName, txtCPass.Text, this.role))
            {
                MessageBox.Show("Đăng kí thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
        }
    }
}