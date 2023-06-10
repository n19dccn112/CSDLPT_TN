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
    public partial class FormSinhVien : Form
    {
        private int vitri;
        bool themSV = false;
        bool suaSV = false;
        public FormSinhVien()
        {
            InitializeComponent();
        }
        private void PhanQuyen()
        {
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = false;
                pnSV.Enabled = false;
                gcSV.Enabled = gcLop.Enabled = true;
            }
            else
           if (Program.mGroup == "GIANGVIEN")
            {

                cmbCoSo.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;

                btnHuy.Enabled = false;
                pnSV.Enabled = false;
                gcSV.Enabled = gcLop.Enabled = true;
            }
            else//CS
            {
                //cmbCoSo.Enabled = false;
                btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnPhucHoi.Enabled = btnGhi.Enabled = btnHuy.Enabled = false;
                pnSV.Enabled = false;
                gcSV.Enabled = gcLop.Enabled = true;
                cmbCoSo.Enabled = false;
                //if (bdsSV.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
            }
        }
        private void FormSinhVien_Load(object sender, EventArgs e)
        {



            dS.EnforceConstraints = false;


            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            PhanQuyen();

            themSV = false;
            suaSV = false;

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            Program.servername = cmbCoSo.SelectedValue.ToString();

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSV.Position;
            bdsSV.AddNew();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            pnSV.Enabled = true;
            gcSV.Enabled = gcLop.Enabled = false;
            edtDiaChi.Enabled = edtHo.Enabled = edtTen.Enabled = dtNgaySinh.Enabled = edtMaSV.Enabled = edtMatKhau.Enabled = true;
            edtMaLop.Text = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            edtMaLop.Enabled = false;
            themSV = true;
            suaSV = false;

            //lấy mã sinh viên tăng tự động
            string query = "SELECT MAX(MASV) FROM SINHVIEN";
            string maxMaSV = Program.ExecSqlScalar(query) as string;

            // Tạo mã sinh viên mới
            string newMaSV = "";
            if (!string.IsNullOrEmpty(maxMaSV))
            {
                int maxMaSVNumber = int.Parse(maxMaSV);
                int newMaSVNumber = maxMaSVNumber + 1;
                newMaSV = newMaSVNumber.ToString("D3"); // Định dạng mã sinh viên mới
            }
            else
            {
                newMaSV = "001"; // Nếu chưa có sinh viên, bắt đầu từ mã số 001
            }

            // Gán mã sinh viên mới cho sinh viên được thêm
            edtMaSV.Text = newMaSV;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSV.Position;
            pnSV.Enabled = true;
            gcLop.Enabled = false;
            gcSV.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            edtMaSV.Enabled = edtMatKhau.Enabled = false;
            themSV = false;
            suaSV = true;
            cmbCoSo.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (themSV) bdsSV.RemoveCurrent(); else bdsSV.CancelEdit();
            if (themSV == false) bdsSV.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnReload.Enabled = btnThoat.Enabled = true;

            pnSV.Enabled = false;
            gcSV.Enabled = gcLop.Enabled = true;
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

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);

            this.cOSOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cOSOTableAdapter.Fill(this.dS.COSO);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Sinh viên " + edtHo.Text + " " + edtTen.Text + " đang có điểm không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Sinh viên: " + edtHo.Text + " " + edtTen.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    vitri = bdsSV.Position;
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa Sinh viên \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    bdsSV.Position = vitri;
                    return;
                }

            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (edtMaSV.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtMaSV.Focus();
                return;
            }
            if (edtHo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Họ sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtHo.Focus();
                return;
            }
            if (edtTen.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Tên sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtTen.Focus();
                return;
            }
            if (edtMatKhau.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được trống! ", "", MessageBoxButtons.OK);
                edtMatKhau.Focus();
                return;
            }
            if (dtNgaySinh.Text != "")
                if (DateTime.Compare(DateTime.Parse(dtNgaySinh.Text.ToString()),
                     DateTime.Parse(DateTime.Now.ToShortDateString())) > 0)
                {
                    MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại!", "Lỗi ngày sinh", MessageBoxButtons.OK);
                    return;
                }
            try
            {

                if (themSV)
                {

                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckMaSV] '" + edtMaSV.Text + "'") == 1)
                    {
                        edtMaSV.Focus();

                        return;
                    }
                    ((DataRowView)bdsSV[bdsSV.Position])["MATKHAU"] = edtMatKhau.Text;
                }

                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                if (themSV)
                {
                    MessageBox.Show("Đã thêm Sinh viên thành công", "", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Đã sửa Sinh viên thành công", "", MessageBoxButtons.OK);
                }


                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnHuy.Enabled = btnGhi.Enabled = false;
                pnSV.Enabled = false;
                gcSV.Enabled = gcLop.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void gcLop_Click(object sender, EventArgs e)
        {
            if (bdsSV.Count == 0 || Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN")
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
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
 
            }
        }

        private void edtMaSV_EditValueChanged(object sender, EventArgs e)
        {
            edtMatKhau.Text = edtMaSV.Text;
        }
    }
}
