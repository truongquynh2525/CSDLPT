using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Reports
{
    public partial class reportTongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public reportTongHopNhapXuat(DateTime TuNgay, DateTime DenNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = TuNgay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = DenNgay;
            this.sqlDataSource1.Fill();
        }
    }
}
