using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Reports
{
    public partial class rpFmDSDDHChuaCoPhieuNhap : Form
    {
        public rpFmDSDDHChuaCoPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            reportDSDHChuaCoPhieuNhap rp = new reportDSDHChuaCoPhieuNhap();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void rpFmDSDDHChuaCoPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);

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
                    MessageBox.Show("Loi");
                }
            }
        }
    }
}
