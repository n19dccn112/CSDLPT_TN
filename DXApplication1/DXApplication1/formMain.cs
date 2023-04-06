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
        }
        public void hienThiMenu()
        {
            lableMa.Text = "Mã: " + Program.username;
            labelTenDN.Text = "Tên: " + Program.mHoten;
            labelNhom.Text = "Nhóm: " + Program.mGroup;
            ribnHeThong.Visible = true;
            barBtnTaoTaiKhoan.Enabled = false;
            barBtnDangNhap.Enabled = false;

            if (Program.mGroup == "SINHVIEN")
            {
                barBtnDangNhap.Enabled = false;
                barBtnDangXuat.Enabled = true;
                ribnDanhMuc.Visible = false;
                ribnBaoCao.Visible = false;
                barBtnTaoTaiKhoan.Enabled = false;
            }
            else if (Program.mGroup == "GIANGVIEN")
            {
                barBtnDangNhap.Enabled = false;
                barBtnDangXuat.Enabled = true;
                ribnDanhMuc.Visible = true;
                ribnBaoCao.Visible = true;
                barBtnTaoTaiKhoan.Enabled = false;
                barBtnDangXuat.Enabled = true;
            }
            else if (Program.mGroup == "TRUONG")
            {
                barBtnDangNhap.Enabled = false;
                barBtnDangXuat.Enabled = true;
                ribnDanhMuc.Visible = true;
                ribnBaoCao.Visible = true;
                barBtnTaoTaiKhoan.Enabled = true;

            }
            if (Program.mGroup == "COSO")
            {
                barBtnDangNhap.Enabled = false;
                barBtnDangXuat.Enabled = true;
                ribnDanhMuc.Visible = true;
                ribnBaoCao.Visible = true;
                barBtnTaoTaiKhoan.Enabled = true;
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
                Program.mGroup = "";
                Program.mHoten = "";
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.ShowInTaskbar)
                        frm.Close();
                }
                Program.frmChinh.hienThiMenu();
                barBtnDangNhap.Enabled = true;
            }
        }
    }
}
