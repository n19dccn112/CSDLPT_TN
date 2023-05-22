using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class XtraReportXemLaiBaiThi : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportXemLaiBaiThi(string masv, string mamh, int lan)
        {
            InitializeComponent();
            MessageBox.Show("string: " + masv + "; string: " + mamh + "; int: " + lan);
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = masv;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = mamh;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();
        }

    }
}
