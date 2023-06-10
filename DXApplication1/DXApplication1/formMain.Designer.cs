
namespace DXApplication1
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoaLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnThi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiaoVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapDe = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKiThi = new DevExpress.XtraBars.BarButtonItem();
            this.ribnHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribnHeThongCon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribnDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribnBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lableMa = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTenDN = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelNhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtnDangNhap,
            this.barBtnTaoTaiKhoan,
            this.barBtnDangXuat,
            this.btnMH,
            this.btnKhoaLop,
            this.btnThi,
            this.barButtonItem1,
            this.btnSinhVien,
            this.btnGiaoVien,
            this.btnNhapDe,
            this.btnDangKiThi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(22);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribnHeThong,
            this.ribnDanhMuc,
            this.ribnBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(1516, 308);
            // 
            // barBtnDangNhap
            // 
            this.barBtnDangNhap.Caption = "Đăng nhập";
            this.barBtnDangNhap.Id = 1;
            this.barBtnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDangNhap.ImageOptions.Image")));
            this.barBtnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDangNhap.ImageOptions.LargeImage")));
            this.barBtnDangNhap.Name = "barBtnDangNhap";
            this.barBtnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDangNhap_ItemClick);
            // 
            // barBtnTaoTaiKhoan
            // 
            this.barBtnTaoTaiKhoan.Caption = "Tài khoản";
            this.barBtnTaoTaiKhoan.Id = 2;
            this.barBtnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnTaoTaiKhoan.ImageOptions.Image")));
            this.barBtnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.barBtnTaoTaiKhoan.Name = "barBtnTaoTaiKhoan";
            this.barBtnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTaoTaiKhoan_ItemClick);
            // 
            // barBtnDangXuat
            // 
            this.barBtnDangXuat.Caption = "Đăng xuất";
            this.barBtnDangXuat.Id = 3;
            this.barBtnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDangXuat.ImageOptions.Image")));
            this.barBtnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDangXuat.ImageOptions.LargeImage")));
            this.barBtnDangXuat.Name = "barBtnDangXuat";
            this.barBtnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDangXuat_ItemClick);
            // 
            // btnMH
            // 
            this.btnMH.Caption = "Môn Học";
            this.btnMH.Id = 4;
            this.btnMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMH.ImageOptions.Image")));
            this.btnMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMH.ImageOptions.LargeImage")));
            this.btnMH.Name = "btnMH";
            this.btnMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMH_ItemClick);
            // 
            // btnKhoaLop
            // 
            this.btnKhoaLop.Caption = "Khoa + Lớp";
            this.btnKhoaLop.Id = 5;
            this.btnKhoaLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoaLop.ImageOptions.Image")));
            this.btnKhoaLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhoaLop.ImageOptions.LargeImage")));
            this.btnKhoaLop.Name = "btnKhoaLop";
            this.btnKhoaLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnThi
            // 
            this.btnThi.Caption = "Thi";
            this.btnThi.Id = 8;
            this.btnThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThi.ImageOptions.Image")));
            this.btnThi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThi.ImageOptions.LargeImage")));
            this.btnThi.Name = "btnThi";
            this.btnThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThi_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Bài thi";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh Viên";
            this.btnSinhVien.Id = 10;
            this.btnSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.Image")));
            this.btnSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.LargeImage")));
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Caption = "Giáo Viên";
            this.btnGiaoVien.Id = 11;
            this.btnGiaoVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.ImageOptions.Image")));
            this.btnGiaoVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.ImageOptions.LargeImage")));
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiaoVien_ItemClick);
            // 
            // btnNhapDe
            // 
            this.btnNhapDe.Caption = "Nhập Đề";
            this.btnNhapDe.Id = 12;
            this.btnNhapDe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDe.ImageOptions.Image")));
            this.btnNhapDe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhapDe.ImageOptions.LargeImage")));
            this.btnNhapDe.Name = "btnNhapDe";
            this.btnNhapDe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapDe_ItemClick);
            // 
            // btnDangKiThi
            // 
            this.btnDangKiThi.Caption = "Đăng Kí Thi";
            this.btnDangKiThi.Id = 13;
            this.btnDangKiThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKiThi.ImageOptions.Image")));
            this.btnDangKiThi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangKiThi.ImageOptions.LargeImage")));
            this.btnDangKiThi.Name = "btnDangKiThi";
            this.btnDangKiThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKiThi_ItemClick);
            // 
            // ribnHeThong
            // 
            this.ribnHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribnHeThongCon});
            this.ribnHeThong.Name = "ribnHeThong";
            this.ribnHeThong.Text = "Hệ thống";
            // 
            // ribnHeThongCon
            // 
            this.ribnHeThongCon.ItemLinks.Add(this.barBtnDangNhap);
            this.ribnHeThongCon.ItemLinks.Add(this.barBtnTaoTaiKhoan);
            this.ribnHeThongCon.ItemLinks.Add(this.barBtnDangXuat, true);
            this.ribnHeThongCon.Name = "ribnHeThongCon";
            // 
            // ribnDanhMuc
            // 
            this.ribnDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribnDanhMuc.Name = "ribnDanhMuc";
            this.ribnDanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMH, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKhoaLop);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThi);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSinhVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnGiaoVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapDe);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDangKiThi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribnBaoCao
            // 
            this.ribnBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribnBaoCao.Name = "ribnBaoCao";
            this.ribnBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Text = "ribbonPage7";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lableMa,
            this.labelTenDN,
            this.labelNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1516, 42);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lableMa
            // 
            this.lableMa.Name = "lableMa";
            this.lableMa.Size = new System.Drawing.Size(126, 32);
            this.lableMa.Text = "Mã GV/HS";
            // 
            // labelTenDN
            // 
            this.labelTenDN.Name = "labelTenDN";
            this.labelTenDN.Size = new System.Drawing.Size(175, 32);
            this.labelTenDN.Text = "Tên đăng nhập";
            // 
            // labelNhom
            // 
            this.labelNhom.Name = "labelNhom";
            this.labelNhom.Size = new System.Drawing.Size(82, 32);
            this.labelNhom.Text = "Nhóm";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 692);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "TRẮC NGHIỆM";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribnHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribnHeThongCon;
        private DevExpress.XtraBars.BarButtonItem barBtnDangNhap;
        private DevExpress.XtraBars.BarButtonItem barBtnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem barBtnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribnDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribnBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lableMa;
        private System.Windows.Forms.ToolStripStatusLabel labelTenDN;
        private System.Windows.Forms.ToolStripStatusLabel labelNhom;
        private DevExpress.XtraBars.BarButtonItem btnMH;
        private DevExpress.XtraBars.BarButtonItem btnKhoaLop;
        private DevExpress.XtraBars.BarButtonItem btnThi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnGiaoVien;
        private DevExpress.XtraBars.BarButtonItem btnNhapDe;
        private DevExpress.XtraBars.BarButtonItem btnDangKiThi;
    }
}

