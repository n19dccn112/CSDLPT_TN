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

namespace DXApplication1
{
    public partial class FormXtraReportXemLaiBaiThi : Form
    {
        public FormXtraReportXemLaiBaiThi()
        {
            InitializeComponent();
        }

        private void FormXtraReportXemLaiBaiThi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.sP_XEMLAIBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_XEMLAIBAITHITableAdapter.Fill(this.dS.SP_XEMLAIBAITHI, Program.username);
            
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            Program.servername = cmbCoSo.SelectedValue.ToString();

            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
            }
            else
            {
                cmbCoSo.Enabled = false;
            }
            btnXEMBAITHI.Enabled = true;
            if (bdsSPXemLaiBaiThi.Count == 0)
                btnXEMBAITHI.Enabled = false;
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue == null)
            {
                return;
            }

            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbCoSo.SelectedValue.ToString();

            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mlogin = Program.loginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.dangXuat == false && Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về cơ sở mới!: mlogin: " + cmbCoSo.SelectedIndex + ", pass: " + Program.mCoso);

            else
            {
                dS.EnforceConstraints = false;
                this.sP_XEMLAIBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_XEMLAIBAITHITableAdapter.Fill(this.dS.SP_XEMLAIBAITHI, Program.username);

                btnXEMBAITHI.Enabled = true;
                if (bdsSPXemLaiBaiThi.Count == 0)
                    btnXEMBAITHI.Enabled = false;
                Program.mCoso = cmbCoSo.SelectedIndex;
            }
        }

        private void btnXEMBAITHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReportXemLaiBaiThi rpt = new XtraReportXemLaiBaiThi(edtMASV.Text, edtMAMH.Text, Int32.Parse(edtLAN.Text.ToString()));
            rpt.label_LOP.Text = edtTENMH.Text;
            rpt.label_HOTEN.Text = edtHOTEN.Text;
            rpt.label_MONTHI.Text = edtTENMH.Text;
            rpt.label_LAN.Text = edtLAN.Text;
            rpt.label_NGAYTHI.Text = edtNGAYTHI.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
