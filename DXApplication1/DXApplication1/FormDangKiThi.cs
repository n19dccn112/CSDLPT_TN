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
    public partial class FormDangKiThi : Form
    {
        private int vitri;
        Boolean dangThem;
        private DataTable dt = new DataTable();
        public FormDangKiThi()
        {
            InitializeComponent();
        }

        private void FormDangKiThi_Load(object sender, EventArgs e)
        {
            
            

            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.cOSOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cOSOTableAdapter.Fill(this.dS.COSO);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            if (Program.mGroup == "TRUONG")
            {

                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnHoantac.Enabled = false;
                btnHuy.Enabled = false;
                pnGVDK.Enabled = false;
                gcGVDK.Enabled = true;
            }
            else
            {
                cmbCoSo.Enabled = false;
                btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnPhucHoi.Enabled = btnGhi.Enabled = btnHuy.Enabled = false;
                pnGVDK.Enabled = false;
                gcGVDK.Enabled = true;
                if (bdsGVDK.Count == 0
                || (Program.username != ((DataRowView)bdsGVDK[bdsGVDK.Position])["MAGV"].ToString().Trim() && Program.mGroup == "GIANGVIEN"))
                {
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGVDK.Position;
            bdsGVDK.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            pnGVDK.Enabled = true;
            gcGVDK.Enabled = gcLop.Enabled = gcMonHoc.Enabled = false;

            btnReload.Enabled = false;

            dt = Program.ExecSqlDataTable("SELECT MAGV,HO,TEN FROM GIAOVIEN");
            cmbTenGV.DataSource = dt;
            cmbTenGV.DisplayMember = "TEN";
            cmbTenGV.ValueMember = "MAGV";
            cmbTenGV.SelectedIndex = 0;
            //txtMaGV.Text = Program.username;
            //txtMaGV.Enabled = false;
            string maMH = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
            edtMaMH.Text = maMH;

            string maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            edtMaLop.Text = maLop;

            cmbLanThi.Items.Add("1");
            cmbLanThi.Items.Add("2");
            cmbLanThi.Items.Add("3");
            cmbLanThi.SelectedIndex = 0;

            cmbSoCauThi.Items.Add("20");
            cmbSoCauThi.Items.Add("30");
            cmbSoCauThi.Items.Add("40");
            cmbSoCauThi.Items.Add("50");
            cmbSoCauThi.Items.Add("60");
            cmbSoCauThi.SelectedIndex = 0;

            cmbThoiGian.Items.Add("15");
            cmbThoiGian.Items.Add("20");
            cmbThoiGian.Items.Add("30");
            cmbThoiGian.Items.Add("50");
            cmbThoiGian.Items.Add("60");
            cmbThoiGian.SelectedIndex = 0;

            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");
            cmbTrinhDo.SelectedIndex = 0;

            dangThem = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGVDK.Position;
            
            pnGVDK.Enabled = true;
            gcGVDK.Enabled = gcLop.Enabled = gcMonHoc.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            //txtMaGV.Enabled = false;
            dangThem = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DateTime.Compare(DateTime.Parse(dtNgayThi.Text.ToString()),
                 DateTime.Parse(DateTime.Now.ToShortDateString())) < 0)
            {
                MessageBox.Show("Lịch thi đã thi không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Lịch thi này ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    vitri = bdsGVDK.Position;
                    
                    bdsGVDK.RemoveCurrent();
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                    btnPhucHoi.Enabled = true;
                }
                catch (Exception ex)
                {                  
                    MessageBox.Show("Lỗi xóa Lịch thi \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                    bdsGVDK.Position = vitri;
                    return;
                }

            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThem) bdsGVDK.RemoveCurrent(); else bdsGVDK.CancelEdit();
            if (dangThem == false) bdsGVDK.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnReload.Enabled = btnThoat.Enabled = true;

            pnGVDK.Enabled = false;
            gcGVDK.Enabled = gcLop.Enabled = gcMonHoc.Enabled = true ;
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

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (edtMaMH.Text == "")
            {
                MessageBox.Show("Mã Môn học không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtMaMH.Focus();
                return;
            }
            if (edtMaLop.Text == "")
            {
                MessageBox.Show("Mã Lớp không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtMaLop.Focus();
                return;
            }
            if (cmbSoCauThi.Text == "")
            {
                MessageBox.Show("Số câu thi không được trống!", "Lỗi", MessageBoxButtons.OK);
                cmbSoCauThi.Focus();
                return;
            }
            if (cmbTrinhDo.Text == "")
            {
                MessageBox.Show("Trình độ không được trống!", "Lỗi", MessageBoxButtons.OK);
                cmbTrinhDo.Focus();
                return;
            }
            if (dtNgayThi.Text == "")
            {
                MessageBox.Show("Ngày thi không được trống!", "Lỗi", MessageBoxButtons.OK);
                dtNgayThi.Focus();
                return;
            }
            if (cmbLanThi.Text == "")
            {
                MessageBox.Show("Lần thi không được trống!", "Lỗi", MessageBoxButtons.OK);
                cmbLanThi.Focus();
                return;
            }
            if (cmbThoiGian.Text == "")
            {
                MessageBox.Show("Thời gian không được trống!", "Lỗi", MessageBoxButtons.OK);
                cmbThoiGian.Focus();
                return;
            }


            if (DateTime.Compare(DateTime.Parse(dtNgayThi.Text.ToString()),
                DateTime.Parse(DateTime.Now.ToShortDateString())) < 0)
            {
                MessageBox.Show("Ngày thi phải lớn hơn hoặc bằng ngày hiện tại!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            try
            {

                if (dangThem)
                {

                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_ChuanBiThi] '" + edtMaMH.Text + "','" + edtMaLop.Text
                        + "','" + cmbTrinhDo.Text.Trim() + "','" + cmbSoCauThi.Text.Trim() + "','" + cmbLanThi.Text.Trim() + "','" + dtNgayThi.Text.ToString() + "'") == 1)
                    {
                        edtMaMH.Focus();
                        return;
                    }
                }

                bdsGVDK.EndEdit();
                bdsGVDK.ResetCurrentItem();
                this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                if (dangThem)
                {
                    MessageBox.Show("Đã thêm thành công", "", MessageBoxButtons.OK);
                    
                }
                else
                {
                    MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                }
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnHuy.Enabled = btnGhi.Enabled = false;
                pnGVDK.Enabled = false;
                gcGVDK.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void gcGVDK_Click(object sender, EventArgs e)
        {
            if (bdsGVDK.Count == 0 || Program.mGroup == "TRUONG"
                || (Program.username != ((DataRowView)bdsGVDK[bdsGVDK.Position])["MAGV"].ToString().Trim() && Program.mGroup == "GIANGVIEN"))
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            colMAMH.ColumnEditName = edtMaMH.Text;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            if (bdsGVDK.Count == 0 || Program.mGroup == "TRUONG"
                || (Program.username != ((DataRowView)bdsGVDK[bdsGVDK.Position])["MAGV"].ToString().Trim() && Program.mGroup == "GIANGVIEN"))
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            }
        }
        //private void cmbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbTenMH.SelectedItem != null)
        //    {
        //        DataRowView selectedRow = cmbTenMH.SelectedItem as DataRowView;
        //        string tenMH = selectedRow["TENMH"].ToString();
        //        string maMH = GetMaMHFromTenMH(tenMH); // Hàm này để lấy mã môn học từ tên môn học
        //        edtMaMH.Text = maMH;
        //    }
        //}
        //private string GetMaMHFromTenMH(string tenMH)
        //{
        //    string maMH = string.Empty;
        //    string query = "SELECT MAMH FROM MONHOC WHERE TENMH = @TenMH";
        //    using (SqlCommand command = new SqlCommand(query, Program.conn))
        //    {
        //        command.Parameters.AddWithValue("@TenMH", tenMH);
        //        if (Program.conn.State == ConnectionState.Closed)
        //            Program.conn.Open();
        //        object result = command.ExecuteScalar();
        //        if (result != null)
        //            maMH = result.ToString();
        //        Program.conn.Close();
        //    }
        //    return maMH;
        //}

        private void cmbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenGV.SelectedItem != null)
            {
                DataRowView selectedRow = cmbTenGV.SelectedItem as DataRowView;
                string maGV = selectedRow["MAGV"].ToString();
                edtMaGV.Text = maGV;
            }
        }
        
    }
}
