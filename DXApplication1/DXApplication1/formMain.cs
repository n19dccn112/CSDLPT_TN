using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
            btnMH.Enabled = btnKhoaLop.Enabled = btnDangKiThi.Enabled = btnThi.Enabled = btnSinhVien.Enabled = btnGiaoVien.Enabled = btnNhapDe.Enabled = false;
            barBtnTaoTaiKhoan.Enabled = barBtnDangXuat.Enabled = false;
        }
        public void hienThiMenu()
        {
            lableMa.Text = "Mã: " + Program.username;
            labelTenDN.Text = "Tên: " + Program.mHoten;
            labelNhom.Text = "Nhóm: " + Program.mGroup;

            //Đăng xuất
            ribnBaoCao.Visible = false;
            ribnHeThong.Visible = true;
            barBtnDangNhap.Enabled = true;
            barBtnTaoTaiKhoan.Enabled = barBtnDangXuat.Enabled = false;

            //Đăng nhập
            if (Program.mGroup == "SinhVien")
            {
                //MessageBox.Show("sinh viên");
                barBtnDangNhap.Enabled = barBtnTaoTaiKhoan.Enabled = false;
                barBtnDangXuat.Enabled = true;
                ribnDanhMuc.Visible = ribnBaoCao.Visible = true;
                btnMH.Enabled = btnKhoaLop.Enabled =  btnSinhVien.Enabled = btnGiaoVien.Enabled  = btnNhapDe.Enabled = btnDangKiThi.Enabled = false;
                btnThi.Enabled =  true;
            }
            else if (Program.mGroup == "GIANGVIEN")
            {
                barBtnDangNhap.Enabled = barBtnTaoTaiKhoan.Enabled = false;
                barBtnDangXuat.Enabled = true;
                ribnDanhMuc.Visible = ribnBaoCao.Visible = true;
                //btnMH.Enabled = btnKhoaLop.Enabled = btnThi.Enabled = true;
                btnMH.Enabled =   btnKhoaLop.Enabled = btnSinhVien.Enabled = btnGiaoVien.Enabled = false;
                btnThi.Enabled = btnNhapDe.Enabled = btnDangKiThi.Enabled = true;

            }
            else if (Program.mGroup == "TRUONG")
            {
                barBtnDangNhap.Enabled = false;
                barBtnDangXuat.Enabled = barBtnTaoTaiKhoan.Enabled = true;
                ribnDanhMuc.Visible = ribnBaoCao.Visible = true;
                btnMH.Enabled = btnKhoaLop.Enabled = btnThi.Enabled = btnSinhVien.Enabled = btnGiaoVien.Enabled = btnNhapDe.Enabled = btnDangKiThi.Enabled = true;
            }
            else if (Program.mGroup == "COSO")
            {
                barBtnDangNhap.Enabled = false;
                barBtnDangXuat.Enabled = barBtnTaoTaiKhoan.Enabled = true;
                ribnDanhMuc.Visible = ribnBaoCao.Visible = true;
                btnMH.Enabled = btnKhoaLop.Enabled = btnThi.Enabled = btnSinhVien.Enabled = btnGiaoVien.Enabled = btnNhapDe.Enabled = btnDangKiThi.Enabled = true;
              
            }
            if (Program.mCoso == 2)
            {
                barBtnDangNhap.Enabled = barBtnTaoTaiKhoan.Enabled = false;
                barBtnDangXuat.Enabled = true;
                ribnDanhMuc.Visible =  true;
                btnMH.Enabled = btnThi.Enabled = btnKhoaLop.Enabled  = btnSinhVien.Enabled = btnGiaoVien.Enabled = btnNhapDe.Enabled = btnDangKiThi.Enabled = false;
                btnSinhVien.Enabled = btnKhoaLop.Enabled = true;
                ribnBaoCao.Visible = false;

            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barBtnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                formDangNhap f = new formDangNhap();
                f.MdiParent = this;
                f.Show();
                Program.dangXuat = false;
            }
        }
        private void barBtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "CẢNH BÁO", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Program.username = "";
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;

                Program.loginDN = Program.remoteLogin;
                Program.passwordDN = Program.remoteLogin;

                Program.mGroup = "";
                Program.mHoten = "";
                Program.dangXuat = true;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.ShowInTaskbar)
                        frm.Close();
                }
                
                Program.frmChinh.hienThiMenu();
            }
        }

        private void btnMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FormMonHoc f = new FormMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(KhoaLop));
            if (frm != null) frm.Activate();
            else
            {
                KhoaLop f = new KhoaLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormThi));
            if (frm != null) frm.Activate();
            else
            {
                FormThi f = new FormThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barBtnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                FormTaoTaiKhoan f = new FormTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }
        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormXtraReportXemLaiBaiThi));
            if (frm != null) frm.Activate();
            else
            {
                FormXtraReportXemLaiBaiThi f = new FormXtraReportXemLaiBaiThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                FormSinhVien f = new FormSinhVien();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormGiaoVien));
            if (frm != null) frm.Activate();
            else
            {
                FormGiaoVien f = new FormGiaoVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNhapDe));
            if (frm != null) frm.Activate();
            else
            {
                FormNhapDe f = new FormNhapDe();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnDangKiThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangKiThi));
            if (frm != null) frm.Activate();
            else
            {
                FormDangKiThi f = new FormDangKiThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemDSDKThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormXtraReportXemDSDKThi));
            if (frm != null) frm.Activate();
            else
            {
                FormXtraReportXemDSDKThi f = new FormXtraReportXemDSDKThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormXtraReportXemBangDiem));
            if (frm != null) frm.Activate();
            else
            {
                FormXtraReportXemBangDiem f = new FormXtraReportXemBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
