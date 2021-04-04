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
    public partial class rpFmVatTu : Form
    {
        public rpFmVatTu()
        {
            InitializeComponent();
            this.lbTittle.Text = "BÁO CÁO VẬT TƯ";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            reportDSVT rp = new reportDSVT();
            rp.lbTittle.Text = "Danh sách vật tư ";
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
