using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class FormNhapDe : Form
    {
        private DataTable dt = new DataTable();
        private bool themDe = false;
        private int vitri = 0;
        public FormNhapDe()
        {
            InitializeComponent();
        }

        private void FormNhapDe_Load(object sender, EventArgs e)
        {
            //this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            //this.bODETableAdapter.Fill(this.dS.BODE);
            string username = Program.username;
            string query = "SELECT * FROM BODE WHERE MaGV = @username";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet, "BODE");

                this.bODETableAdapter.ClearBeforeFill = false; // Tắt chức năng xóa dữ liệu trước khi điền vào
                this.dS.BODE.Merge(dataSet.Tables["BODE"]);

                // Cập nhật dữ liệu trong BodeTableAdapter
                this.bODETableAdapter.Update(this.dS.BODE);

                // Refresh hiển thị của gcBoDe (GridControl)
                gcBoDe.Refresh();
            }


            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.bAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.bAITHITableAdapter.Fill(this.dS.BAITHI);
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            if (bdsBoDe.Count == 0 || (Program.username != ((DataRowView)bdsBoDe[bdsBoDe.Position])["MAGV"].ToString().Trim() && Program.mGroup == "GIANGVIEN"))
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            tbTenGV.Text = Program.mHoten;
            tbMaGV.Text = Program.username;

            string maMH = ((DataRowView)bdsBoDe[bdsBoDe.Position])["MAMH"].ToString();          
            dt = Program.ExecSqlDataTable("SELECT MAMH,TENMH FROM MONHOC");
            cmbTenMH.DataSource = dt;
            cmbTenMH.DisplayMember = "TENMH";
            cmbTenMH.ValueMember = "MAMH";
            cmbTenMH.SelectedIndex = 0;
            foreach (var item in cmbTenMH.Items)
            {
                if (((DataRowView)item)[cmbTenMH.ValueMember].ToString() == maMH)
                {
                    cmbTenMH.SelectedItem = item;
                    break;
                }
            }

            if (Program.mGroup == "TRUONG")
            {
                btnGhi.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = btnSua.Enabled = btnHuy.Enabled = cmbDapAn.Enabled = false;
                edtA.Enabled = edtB.Enabled = edtC.Enabled = edtD.Enabled = edtNoiDung.Enabled = false;
                edtCauHoi.Enabled = edtMaMH.Enabled = cmbTenMH.Enabled = cmbTrinhDo.Enabled = tbMaGV.Enabled = tbTenGV.Enabled = false;
            }
            else
            {

                edtA.Enabled = edtB.Enabled = edtC.Enabled = edtD.Enabled = edtNoiDung.Enabled = cmbDapAn.Enabled = false;
                btnPhucHoi.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;
                edtCauHoi.Enabled = edtMaMH.Enabled = cmbTenMH.Enabled = cmbTrinhDo.Enabled = tbMaGV.Enabled = tbTenGV.Enabled = false;
                if (bdsBoDe.Count == 0)
                {
                    btnXoa.Enabled = btnSua.Enabled = false;
                }

            }
            

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themDe = true;
            cmbDapAn.Enabled = cmbTenMH.Enabled = cmbTrinhDo.Enabled = true;

            edtA.Enabled = edtB.Enabled = edtC.Enabled = edtD.Enabled = edtNoiDung.Enabled = true;
            bdsBoDe.AddNew();
            ((DataRowView)bdsBoDe[bdsBoDe.Position])["MAGV"] = Program.username; // Mã gv khi đăng nhập vào
            tbTenGV.Text = Program.mHoten; // tên gv tạo đề

            string query = "SELECT MAX(CAUHOI) FROM BODE";
            int maxMaCH = (int)Program.ExecSqlScalar(query);
            int newMaCH = maxMaCH + 1;
            edtCauHoi.Text = newMaCH.ToString();

            dt = Program.ExecSqlDataTable("SELECT MAMH,TENMH FROM MONHOC");
            cmbTenMH.DataSource = dt;
            cmbTenMH.DisplayMember = "TENMH";
            cmbTenMH.ValueMember = "MAMH";
            cmbTenMH.SelectedIndex = 0;


            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");
            cmbTrinhDo.SelectedIndex = 0;

            cmbDapAn.Items.Add("A");
            cmbDapAn.Items.Add("B");
            cmbDapAn.Items.Add("C");
            cmbDapAn.Items.Add("D");
            cmbDapAn.SelectedIndex = 0;


            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gcBoDe.Enabled = false;

        }

        private void cmbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenMH.SelectedItem != null)
            {
                DataRowView selectedRow = cmbTenMH.SelectedItem as DataRowView;
                string tenMH = selectedRow["TENMH"].ToString();
                string maMH = GetMaMHFromTenMH(tenMH); // Hàm này để lấy mã môn học từ tên môn học
                edtMaMH.Text = maMH;
            }
            
        }
        private string GetMaMHFromTenMH(string tenMH)
        {
            string maMH = string.Empty;
            string query = "SELECT MAMH FROM MONHOC WHERE TENMH = @TenMH";
            using (SqlCommand command = new SqlCommand(query, Program.conn))
            {
                command.Parameters.AddWithValue("@TenMH", tenMH);
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    maMH = result.ToString();
                Program.conn.Close();
            }
            return maMH;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (edtNoiDung.Text == "")
            {
                MessageBox.Show("Nội dung không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtNoiDung.Focus();
                return;
            }
            if (edtA.Text == "")
            {
                MessageBox.Show("Đáp án A không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtA.Focus();
                return;
            }
            if (edtB.Text == "")
            {
                MessageBox.Show("Đáp án B không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtB.Focus();
                return;
            }
            if (edtC.Text == "")
            {
                MessageBox.Show("Đáp án C không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtC.Focus();
                return;
            }
            if (edtD.Text == "")
            {
                MessageBox.Show("Đáp án D không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtD.Focus();
                return;
            }
            try
            {

                bdsBoDe.EndEdit();
                bdsBoDe.ResetCurrentItem();
                this.bODETableAdapter.Update(this.dS.BODE);

                if (themDe)
                {
                    MessageBox.Show("Đã thêm câu hỏi thành công", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Đã sửa câu hỏi thành công", "", MessageBoxButtons.OK);
                }
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;     
                btnHuy.Enabled = btnGhi.Enabled = false;
                gcBoDe.Enabled = true;
                pnNhapDe.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi câu hỏi\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void gcBoDe_Click(object sender, EventArgs e)
        {         
            if (bdsBoDe.Count == 0 || Program.mGroup == "TRUONG" || (Program.username != ((DataRowView)bdsBoDe[bdsBoDe.Position])["MAGV"].ToString().Trim() && Program.mGroup == "GIANGVIEN"))
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }

            
            string maMH = ((DataRowView)bdsBoDe[bdsBoDe.Position])["MAMH"].ToString();
            edtMaMH.Text = maMH;

            // Đồng bộ dữ liệu giữa bdsBoDe và cmbTenMH
            bdsBoDe.Position = bdsBoDe.Find("MAMH", maMH);

            string tenMH = (string)Program.ExecSqlScalar("SELECT TENMH FROM MONHOC WHERE MAMH='" + maMH + "'");
            cmbTenMH.Text = tenMH;

        }
        

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbDapAn.Enabled = cmbTenMH.Enabled = cmbTrinhDo.Enabled = true;
            edtA.Enabled = edtB.Enabled = edtC.Enabled = edtD.Enabled = edtNoiDung.Enabled = true;

            vitri = bdsBoDe.Position;

            gcBoDe.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;

            themDe = false;
            string maMH = ((DataRowView)bdsBoDe[bdsBoDe.Position])["MAMH"].ToString();
            dt = Program.ExecSqlDataTable("SELECT MAMH,TENMH FROM MONHOC");
            cmbTenMH.DataSource = dt;
            cmbTenMH.DisplayMember = "TENMH";
            cmbTenMH.ValueMember = "MAMH";
            foreach (var item in cmbTenMH.Items)
            {
                if (((DataRowView)item)[cmbTenMH.ValueMember].ToString() == maMH)
                {
                    cmbTenMH.SelectedItem = item;
                    break;
                }
            }
            //cmbTenMH.SelectedIndex = 0;




            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");
            cmbTrinhDo.SelectedIndex = 0;

            cmbDapAn.Items.Add("A");
            cmbDapAn.Items.Add("B");
            cmbDapAn.Items.Add("C");
            cmbDapAn.Items.Add("D");
            cmbDapAn.SelectedIndex = 0;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBaiThi.Count > 0)
            {
                MessageBox.Show("Câu hỏi " + edtCauHoi.Text + " môn " + cmbTenMH.Text + " đã được sinh viên thi nên không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa câu hỏi: " + edtCauHoi.Text + " môn " + cmbTenMH.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    vitri = bdsBoDe.Position;
                    bdsBoDe.RemoveCurrent();
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.dS.BODE);
                    btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Lỗi xóa giáo viên \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Fill(this.dS.BODE);
                    bdsBoDe.Position = vitri;
                    return;
                }

            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            //this.bODETableAdapter.Fill(this.dS.BODE);
            string username = Program.username;
            string query = "SELECT * FROM BODE WHERE MaGV = @username";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet, "BODE");

                this.bODETableAdapter.ClearBeforeFill = false; // Tắt chức năng xóa dữ liệu trước khi điền vào
                this.dS.BODE.Merge(dataSet.Tables["BODE"]);

                // Cập nhật dữ liệu trong BodeTableAdapter
                this.bODETableAdapter.Update(this.dS.BODE);

                // Refresh hiển thị của gcBoDe (GridControl)
                gcBoDe.Refresh();
            }

            DataView dataView = new DataView(this.dS.BODE);
            dataView.RowFilter = "MAGV = '" + Program.username + "'";

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.bAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.bAITHITableAdapter.Fill(this.dS.BAITHI);
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            if (bdsBoDe.Count == 0 || (Program.username != ((DataRowView)bdsBoDe[bdsBoDe.Position])["MAGV"].ToString().Trim() && Program.mGroup == "GIANGVIEN"))
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            
            if (Program.mGroup == "TRUONG")
            {
                btnGhi.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = btnSua.Enabled = btnHuy.Enabled = cmbDapAn.Enabled = false;
                edtA.Enabled = edtB.Enabled = edtC.Enabled = edtD.Enabled = edtNoiDung.Enabled = false;
                edtCauHoi.Enabled = edtMaMH.Enabled = cmbTenMH.Enabled = cmbTrinhDo.Enabled = tbMaGV.Enabled = tbTenGV.Enabled = false;
            }
            else
            {

                edtA.Enabled = edtB.Enabled = edtC.Enabled = edtD.Enabled = edtNoiDung.Enabled = cmbDapAn.Enabled = false;
                btnPhucHoi.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;
                edtCauHoi.Enabled = edtMaMH.Enabled = cmbTenMH.Enabled = cmbTrinhDo.Enabled = tbMaGV.Enabled = tbTenGV.Enabled = false;
                if (bdsBoDe.Count == 0)
                {
                    btnXoa.Enabled = btnSua.Enabled = false;
                }

            }
           
            tbTenGV.Text = Program.mHoten;
            tbMaGV.Text = Program.username;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edtA.Enabled = edtB.Enabled = edtC.Enabled = edtD.Enabled = edtNoiDung.Enabled = false;
            cmbDapAn.Enabled = cmbTenMH.Enabled = cmbTrinhDo.Enabled = false;
            if (themDe) 
                bdsBoDe.RemoveCurrent(); 
            else bdsBoDe.CancelEdit();

            bdsBoDe.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnReload.Enabled = btnThoat.Enabled = true;

            gcBoDe.Enabled = true;
            

            if ((btnThem.Enabled == false) || (btnSua.Enabled == false))
            {
                btnHuy.Enabled = true;
                btnGhi.Enabled = true;
            }
            else
            {
                btnHuy.Enabled = false;
                btnGhi.Enabled = false;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }   
    }
}
