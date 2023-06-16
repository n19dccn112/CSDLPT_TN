using System;
using System.Data;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class formDangNhap : Form
    {

        private SqlConnection conn_publisher = new SqlConnection();
        private const String accountStudent = "SV";
        private const String passwordStudent = "123";

        public formDangNhap()
        {
            InitializeComponent();
            rbtnSV.Checked = true;
            labelTK.Text = "Sinh viên";
        }
        private int KetNoiCSDLGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstrPublisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi kết nối về CSDL gốc.\nBạn xem lại tên server của publiser, và tên CSDL trong chuối kết nối.\n" + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }
        private void LayDSPM(string cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS"; cmbCoSo.ValueMember = "TENSERVER";
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((txtTK.Text.Trim() == "" || txtMK.Text.Trim() == ""))
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }

            if (rbtnSV.Checked)
            {
                Program.mlogin = accountStudent;
                Program.password = passwordStudent;
                if (Program.KetNoi() == 0) return;

                Program.mCoso = cmbCoSo.SelectedIndex;
                try
                {
                    Program.loginDN = txtTK.Text.ToString();
                    Program.passwordDN = txtMK.Text.ToString();
                    string strLenh = "EXEC SP_DANGNHAP_SV '" + Program.loginDN + "','" + Program.passwordDN + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    Program.username = Program.myReader.GetString(0);
                  
                    if (Convert.IsDBNull(Program.username))
                    {
                        MessageBox.Show("Không có quyền truy cập dữ liệu \n.", "", MessageBoxButtons.OK);
                        return;

                    }
                    Program.mHoten = Program.myReader.GetString(1);
                    Program.mGroup = Program.myReader.GetString(2);
                    Program.MaLopSV = Program.myReader.GetString(3);
                    Program.TenLopSV = Program.myReader.GetString(4);
                }
                catch (Exception)
                {
                    throw;
                }
                Program.myReader.Close();
                Program.conn.Close();
            }
            if (rbtnGV.Checked)
            {
                Program.mlogin = txtTK.Text;
                Program.password = txtMK.Text;
                if (Program.KetNoi() == 0) return;

                Program.mCoso = cmbCoSo.SelectedIndex;

                string strLenh = "EXEC SP_DANGNHAP_GV'" + Program.mlogin + "'";

                Program.loginDN = txtTK.Text.ToString();
                Program.passwordDN = txtMK.Text.ToString();
                try
                {
                    
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    Program.username = Program.myReader.GetString(0);     // Lay user name
                    Program.mHoten = Program.myReader.GetString(1);
                    Program.mGroup = Program.myReader.GetString(2);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi gọi sp đăng nhập giáo viên", "", MessageBoxButtons.OK);
                    throw;
                }
                if (Convert.IsDBNull(Program.mHoten) | Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                    return;
                }

               

                Program.myReader.Close();
                Program.conn.Close();
            }
            Program.frmChinh.hienThiMenu();
            this.Visible = false;
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCoSo.SelectedValue.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoiCSDLGoc() == 0) return;
            LayDSPM("SELECT * FROM V_DS_PHANMANH");

            cmbCoSo.SelectedIndex = 1;
            cmbCoSo.SelectedIndex = 0;
        }

        private void rbtnSV_CheckedChanged(object sender, EventArgs e)
        {
            labelTK.Text = "Sinh Viên";
        }

        private void rbtnGV_CheckedChanged(object sender, EventArgs e)
        {
            labelTK.Text = "Tài khoản";
        }
    }
}
