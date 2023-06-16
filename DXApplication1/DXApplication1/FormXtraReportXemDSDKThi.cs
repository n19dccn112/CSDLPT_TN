using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace DXApplication1
{
    public partial class FormXtraReportXemDSDKThi : Form
    {
        public FormXtraReportXemDSDKThi()
        {
            InitializeComponent();
        }

        private void cOSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCoSo.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormXtraReportXemDSDKThi_Load(object sender, EventArgs e)
        {
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            Program.servername = cmbCoSo.SelectedValue.ToString();
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
            }
            else cmbCoSo.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            if (dtTuNgay.Text.ToString().Trim() == "" || dtDenNgay.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc không được để trống", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (DateTime.Compare(dtTuNgay.DateTime, dtDenNgay.DateTime) > 0)
            {
                MessageBox.Show("Ngày bắt đầu không lớn hơn ngày kết thúc", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            XtraReport_XemDSDKThi rpt = new XtraReport_XemDSDKThi(dtTuNgay.DateTime, dtDenNgay.DateTime);
            rpt.lblTieuDe.Text = "DANH SÁCH ĐĂNG KÍ THI TRẮC NGHIỆM " + cmbCoSo.Text.ToString().ToUpper();
            rpt.lblTuNgay.Text = dtTuNgay.DateTime.ToString("dd/MM/yyyy");
            rpt.lblDenNgay.Text = dtDenNgay.DateTime.ToString("dd/MM/yyyy");
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về phòng ban mới!");
            }
            else
            {

            }
        }
    }
}
