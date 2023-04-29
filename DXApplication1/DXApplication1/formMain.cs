﻿using System;
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
            btnMH.Enabled = btnKhoaLop.Enabled = false;
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
            barBtnDangXuat.Enabled = true;
            barBtnTaoTaiKhoan.Enabled = barBtnDangNhap.Enabled = false;

            //Đăng nhập
            if (Program.mGroup == "SINHVIEN")
            {
                MessageBox.Show("sinh viên");
                barBtnDangNhap.Enabled = barBtnTaoTaiKhoan.Enabled = false;
                barBtnDangXuat.Enabled = true;
                ribnDanhMuc.Visible = true;
                ribnBaoCao.Visible = false;
            }
            else if (Program.mGroup == "GIANGVIEN")
            {
                barBtnDangNhap.Enabled = barBtnTaoTaiKhoan.Enabled = false;
                barBtnDangXuat.Enabled = true;
                ribnDanhMuc.Visible = ribnBaoCao.Visible = true;
                btnMH.Enabled = btnKhoaLop.Enabled = true;
            }
            else if (Program.mGroup == "TRUONG")
            {
                barBtnDangNhap.Enabled = false;
                barBtnDangXuat.Enabled = barBtnTaoTaiKhoan.Enabled = true;
                ribnDanhMuc.Visible = ribnBaoCao.Visible = true;
                btnMH.Enabled = btnKhoaLop.Enabled = true;
            }
            else if (Program.mGroup == "COSO")
            {
                barBtnDangNhap.Enabled = false;
                barBtnDangXuat.Enabled = barBtnTaoTaiKhoan.Enabled = true;
                ribnDanhMuc.Visible = ribnBaoCao.Visible = true;
                btnMH.Enabled = btnKhoaLop.Enabled = true;
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

                Program.loginDN = Program.remoteLogin;
                Program.passwordDN = Program.remoteLogin;

                Program.mGroup = "";
                Program.mHoten = "";
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
            Form frm = this.CheckExists(typeof(FormLopVKhoa));
            if (frm != null) frm.Activate();
            else
            {
                FormLopVKhoa f = new FormLopVKhoa();
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
    }
}
