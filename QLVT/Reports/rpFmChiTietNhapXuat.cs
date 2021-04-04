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
    public partial class rpFmChiTietNhapXuat : Form
    {
        private String Loai;
        public rpFmChiTietNhapXuat()
        {
            InitializeComponent();
            rBtnPN.Checked = true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(rBtnPN.Checked)
            {
                Loai = "PN";
            }
            else
            {
                Loai = "PX";
            }
            reportChiTietNhapXuat rp = new reportChiTietNhapXuat(Program.mGroup, this.Loai, DateTime.Parse(this.txtTuNgay.Text), DateTime.Parse(this.txtDenNgay.Text));
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
