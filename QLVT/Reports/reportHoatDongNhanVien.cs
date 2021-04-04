using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Reports
{
    public partial class reportHoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public reportHoatDongNhanVien(int manv, DateTime tungay, DateTime denngay, String loai)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = manv;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tungay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = denngay;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = loai;
            this.sqlDataSource1.Fill();
        }

    }
}
