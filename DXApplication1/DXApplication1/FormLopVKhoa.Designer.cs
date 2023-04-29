
namespace DXApplication1
{
    partial class FormLopVKhoa
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLopVKhoa));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.gbKhoaVaLop = new System.Windows.Forms.GroupBox();
            this.txtAddTenKhoa = new System.Windows.Forms.TextBox();
            this.btn_XacNhanXoa = new System.Windows.Forms.Button();
            this.labelTenKhoa = new System.Windows.Forms.Label();
            this.cmbTenKhoa = new System.Windows.Forms.ComboBox();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThemKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnThemLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaLop = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCS = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.dS = new DXApplication1.DS();
            this.bdsVKhoaVaLop = new System.Windows.Forms.BindingSource(this.components);
            this.v_KhoaAddLopTableAdapter = new DXApplication1.DSTableAdapters.V_KhoaAddLopTableAdapter();
            this.tableAdapterManager = new DXApplication1.DSTableAdapters.TableAdapterManager();
            this.gcVLopVaKhoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbKhoaVaLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVKhoaVaLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVLopVaKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(89, 188);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(61, 20);
            tENLOPLabel.TabIndex = 0;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(669, 144);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(75, 20);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "Tên khoa";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(671, 188);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(73, 20);
            mACSLabel.TabIndex = 4;
            mACSLabel.Text = "Mã cơ sở";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(89, 140);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 20);
            mALOPLabel.TabIndex = 6;
            mALOPLabel.Text = "Mã lớp";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(669, 91);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(70, 20);
            mAKHLabel.TabIndex = 8;
            mAKHLabel.Text = "Mã khoa";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 2;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCoSo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1565, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cơ sở";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(74, 25);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(274, 28);
            this.cmbCoSo.TabIndex = 12;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // gbKhoaVaLop
            // 
            this.gbKhoaVaLop.Controls.Add(this.txtAddTenKhoa);
            this.gbKhoaVaLop.Controls.Add(this.btn_XacNhanXoa);
            this.gbKhoaVaLop.Controls.Add(this.labelTenKhoa);
            this.gbKhoaVaLop.Controls.Add(this.cmbTenKhoa);
            this.gbKhoaVaLop.Controls.Add(mAKHLabel);
            this.gbKhoaVaLop.Controls.Add(this.txtMaKhoa);
            this.gbKhoaVaLop.Controls.Add(mALOPLabel);
            this.gbKhoaVaLop.Controls.Add(this.txtMaLop);
            this.gbKhoaVaLop.Controls.Add(mACSLabel);
            this.gbKhoaVaLop.Controls.Add(this.txtMaCS);
            this.gbKhoaVaLop.Controls.Add(tENKHLabel);
            this.gbKhoaVaLop.Controls.Add(this.txtTenKhoa);
            this.gbKhoaVaLop.Controls.Add(tENLOPLabel);
            this.gbKhoaVaLop.Controls.Add(this.txtTenLop);
            this.gbKhoaVaLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbKhoaVaLop.Location = new System.Drawing.Point(0, 793);
            this.gbKhoaVaLop.Name = "gbKhoaVaLop";
            this.gbKhoaVaLop.Size = new System.Drawing.Size(1565, 237);
            this.gbKhoaVaLop.TabIndex = 7;
            this.gbKhoaVaLop.TabStop = false;
            this.gbKhoaVaLop.Text = "Khoa + Lớp";
            // 
            // txtAddTenKhoa
            // 
            this.txtAddTenKhoa.Location = new System.Drawing.Point(788, 138);
            this.txtAddTenKhoa.Name = "txtAddTenKhoa";
            this.txtAddTenKhoa.Size = new System.Drawing.Size(367, 26);
            this.txtAddTenKhoa.TabIndex = 15;
            // 
            // btn_XacNhanXoa
            // 
            this.btn_XacNhanXoa.Location = new System.Drawing.Point(390, 26);
            this.btn_XacNhanXoa.Name = "btn_XacNhanXoa";
            this.btn_XacNhanXoa.Size = new System.Drawing.Size(153, 38);
            this.btn_XacNhanXoa.TabIndex = 14;
            this.btn_XacNhanXoa.Text = "Xác nhận xóa";
            this.btn_XacNhanXoa.UseVisualStyleBackColor = true;
            this.btn_XacNhanXoa.Click += new System.EventHandler(this.btn_XacNhanXoa_Click);
            // 
            // labelTenKhoa
            // 
            this.labelTenKhoa.AutoSize = true;
            this.labelTenKhoa.Location = new System.Drawing.Point(89, 91);
            this.labelTenKhoa.Name = "labelTenKhoa";
            this.labelTenKhoa.Size = new System.Drawing.Size(81, 20);
            this.labelTenKhoa.TabIndex = 11;
            this.labelTenKhoa.Text = "Tên Khoa:";
            // 
            // cmbTenKhoa
            // 
            this.cmbTenKhoa.FormattingEnabled = true;
            this.cmbTenKhoa.Location = new System.Drawing.Point(219, 83);
            this.cmbTenKhoa.Name = "cmbTenKhoa";
            this.cmbTenKhoa.Size = new System.Drawing.Size(324, 28);
            this.cmbTenKhoa.TabIndex = 10;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(788, 83);
            this.txtMaKhoa.MenuManager = this.barManager1;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(200, 28);
            this.txtMaKhoa.TabIndex = 9;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4,
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemKhoa,
            this.btnXoaKhoa,
            this.btnSuaKhoa,
            this.btnGhiKhoa,
            this.btnPhucHoi,
            this.btnHoanTac,
            this.btnReload,
            this.btnHuy,
            this.btnThoat,
            this.barButtonItem10,
            this.btnThemLop,
            this.btnXoaLop,
            this.btnSuaLop});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 14;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 1;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemKhoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaKhoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaKhoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiKhoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.Text = "Tools";
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Caption = "Thêm Khoa";
            this.btnThemKhoa.Id = 0;
            this.btnThemKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKhoa.ImageOptions.Image")));
            this.btnThemKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemKhoa.ImageOptions.LargeImage")));
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemKhoa_ItemClick);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Caption = "Xóa Khoa";
            this.btnXoaKhoa.Id = 1;
            this.btnXoaKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKhoa.ImageOptions.Image")));
            this.btnXoaKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaKhoa.ImageOptions.LargeImage")));
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaKhoa_ItemClick);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Caption = "Sửa Khoa";
            this.btnSuaKhoa.Id = 2;
            this.btnSuaKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKhoa.ImageOptions.Image")));
            this.btnSuaKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaKhoa.ImageOptions.LargeImage")));
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaKhoa_ItemClick);
            // 
            // btnGhiKhoa
            // 
            this.btnGhiKhoa.Caption = "Ghi";
            this.btnGhiKhoa.Id = 3;
            this.btnGhiKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiKhoa.ImageOptions.Image")));
            this.btnGhiKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiKhoa.ImageOptions.LargeImage")));
            this.btnGhiKhoa.Name = "btnGhiKhoa";
            this.btnGhiKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn tác";
            this.btnHoanTac.Id = 5;
            this.btnHoanTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.Image")));
            this.btnHoanTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.LargeImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 7;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // btnThemLop
            // 
            this.btnThemLop.Caption = "Thêm Lớp";
            this.btnThemLop.Id = 10;
            this.btnThemLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLop.ImageOptions.Image")));
            this.btnThemLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemLop.ImageOptions.LargeImage")));
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemLop_ItemClick);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Caption = "Xóa Lớp";
            this.btnXoaLop.Id = 11;
            this.btnXoaLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLop.ImageOptions.Image")));
            this.btnXoaLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaLop.ImageOptions.LargeImage")));
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaLop_ItemClick);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Caption = "Sửa Lớp";
            this.btnSuaLop.Id = 13;
            this.btnSuaLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLop.ImageOptions.Image")));
            this.btnSuaLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaLop.ImageOptions.LargeImage")));
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaLop_ItemClick);
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1565, 69);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1030);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1565, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 69);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 961);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1565, 69);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 961);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 9;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(219, 136);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(150, 28);
            this.txtMaLop.TabIndex = 7;
            // 
            // txtMaCS
            // 
            this.txtMaCS.Location = new System.Drawing.Point(788, 184);
            this.txtMaCS.MenuManager = this.barManager1;
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(150, 28);
            this.txtMaCS.TabIndex = 5;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(788, 136);
            this.txtTenKhoa.MenuManager = this.barManager1;
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(367, 28);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(219, 184);
            this.txtTenLop.MenuManager = this.barManager1;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(324, 28);
            this.txtTenLop.TabIndex = 1;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVKhoaVaLop
            // 
            this.bdsVKhoaVaLop.DataMember = "V_KhoaAddLop";
            this.bdsVKhoaVaLop.DataSource = this.dS;
            // 
            // v_KhoaAddLopTableAdapter
            // 
            this.v_KhoaAddLopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DXApplication1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcVLopVaKhoa
            // 
            this.gcVLopVaKhoa.DataSource = this.bdsVKhoaVaLop;
            this.gcVLopVaKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVLopVaKhoa.Location = new System.Drawing.Point(0, 151);
            this.gcVLopVaKhoa.MainView = this.gridView1;
            this.gcVLopVaKhoa.MenuManager = this.barManager1;
            this.gcVLopVaKhoa.Name = "gcVLopVaKhoa";
            this.gcVLopVaKhoa.Size = new System.Drawing.Size(1565, 642);
            this.gcVLopVaKhoa.TabIndex = 30;
            this.gcVLopVaKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcVLopVaKhoa.Click += new System.EventHandler(this.gcVKhoaVaLop_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENLOP,
            this.colTENKH,
            this.colMACS,
            this.colMALOP,
            this.colMAKH});
            this.gridView1.GridControl = this.gcVLopVaKhoa;
            this.gridView1.Name = "gridView1";
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 30;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 0;
            this.colTENLOP.Width = 112;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 30;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 112;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 30;
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 112;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 30;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 3;
            this.colMALOP.Width = 112;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 30;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 4;
            this.colMAKH.Width = 112;
            // 
            // FormLopVKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1565, 1050);
            this.Controls.Add(this.gcVLopVaKhoa);
            this.Controls.Add(this.gbKhoaVaLop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormLopVKhoa";
            this.Text = "FormLop";
            this.Load += new System.EventHandler(this.FormLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbKhoaVaLop.ResumeLayout(false);
            this.gbKhoaVaLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVKhoaVaLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVLopVaKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.GroupBox gbKhoaVaLop;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThemKhoa;
        private DevExpress.XtraBars.BarButtonItem btnXoaKhoa;
        private DevExpress.XtraBars.BarButtonItem btnSuaKhoa;
        private DevExpress.XtraBars.BarButtonItem btnGhiKhoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtMaCS;
        private DevExpress.XtraEditors.TextEdit txtTenKhoa;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraBars.BarButtonItem btnThemLop;
        private DevExpress.XtraBars.BarButtonItem btnXoaLop;
        private DevExpress.XtraBars.BarButtonItem btnSuaLop;
        private System.Windows.Forms.Label labelTenKhoa;
        private System.Windows.Forms.ComboBox cmbTenKhoa;
        private System.Windows.Forms.Button btn_XacNhanXoa;
        private System.Windows.Forms.TextBox txtAddTenKhoa;
        private System.Windows.Forms.BindingSource bdsVKhoaVaLop;
        private DS dS;
        private DSTableAdapters.V_KhoaAddLopTableAdapter v_KhoaAddLopTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcVLopVaKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
    }
}