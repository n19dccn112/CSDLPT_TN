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
    public partial class FormXtraReportXemBangDiem : Form
    {
        private DataTable dt = new DataTable();
        public FormXtraReportXemBangDiem()
        {
            InitializeComponent();
        }

        private void cOSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCoSo.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormXtraReportXemBangDiem_Load(object sender, EventArgs e)
        {
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
            }
            else cmbCoSo.Enabled = false;

            cmbLanThi.Items.Add("1");
            cmbLanThi.Items.Add("2");
            cmbLanThi.Items.Add("3");
            cmbLanThi.SelectedIndex = 0;

            dt = Program.ExecSqlDataTable("SELECT MALOP,TENLOP FROM LOP");
            cmbTenLop.DataSource = dt;
            cmbTenLop.DisplayMember = "TENLOP";
            cmbTenLop.ValueMember = "MALOP";
            cmbTenLop.SelectedIndex = 0;

            dt = Program.ExecSqlDataTable("SELECT MAMH,TENMH FROM MONHOC");
            cmbTenMH.DataSource = dt;
            cmbTenMH.DisplayMember = "TENMH";
            cmbTenMH.ValueMember = "MAMH";
            cmbTenMH.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
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

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về phòng ban mới!");
            }
            else
            {
                dS.EnforceConstraints = false;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);           
            }
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            XtraReport_XemBangDiem rpt = new XtraReport_XemBangDiem(cmbTenLop.SelectedValue.ToString(), cmbTenMH.SelectedValue.ToString(), Int32.Parse(cmbLanThi.Text.ToString()));
            rpt.lblLop.Text = "Lớp: " + cmbTenLop.Text;        
            rpt.lblMon.Text = "Môn học: " + cmbTenMH.Text;
            rpt.lblLanThi.Text = "Lần thi: " + cmbLanThi.Text.ToString();
            
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        
    }
}
