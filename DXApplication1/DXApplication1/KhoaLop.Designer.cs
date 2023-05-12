
namespace DXApplication1
{
    partial class KhoaLop
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
            System.Windows.Forms.Label labelMaKH;
            System.Windows.Forms.Label labelTenKH;
            System.Windows.Forms.Label labelMaCS;
            System.Windows.Forms.Label labelMaLop;
            System.Windows.Forms.Label labelTenLop;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoaLop));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.panel_lopVEdt = new System.Windows.Forms.Panel();
            this.panelLop = new System.Windows.Forms.Panel();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DXApplication1.DS();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mSLop = new System.Windows.Forms.MenuStrip();
            this.menuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItermThem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItermXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItermSua = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEdt = new System.Windows.Forms.Panel();
            this.edtKHOA_LOP = new DevExpress.XtraEditors.TextEdit();
            this.cmbTenKhoa = new System.Windows.Forms.ComboBox();
            this.edtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.edtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.edtMaCS = new DevExpress.XtraEditors.TextEdit();
            this.edtTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.edtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.panelChuyenCS = new System.Windows.Forms.Panel();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.panelKhoa = new System.Windows.Forms.Panel();
            this.gcKhoa = new DevExpress.XtraGrid.GridControl();
            this.gridViewKhoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new DXApplication1.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new DXApplication1.DSTableAdapters.TableAdapterManager();
            this.gIAOVIEN_DANGKYTableAdapter = new DXApplication1.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.gIAOVIENTableAdapter = new DXApplication1.DSTableAdapters.GIAOVIENTableAdapter();
            this.lOPTableAdapter = new DXApplication1.DSTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new DXApplication1.DSTableAdapters.SINHVIENTableAdapter();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            labelMaKH = new System.Windows.Forms.Label();
            labelTenKH = new System.Windows.Forms.Label();
            labelMaCS = new System.Windows.Forms.Label();
            labelMaLop = new System.Windows.Forms.Label();
            labelTenLop = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel_lopVEdt.SuspendLayout();
            this.panelLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.mSLop.SuspendLayout();
            this.panelEdt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtKHOA_LOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            this.panelChuyenCS.SuspendLayout();
            this.panelKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaKH
            // 
            labelMaKH.AutoSize = true;
            labelMaKH.Location = new System.Drawing.Point(22, 23);
            labelMaKH.Name = "labelMaKH";
            labelMaKH.Size = new System.Drawing.Size(80, 20);
            labelMaKH.TabIndex = 0;
            labelMaKH.Text = "Mã Khoa: ";
            // 
            // labelTenKH
            // 
            labelTenKH.AutoSize = true;
            labelTenKH.Location = new System.Drawing.Point(22, 62);
            labelTenKH.Name = "labelTenKH";
            labelTenKH.Size = new System.Drawing.Size(85, 20);
            labelTenKH.TabIndex = 2;
            labelTenKH.Text = "Tên Khoa: ";
            // 
            // labelMaCS
            // 
            labelMaCS.AutoSize = true;
            labelMaCS.Location = new System.Drawing.Point(22, 100);
            labelMaCS.Name = "labelMaCS";
            labelMaCS.Size = new System.Drawing.Size(81, 20);
            labelMaCS.TabIndex = 4;
            labelMaCS.Text = "Mã cơ sở: ";
            // 
            // labelMaLop
            // 
            labelMaLop.AutoSize = true;
            labelMaLop.Location = new System.Drawing.Point(22, 137);
            labelMaLop.Name = "labelMaLop";
            labelMaLop.Size = new System.Drawing.Size(64, 20);
            labelMaLop.TabIndex = 6;
            labelMaLop.Text = "Mã lớp: ";
            // 
            // labelTenLop
            // 
            labelTenLop.AutoSize = true;
            labelTenLop.Location = new System.Drawing.Point(22, 174);
            labelTenLop.Name = "labelTenLop";
            labelTenLop.Size = new System.Drawing.Size(75, 20);
            labelTenLop.TabIndex = 8;
            labelTenLop.Text = "Tên Lớp: ";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(41, 203);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(0, 20);
            mAKHLabel.TabIndex = 11;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnHoanTac,
            this.barButtonItem7,
            this.btnReload,
            this.btnHuy,
            this.btnThoat});
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "hoàn tác";
            this.btnHoanTac.Id = 5;
            this.btnHoanTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.Image")));
            this.btnHoanTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.LargeImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "reload";
            this.btnReload.Id = 7;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 8;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 9;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1320, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1030);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1320, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 996);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1320, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 996);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "reload";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // panel_lopVEdt
            // 
            this.panel_lopVEdt.Controls.Add(this.panelLop);
            this.panel_lopVEdt.Controls.Add(this.panelEdt);
            this.panel_lopVEdt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_lopVEdt.Location = new System.Drawing.Point(0, 714);
            this.panel_lopVEdt.Name = "panel_lopVEdt";
            this.panel_lopVEdt.Size = new System.Drawing.Size(1320, 316);
            this.panel_lopVEdt.TabIndex = 4;
            // 
            // panelLop
            // 
            this.panelLop.AutoScroll = true;
            this.panelLop.Controls.Add(this.gcLop);
            this.panelLop.Controls.Add(this.mSLop);
            this.panelLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLop.Location = new System.Drawing.Point(635, 0);
            this.panelLop.Name = "panelLop";
            this.panelLop.Size = new System.Drawing.Size(685, 316);
            this.panelLop.TabIndex = 1;
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLop.Location = new System.Drawing.Point(0, 33);
            this.gcLop.MainView = this.gridView2;
            this.gcLop.MenuManager = this.barManager1;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(685, 283);
            this.gcLop.TabIndex = 0;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "FK_LOP_KHOA";
            this.bdsLop.DataSource = this.bdsKhoa;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH1});
            this.gridView2.GridControl = this.gcLop;
            this.gridView2.Name = "gridView2";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 30;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 112;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 30;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 112;
            // 
            // colMAKH1
            // 
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.MinWidth = 30;
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 2;
            this.colMAKH1.Width = 112;
            // 
            // mSLop
            // 
            this.mSLop.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mSLop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mSLop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLop});
            this.mSLop.Location = new System.Drawing.Point(0, 0);
            this.mSLop.Name = "mSLop";
            this.mSLop.Size = new System.Drawing.Size(685, 33);
            this.mSLop.TabIndex = 1;
            this.mSLop.Text = "menuStrip1";
            // 
            // menuLop
            // 
            this.menuLop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItermThem,
            this.menuItermXoa,
            this.menuItermSua});
            this.menuLop.Name = "menuLop";
            this.menuLop.Size = new System.Drawing.Size(108, 29);
            this.menuLop.Text = "Menu Lớp";
            // 
            // menuItermThem
            // 
            this.menuItermThem.Name = "menuItermThem";
            this.menuItermThem.Size = new System.Drawing.Size(158, 34);
            this.menuItermThem.Text = "Thêm";
            this.menuItermThem.Click += new System.EventHandler(this.menuItermThem_Click);
            // 
            // menuItermXoa
            // 
            this.menuItermXoa.Name = "menuItermXoa";
            this.menuItermXoa.Size = new System.Drawing.Size(158, 34);
            this.menuItermXoa.Text = "Xóa";
            this.menuItermXoa.Click += new System.EventHandler(this.menuItermXoa_Click);
            // 
            // menuItermSua
            // 
            this.menuItermSua.Name = "menuItermSua";
            this.menuItermSua.Size = new System.Drawing.Size(158, 34);
            this.menuItermSua.Text = "Sửa";
            this.menuItermSua.Click += new System.EventHandler(this.menuItermSua_Click);
            // 
            // panelEdt
            // 
            this.panelEdt.AutoScroll = true;
            this.panelEdt.Controls.Add(mAKHLabel);
            this.panelEdt.Controls.Add(this.edtKHOA_LOP);
            this.panelEdt.Controls.Add(this.cmbTenKhoa);
            this.panelEdt.Controls.Add(labelTenLop);
            this.panelEdt.Controls.Add(this.edtTenLop);
            this.panelEdt.Controls.Add(labelMaLop);
            this.panelEdt.Controls.Add(this.edtMaLop);
            this.panelEdt.Controls.Add(labelMaCS);
            this.panelEdt.Controls.Add(this.edtMaCS);
            this.panelEdt.Controls.Add(labelTenKH);
            this.panelEdt.Controls.Add(this.edtTenKhoa);
            this.panelEdt.Controls.Add(labelMaKH);
            this.panelEdt.Controls.Add(this.edtMaKH);
            this.panelEdt.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEdt.Location = new System.Drawing.Point(0, 0);
            this.panelEdt.Name = "panelEdt";
            this.panelEdt.Size = new System.Drawing.Size(635, 316);
            this.panelEdt.TabIndex = 0;
            // 
            // edtKHOA_LOP
            // 
            this.edtKHOA_LOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MAKH", true));
            this.edtKHOA_LOP.Location = new System.Drawing.Point(106, 200);
            this.edtKHOA_LOP.MenuManager = this.barManager1;
            this.edtKHOA_LOP.Name = "edtKHOA_LOP";
            this.edtKHOA_LOP.Size = new System.Drawing.Size(150, 28);
            this.edtKHOA_LOP.TabIndex = 12;
            // 
            // cmbTenKhoa
            // 
            this.cmbTenKhoa.FormattingEnabled = true;
            this.cmbTenKhoa.Location = new System.Drawing.Point(370, 58);
            this.cmbTenKhoa.Name = "cmbTenKhoa";
            this.cmbTenKhoa.Size = new System.Drawing.Size(193, 28);
            this.cmbTenKhoa.TabIndex = 10;
            // 
            // edtTenLop
            // 
            this.edtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.edtTenLop.Location = new System.Drawing.Point(145, 166);
            this.edtTenLop.MenuManager = this.barManager1;
            this.edtTenLop.Name = "edtTenLop";
            this.edtTenLop.Size = new System.Drawing.Size(219, 28);
            this.edtTenLop.TabIndex = 9;
            // 
            // edtMaLop
            // 
            this.edtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.edtMaLop.Location = new System.Drawing.Point(145, 129);
            this.edtMaLop.MenuManager = this.barManager1;
            this.edtMaLop.Name = "edtMaLop";
            this.edtMaLop.Size = new System.Drawing.Size(219, 28);
            this.edtMaLop.TabIndex = 7;
            // 
            // edtMaCS
            // 
            this.edtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
            this.edtMaCS.Location = new System.Drawing.Point(145, 92);
            this.edtMaCS.MenuManager = this.barManager1;
            this.edtMaCS.Name = "edtMaCS";
            this.edtMaCS.Size = new System.Drawing.Size(219, 28);
            this.edtMaCS.TabIndex = 5;
            // 
            // edtTenKhoa
            // 
            this.edtTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
            this.edtTenKhoa.Location = new System.Drawing.Point(145, 58);
            this.edtTenKhoa.MenuManager = this.barManager1;
            this.edtTenKhoa.Name = "edtTenKhoa";
            this.edtTenKhoa.Size = new System.Drawing.Size(219, 28);
            this.edtTenKhoa.TabIndex = 3;
            // 
            // edtMaKH
            // 
            this.edtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
            this.edtMaKH.Location = new System.Drawing.Point(145, 19);
            this.edtMaKH.MenuManager = this.barManager1;
            this.edtMaKH.Name = "edtMaKH";
            this.edtMaKH.Size = new System.Drawing.Size(219, 28);
            this.edtMaKH.TabIndex = 1;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLop;
            // 
            // panelChuyenCS
            // 
            this.panelChuyenCS.Controls.Add(this.cmbCoSo);
            this.panelChuyenCS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChuyenCS.Location = new System.Drawing.Point(0, 34);
            this.panelChuyenCS.Name = "panelChuyenCS";
            this.panelChuyenCS.Size = new System.Drawing.Size(1320, 38);
            this.panelChuyenCS.TabIndex = 5;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(0, 0);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(274, 28);
            this.cmbCoSo.TabIndex = 13;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // panelKhoa
            // 
            this.panelKhoa.Controls.Add(this.gcKhoa);
            this.panelKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKhoa.Location = new System.Drawing.Point(0, 72);
            this.panelKhoa.Name = "panelKhoa";
            this.panelKhoa.Size = new System.Drawing.Size(1320, 642);
            this.panelKhoa.TabIndex = 6;
            // 
            // gcKhoa
            // 
            this.gcKhoa.DataSource = this.bdsKhoa;
            this.gcKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhoa.Location = new System.Drawing.Point(0, 0);
            this.gcKhoa.MainView = this.gridViewKhoa;
            this.gcKhoa.MenuManager = this.barManager1;
            this.gcKhoa.Name = "gcKhoa";
            this.gcKhoa.Size = new System.Drawing.Size(1320, 642);
            this.gcKhoa.TabIndex = 0;
            this.gcKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKhoa});
            // 
            // gridViewKhoa
            // 
            this.gridViewKhoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridViewKhoa.GridControl = this.gcKhoa;
            this.gridViewKhoa.Name = "gridViewKhoa";
            this.gridViewKhoa.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewKhoa_FocusedRowChanged);
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 30;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 112;
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
            // bdsGV
            // 
            this.bdsGV.DataMember = "FK_GIAOVIEN_KHOA";
            this.bdsGV.DataSource = this.bdsKhoa;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = DXApplication1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "FK_GIAOVIEN_DANGKY_LOP";
            this.bdsGVDK.DataSource = this.bdsLop;
            // 
            // KhoaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1320, 1050);
            this.Controls.Add(this.panelKhoa);
            this.Controls.Add(this.panelChuyenCS);
            this.Controls.Add(this.panel_lopVEdt);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MainMenuStrip = this.mSLop;
            this.Name = "KhoaLop";
            this.Text = "KhoaLop";
            this.Load += new System.EventHandler(this.KhoaLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel_lopVEdt.ResumeLayout(false);
            this.panelLop.ResumeLayout(false);
            this.panelLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.mSLop.ResumeLayout(false);
            this.mSLop.PerformLayout();
            this.panelEdt.ResumeLayout(false);
            this.panelEdt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtKHOA_LOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            this.panelChuyenCS.ResumeLayout(false);
            this.panelKhoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panelKhoa;
        private System.Windows.Forms.Panel panelChuyenCS;
        private System.Windows.Forms.Panel panel_lopVEdt;
        private System.Windows.Forms.Panel panelLop;
        private System.Windows.Forms.Panel panelEdt;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DS dS;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKhoa;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private DevExpress.XtraEditors.TextEdit edtTenLop;
        private DevExpress.XtraEditors.TextEdit edtMaLop;
        private DevExpress.XtraEditors.TextEdit edtMaCS;
        private DevExpress.XtraEditors.TextEdit edtTenKhoa;
        private DevExpress.XtraEditors.TextEdit edtMaKH;
        private System.Windows.Forms.ComboBox cmbTenKhoa;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.MenuStrip mSLop;
        private System.Windows.Forms.ToolStripMenuItem menuLop;
        private System.Windows.Forms.ToolStripMenuItem menuItermThem;
        private System.Windows.Forms.ToolStripMenuItem menuItermXoa;
        private System.Windows.Forms.ToolStripMenuItem menuItermSua;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsGV;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
        private DevExpress.XtraEditors.TextEdit edtKHOA_LOP;
    }
}