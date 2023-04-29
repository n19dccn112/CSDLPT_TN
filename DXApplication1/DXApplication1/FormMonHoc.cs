using System;
using System.Collections;
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
    public partial class FormMonHoc : Form
    {
        private int vitri;
        Boolean add;

        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {  
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
           
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);

            if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            if (Program.mGroup == "GIANGVIEN")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
            }
            else//CS
            {
                btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnPhucHoi.Enabled = btnGhi.Enabled = btnHuy.Enabled = false;
                if (bdsMH.Count == 0)
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
            vitri = bdsMH.Position;
            gbMonHoc.Enabled = true;
            txtMaMH.Enabled = false;
            bdsMH.AddNew(); //them sp mới vào ds

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = BtnHoanTac.Enabled = true;
            
            gcMH.Enabled = false;
            add = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBODE.Count != 0)
            {
                MessageBox.Show("Môn học đã có câu hỏi trong bộ đề, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else if (bdsGVDK.Count != 0)
            {
                MessageBox.Show("Môn học đã có giáo viên đăng ký thi, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else if (bdsBANGDIEM.Count != 0)
            {
                MessageBox.Show("Môn học đã có bảng điểm, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            if (MessageBox.Show("Bạn có muốn xóa Môn học: " + txtTenMH.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    vitri = bdsMH.Position;
                   // UndoStack.Push("exec[dbo].[SP_UndoXoaMH] '" + txtMaMH.Text + "', N'"
                   //     + txtTen.Text + "'");
                    bdsMH.RemoveCurrent();//xóa trên máy ht trc mới xóa trên data
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                    btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {
                    //UndoStack.Pop();
                    MessageBox.Show("Lỗi xóa Môn học \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    bdsMH.Position = vitri;
                    return;
                }

            }
            if (bdsMH.Count == 0)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMH.Position;
            // UndoStack.Push("exec[dbo].[SP_UndoSuaMH] '" + txtMaMH.Text + "', N'"
            //   + txtTen.Text + "'");
            txtMaMH.Enabled = false;
            gbMonHoc.Enabled = true;
            gcMH.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = BtnHoanTac.Enabled = true;
            add = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenMH.Text == "")
            {
                MessageBox.Show("Tên Môn học không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return;
            }

            try
            {
                if (add)
                {
                    string sql = "exec [dbo].[SP_ThemMAMH] @TENMH";
                    Hashtable paras = new Hashtable();
                    paras.Add("@TENMH", txtTenMH.Text);
                    DataTable dt = new DataTable();
                    dt = Program.ExecSqlDataTable(sql, paras);
                    txtMaMH.Text = dt.Rows[0][0].ToString();
                }
                if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckTenMH] N'" + txtTenMH.Text + "'") != 0)
                {
                    txtTenMH.Focus();
                    return;
                }
                // Xác nhận quá trình thay đổi dữ liệu đã kết thúc 
                // nếu 0 dùng dữ liệu lưu có thể khác dữ liệu hiện
                bdsMH.EndEdit();
                // cập nhật lại dữ liệu đang được hiển thị
                bdsMH.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.dS.MONHOC);

                if (add)
                {
                    MessageBox.Show("Đã thêm Môn học thành công", "", MessageBoxButtons.OK);
                   // UndoStack.Push("exec [dbo].[SP_UndoThemMH] '" + txtMaMH.Text + "'");
                }
                else
                {
                    MessageBox.Show("Đã sửa Môn học thành công", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Môn học\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnHuy.Enabled = btnGhi.Enabled = false;
            gbMonHoc.Enabled = false;
            gcMH.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void BtnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            if (bdsMH.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (add) bdsMH.RemoveCurrent(); else bdsMH.CancelEdit();
            if (add == false) bdsMH.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnReload.Enabled = btnThoat.Enabled = true;

            gbMonHoc.Enabled = false;
            gcMH.Enabled = true;
            //if (UndoStack.Count > 0) { UndoStack.Pop(); btnPhucHoi.Enabled = true; }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void gcMH_Click(object sender, EventArgs e)
        {
            if (bdsMH.Count == 0 || Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN")
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
}
