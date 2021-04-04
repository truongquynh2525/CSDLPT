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
    public partial class rpFmTongHopNhapXuat : Form
    {
        public rpFmTongHopNhapXuat()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            reportTongHopNhapXuat rp = new reportTongHopNhapXuat(DateTime.Parse(this.txtTuNgay.Text.Trim()), DateTime.Parse(this.txtDenNgay.Text.Trim()));
            rp.lbName.Text = cmbCN.SelectedText;
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void rpFmTongHopNhapXuat_Load(object sender, EventArgs e)
        {
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
