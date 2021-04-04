using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Reports
{
    public partial class reportChiTietNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public reportChiTietNhapXuat(String Nhom, String Loai, DateTime TuNgay, DateTime DenNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = Nhom;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = Loai;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = TuNgay;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = DenNgay;
            this.sqlDataSource1.Fill();
        }
    }
}
