using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Reports
{
    public partial class reportDSDHChuaCoPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public reportDSDHChuaCoPhieuNhap()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
