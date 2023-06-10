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
    public partial class FormGiaoVien : Form
    {

        bool themGV = false;
        bool suaGV = false;
        private int vitri = 0;
        public FormGiaoVien()
        {
            InitializeComponent();
        }


        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            
            
            dS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            //Phân quyền
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                btnGhi.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = btnSua.Enabled = btnHuy.Enabled = false;
                edtMaGV.Enabled = edtDiaChi.Enabled = edtHo.Enabled = edtTen.Enabled  = edtMaKhoa.Enabled = false;

            }
            if (Program.mGroup == "GIANGVIEN")
            {

                cmbCoSo.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
                pnGV.Enabled = false;
                gcGV.Enabled = true;
            }
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                edtMaGV.Enabled = edtDiaChi.Enabled = edtHo.Enabled = edtTen.Enabled = edtMaKhoa.Enabled = false;
                btnPhucHoi.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;
                if (bdsGV.Count == 0)
                {
                    btnXoa.Enabled = btnSua.Enabled = false;
                }

            }
            if (bdsGV.Count == 0 || Program.mGroup == "TRUONG")
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

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edtMaGV.Enabled = edtDiaChi.Enabled = edtHo.Enabled = edtTen.Enabled = true;
            edtMaKhoa.Enabled = false;
            bdsGV.AddNew();
            edtMaKhoa.Text = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            pnGV.Enabled = true;
            gcGV.Enabled = gcKhoa.Enabled = false;
            btnReload.Enabled = false;
            themGV = true;
            suaGV = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edtMaGV.Enabled = edtDiaChi.Enabled = edtHo.Enabled = edtTen.Enabled = true;
            vitri = bdsGV.Position;
            pnGV.Enabled = true;
            gcKhoa.Enabled = false;
            gcGV.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            edtMaGV.Enabled = false;
            themGV = false;
            suaGV = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edtMaGV.Enabled = edtDiaChi.Enabled = edtHo.Enabled = edtMaKhoa.Enabled = edtTen.Enabled  = false;

            if (themGV) bdsGV.RemoveCurrent(); else bdsGV.CancelEdit();
            bdsGV.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnReload.Enabled = btnThoat.Enabled = true;

            //pnGv.Enabled = false;
            gcGV.Enabled = gcKhoa.Enabled = true;

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
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            edtMaGV.Enabled = edtDiaChi.Enabled = edtHo.Enabled = edtMaKhoa.Enabled = edtTen.Enabled = false;
            if (bdsGV.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
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
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Giáo viên " + edtHo.Text + " " + edtTen.Text + " đã đăng kí thi nên không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsBoDe.Count > 0)
            {
                MessageBox.Show("Giáo viên " + edtHo.Text + " " + edtTen.Text + " đã soạn đề thi nên không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Giáo viên: " + edtHo.Text + " " + edtTen.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    vitri = bdsGV.Position;
                    bdsGV.RemoveCurrent();
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                    btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Lỗi xóa giáo viên \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                    bdsGV.Position = vitri;
                    return;
                }

            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edtMaGV.Enabled = edtDiaChi.Enabled = edtHo.Enabled = edtTen.Enabled = edtMaKhoa.Enabled= false;
            if (edtMaGV.Text == "")
            {
                MessageBox.Show("Mã giáo viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtMaGV.Focus();
                return;
            }
            if (edtHo.Text == "")
            {
                MessageBox.Show("Họ giáo viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtHo.Focus();
                return;
            }
            if (edtTen.Text == "")
            {
                MessageBox.Show("Họ giáo viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtTen.Focus();
                return;
            }
            try
            {

                if (themGV)
                {

                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckMaGV] '" + edtMaGV.Text + "'") == 1)
                    {
                        edtMaGV.Focus();
                        edtMaGV.Enabled = edtDiaChi.Enabled = edtHo.Enabled = edtTen.Enabled = true;
                        return;
                    }
                }

                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                if (themGV)
                {
                    MessageBox.Show("Đã thêm Giáo viên thành công", "", MessageBoxButtons.OK);
                    
                }
                else
                {
                    MessageBox.Show("Đã sửa Giáo viên thành công", "", MessageBoxButtons.OK);
                }
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnHuy.Enabled = btnGhi.Enabled = false;
                //pnGv.Enabled = false;
                gcGV.Enabled = gcKhoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giáo viên\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void gcKhoa_Click(object sender, EventArgs e)
        {
            if (bdsGV.Count == 0 || Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN")
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
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dS.KHOA);
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
            }
        }
    }
}
