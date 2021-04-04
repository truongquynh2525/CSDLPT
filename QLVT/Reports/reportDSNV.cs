using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Reports
{
    public partial class reportDSNV : DevExpress.XtraReports.UI.XtraReport
    {
        public reportDSNV()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }
    }
}
