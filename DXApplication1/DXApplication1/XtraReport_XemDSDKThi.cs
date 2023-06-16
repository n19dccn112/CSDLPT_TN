using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DXApplication1
{
    public partial class XtraReport_XemDSDKThi : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_XemDSDKThi(DateTime TuNgay, DateTime DenNgay)
        {

            InitializeComponent();

            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = TuNgay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = DenNgay;
            this.sqlDataSource1.Fill();
        }
    }
}
