
namespace DXApplication1
{
    partial class FormThi
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
            System.Windows.Forms.Label labelTenMH;
            System.Windows.Forms.Label LabelLan;
            System.Windows.Forms.Label labelNgayThi;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label labelSoCauThi;
            System.Windows.Forms.Label labelTrinhDo;
            System.Windows.Forms.Label labelThoiGian;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThi));
            this.gb_lop_thi = new System.Windows.Forms.GroupBox();
            this.gb_dang_thi = new System.Windows.Forms.GroupBox();
            this.gb_dap_an = new System.Windows.Forms.GroupBox();
            this.gcSpTimKiem = new DevExpress.XtraGrid.GridControl();
            this.sP_tabelTimKiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DXApplication1.DS();
            this.gvSpTimKiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBDThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnNopBai = new DevExpress.XtraBars.BarButtonItem();
            this.btnChonMonThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThiTiep = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.rdgDapAn = new DevExpress.XtraEditors.RadioGroup();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCauHoi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCauSo = new System.Windows.Forms.Label();
            this.rdgCauHoi = new DevExpress.XtraEditors.RadioGroup();
            this.gb_thong_tin = new System.Windows.Forms.GroupBox();
            this.labelMAMH = new System.Windows.Forms.Label();
            this.label_NGAYTHI = new System.Windows.Forms.Label();
            this.label_LAN = new System.Windows.Forms.Label();
            this.label_TENMH = new System.Windows.Forms.Label();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.label_THOIGIAN = new System.Windows.Forms.Label();
            this.label_TRINHDO = new System.Windows.Forms.Label();
            this.label_SOCAUTHI = new System.Windows.Forms.Label();
            this.labelCONLAI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.labelMaLop = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_MALOP = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTenLop = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_TENLOP = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelHoVaTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_HOVATEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelDiem = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_DIEM = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableAdapterManager = new DXApplication1.DSTableAdapters.TableAdapterManager();
            this.sP_tabelTimKiemTableAdapter = new DXApplication1.DSTableAdapters.SP_tabelTimKiemTableAdapter();
            labelTenMH = new System.Windows.Forms.Label();
            LabelLan = new System.Windows.Forms.Label();
            labelNgayThi = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            labelSoCauThi = new System.Windows.Forms.Label();
            labelTrinhDo = new System.Windows.Forms.Label();
            labelThoiGian = new System.Windows.Forms.Label();
            this.gb_lop_thi.SuspendLayout();
            this.gb_dang_thi.SuspendLayout();
            this.gb_dap_an.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSpTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_tabelTimKiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSpTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgDapAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgCauHoi.Properties)).BeginInit();
            this.gb_thong_tin.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTenMH
            // 
            labelTenMH.AutoSize = true;
            labelTenMH.Location = new System.Drawing.Point(27, 45);
            labelTenMH.Name = "labelTenMH";
            labelTenMH.Size = new System.Drawing.Size(109, 20);
            labelTenMH.TabIndex = 2;
            labelTenMH.Text = "Tên môn học: ";
            // 
            // LabelLan
            // 
            LabelLan.AutoSize = true;
            LabelLan.Location = new System.Drawing.Point(328, 44);
            LabelLan.Name = "LabelLan";
            LabelLan.Size = new System.Drawing.Size(44, 20);
            LabelLan.TabIndex = 4;
            LabelLan.Text = "Lần: ";
            // 
            // labelNgayThi
            // 
            labelNgayThi.AutoSize = true;
            labelNgayThi.Location = new System.Drawing.Point(554, 42);
            labelNgayThi.Name = "labelNgayThi";
            labelNgayThi.Size = new System.Drawing.Size(74, 20);
            labelNgayThi.TabIndex = 6;
            labelNgayThi.Text = "Ngày thi: ";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(193, 89);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(0, 20);
            mAMHLabel.TabIndex = 8;
            // 
            // labelSoCauThi
            // 
            labelSoCauThi.AutoSize = true;
            labelSoCauThi.Location = new System.Drawing.Point(456, 20);
            labelSoCauThi.Name = "labelSoCauThi";
            labelSoCauThi.Size = new System.Drawing.Size(84, 20);
            labelSoCauThi.TabIndex = 20;
            labelSoCauThi.Text = "Số câu thi:";
            // 
            // labelTrinhDo
            // 
            labelTrinhDo.AutoSize = true;
            labelTrinhDo.Location = new System.Drawing.Point(456, 58);
            labelTrinhDo.Name = "labelTrinhDo";
            labelTrinhDo.Size = new System.Drawing.Size(74, 20);
            labelTrinhDo.TabIndex = 21;
            labelTrinhDo.Text = "Trình độ: ";
            // 
            // labelThoiGian
            // 
            labelThoiGian.AutoSize = true;
            labelThoiGian.Location = new System.Drawing.Point(108, 22);
            labelThoiGian.Name = "labelThoiGian";
            labelThoiGian.Size = new System.Drawing.Size(81, 20);
            labelThoiGian.TabIndex = 22;
            labelThoiGian.Text = "Thời gian: ";
            // 
            // gb_lop_thi
            // 
            this.gb_lop_thi.Controls.Add(this.gb_dang_thi);
            this.gb_lop_thi.Controls.Add(this.gb_thong_tin);
            this.gb_lop_thi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_lop_thi.Location = new System.Drawing.Point(0, 55);
            this.gb_lop_thi.Name = "gb_lop_thi";
            this.gb_lop_thi.Size = new System.Drawing.Size(1924, 654);
            this.gb_lop_thi.TabIndex = 3;
            this.gb_lop_thi.TabStop = false;
            // 
            // gb_dang_thi
            // 
            this.gb_dang_thi.Controls.Add(this.gb_dap_an);
            this.gb_dang_thi.Controls.Add(this.rdgCauHoi);
            this.gb_dang_thi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_dang_thi.Location = new System.Drawing.Point(3, 189);
            this.gb_dang_thi.Name = "gb_dang_thi";
            this.gb_dang_thi.Size = new System.Drawing.Size(1918, 449);
            this.gb_dang_thi.TabIndex = 6;
            this.gb_dang_thi.TabStop = false;
            // 
            // gb_dap_an
            // 
            this.gb_dap_an.Controls.Add(this.gcSpTimKiem);
            this.gb_dap_an.Controls.Add(this.rdgDapAn);
            this.gb_dap_an.Controls.Add(this.label4);
            this.gb_dap_an.Controls.Add(this.labelCauHoi);
            this.gb_dap_an.Controls.Add(this.label5);
            this.gb_dap_an.Controls.Add(this.labelCauSo);
            this.gb_dap_an.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_dap_an.Location = new System.Drawing.Point(3, 22);
            this.gb_dap_an.Name = "gb_dap_an";
            this.gb_dap_an.Size = new System.Drawing.Size(908, 424);
            this.gb_dap_an.TabIndex = 7;
            this.gb_dap_an.TabStop = false;
            // 
            // gcSpTimKiem
            // 
            this.gcSpTimKiem.DataSource = this.sP_tabelTimKiemBindingSource;
            this.gcSpTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSpTimKiem.Location = new System.Drawing.Point(3, 312);
            this.gcSpTimKiem.MainView = this.gvSpTimKiem;
            this.gcSpTimKiem.MenuManager = this.barManager1;
            this.gcSpTimKiem.Name = "gcSpTimKiem";
            this.gcSpTimKiem.Size = new System.Drawing.Size(902, 109);
            this.gcSpTimKiem.TabIndex = 5;
            this.gcSpTimKiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSpTimKiem});
            // 
            // sP_tabelTimKiemBindingSource
            // 
            this.sP_tabelTimKiemBindingSource.DataMember = "SP_tabelTimKiem";
            this.sP_tabelTimKiemBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSpTimKiem
            // 
            this.gvSpTimKiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENMH,
            this.colLAN,
            this.colNGAYTHI,
            this.colMAMH,
            this.colSOCAUTHI,
            this.colTHOIGIAN,
            this.colTRINHDO});
            this.gvSpTimKiem.GridControl = this.gcSpTimKiem;
            this.gvSpTimKiem.Name = "gvSpTimKiem";
            this.gvSpTimKiem.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvSpTimKiem_FocusedRowChanged);
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 30;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 0;
            this.colTENMH.Width = 112;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 30;
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 1;
            this.colLAN.Width = 112;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.MinWidth = 30;
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 2;
            this.colNGAYTHI.Width = 112;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 30;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 3;
            this.colMAMH.Width = 112;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.MinWidth = 30;
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 4;
            this.colSOCAUTHI.Width = 112;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.MinWidth = 30;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 5;
            this.colTHOIGIAN.Width = 112;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 30;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 6;
            this.colTRINHDO.Width = 112;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBDThi,
            this.btnNopBai,
            this.btnPhucHoi,
            this.btnHoanTac,
            this.btnChonMonThi,
            this.btnThoat,
            this.btnThiTiep,
            this.btnReload});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBDThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNopBai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChonMonThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThiTiep, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBDThi
            // 
            this.btnBDThi.Caption = "Bắt đầu thi";
            this.btnBDThi.Id = 0;
            this.btnBDThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBDThi.ImageOptions.Image")));
            this.btnBDThi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBDThi.ImageOptions.LargeImage")));
            this.btnBDThi.Name = "btnBDThi";
            this.btnBDThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBDThi_ItemClick);
            // 
            // btnNopBai
            // 
            this.btnNopBai.Caption = "Nộp bài";
            this.btnNopBai.Id = 1;
            this.btnNopBai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNopBai.ImageOptions.Image")));
            this.btnNopBai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNopBai.ImageOptions.LargeImage")));
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNopBai_ItemClick);
            // 
            // btnChonMonThi
            // 
            this.btnChonMonThi.Caption = "Chọn môn thi";
            this.btnChonMonThi.Id = 4;
            this.btnChonMonThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChonMonThi.ImageOptions.Image")));
            this.btnChonMonThi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChonMonThi.ImageOptions.LargeImage")));
            this.btnChonMonThi.Name = "btnChonMonThi";
            this.btnChonMonThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChonMonThi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnThiTiep
            // 
            this.btnThiTiep.Caption = "Thi Tiếp";
            this.btnThiTiep.Id = 6;
            this.btnThiTiep.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThiTiep.ImageOptions.Image")));
            this.btnThiTiep.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThiTiep.ImageOptions.LargeImage")));
            this.btnThiTiep.Name = "btnThiTiep";
            this.btnThiTiep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThiTiep_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 8;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 709);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 654);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 654);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 2;
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn tác";
            this.btnHoanTac.Id = 3;
            this.btnHoanTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.Image")));
            this.btnHoanTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.LargeImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            // 
            // rdgDapAn
            // 
            this.rdgDapAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdgDapAn.Location = new System.Drawing.Point(3, 102);
            this.rdgDapAn.Name = "rdgDapAn";
            this.rdgDapAn.Size = new System.Drawing.Size(902, 210);
            this.rdgDapAn.TabIndex = 5;
            this.rdgDapAn.SelectedIndexChanged += new System.EventHandler(this.rdgDapAn_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 4;
            // 
            // labelCauHoi
            // 
            this.labelCauHoi.AutoSize = true;
            this.labelCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCauHoi.Location = new System.Drawing.Point(3, 62);
            this.labelCauHoi.Name = "labelCauHoi";
            this.labelCauHoi.Size = new System.Drawing.Size(366, 20);
            this.labelCauHoi.TabIndex = 3;
            this.labelCauHoi.Text = "gggggggggg hhhhhhhhhhh uuuuuuuuuuuuuu iiiiiiiiii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 2;
            // 
            // labelCauSo
            // 
            this.labelCauSo.AutoSize = true;
            this.labelCauSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCauSo.Location = new System.Drawing.Point(3, 22);
            this.labelCauSo.Name = "labelCauSo";
            this.labelCauSo.Size = new System.Drawing.Size(55, 20);
            this.labelCauSo.TabIndex = 1;
            this.labelCauSo.Text = "Câu 1:";
            // 
            // rdgCauHoi
            // 
            this.rdgCauHoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdgCauHoi.Location = new System.Drawing.Point(917, 22);
            this.rdgCauHoi.Name = "rdgCauHoi";
            this.rdgCauHoi.Size = new System.Drawing.Size(998, 424);
            this.rdgCauHoi.TabIndex = 6;
            this.rdgCauHoi.SelectedIndexChanged += new System.EventHandler(this.rdgCauHoi_SelectedIndexChanged);
            // 
            // gb_thong_tin
            // 
            this.gb_thong_tin.BackColor = System.Drawing.Color.MintCream;
            this.gb_thong_tin.Controls.Add(mAMHLabel);
            this.gb_thong_tin.Controls.Add(this.labelMAMH);
            this.gb_thong_tin.Controls.Add(labelNgayThi);
            this.gb_thong_tin.Controls.Add(this.label_NGAYTHI);
            this.gb_thong_tin.Controls.Add(LabelLan);
            this.gb_thong_tin.Controls.Add(this.label_LAN);
            this.gb_thong_tin.Controls.Add(labelTenMH);
            this.gb_thong_tin.Controls.Add(this.label_TENMH);
            this.gb_thong_tin.Controls.Add(this.gbTime);
            this.gb_thong_tin.Controls.Add(this.statusStrip2);
            this.gb_thong_tin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_thong_tin.Location = new System.Drawing.Point(3, 22);
            this.gb_thong_tin.Name = "gb_thong_tin";
            this.gb_thong_tin.Size = new System.Drawing.Size(1918, 167);
            this.gb_thong_tin.TabIndex = 5;
            this.gb_thong_tin.TabStop = false;
            // 
            // labelMAMH
            // 
            this.labelMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "MAMH", true));
            this.labelMAMH.Location = new System.Drawing.Point(261, 89);
            this.labelMAMH.Name = "labelMAMH";
            this.labelMAMH.Size = new System.Drawing.Size(100, 23);
            this.labelMAMH.TabIndex = 9;
            this.labelMAMH.Text = "MAMH";
            // 
            // label_NGAYTHI
            // 
            this.label_NGAYTHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "NGAYTHI", true));
            this.label_NGAYTHI.Location = new System.Drawing.Point(655, 44);
            this.label_NGAYTHI.Name = "label_NGAYTHI";
            this.label_NGAYTHI.Size = new System.Drawing.Size(100, 23);
            this.label_NGAYTHI.TabIndex = 7;
            this.label_NGAYTHI.Text = "NGAYTHI";
            // 
            // label_LAN
            // 
            this.label_LAN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "LAN", true));
            this.label_LAN.Location = new System.Drawing.Point(400, 45);
            this.label_LAN.Name = "label_LAN";
            this.label_LAN.Size = new System.Drawing.Size(100, 23);
            this.label_LAN.TabIndex = 5;
            this.label_LAN.Text = "LAN";
            // 
            // label_TENMH
            // 
            this.label_TENMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "TENMH", true));
            this.label_TENMH.Location = new System.Drawing.Point(183, 45);
            this.label_TENMH.Name = "label_TENMH";
            this.label_TENMH.Size = new System.Drawing.Size(100, 23);
            this.label_TENMH.TabIndex = 3;
            this.label_TENMH.Text = "TENMH";
            // 
            // gbTime
            // 
            this.gbTime.BackColor = System.Drawing.Color.SeaShell;
            this.gbTime.Controls.Add(labelThoiGian);
            this.gbTime.Controls.Add(this.label_THOIGIAN);
            this.gbTime.Controls.Add(labelTrinhDo);
            this.gbTime.Controls.Add(this.label_TRINHDO);
            this.gbTime.Controls.Add(labelSoCauThi);
            this.gbTime.Controls.Add(this.label_SOCAUTHI);
            this.gbTime.Controls.Add(this.labelCONLAI);
            this.gbTime.Controls.Add(this.label1);
            this.gbTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbTime.Location = new System.Drawing.Point(819, 22);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(1096, 110);
            this.gbTime.TabIndex = 2;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "ĐANG THI";
            // 
            // label_THOIGIAN
            // 
            this.label_THOIGIAN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "THOIGIAN", true));
            this.label_THOIGIAN.Location = new System.Drawing.Point(223, 22);
            this.label_THOIGIAN.Name = "label_THOIGIAN";
            this.label_THOIGIAN.Size = new System.Drawing.Size(100, 23);
            this.label_THOIGIAN.TabIndex = 23;
            this.label_THOIGIAN.Text = "00 phút";
            // 
            // label_TRINHDO
            // 
            this.label_TRINHDO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "TRINHDO", true));
            this.label_TRINHDO.Location = new System.Drawing.Point(548, 58);
            this.label_TRINHDO.Name = "label_TRINHDO";
            this.label_TRINHDO.Size = new System.Drawing.Size(100, 23);
            this.label_TRINHDO.TabIndex = 22;
            this.label_TRINHDO.Text = "TRINHDO";
            // 
            // label_SOCAUTHI
            // 
            this.label_SOCAUTHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "SOCAUTHI", true));
            this.label_SOCAUTHI.Location = new System.Drawing.Point(548, 20);
            this.label_SOCAUTHI.Name = "label_SOCAUTHI";
            this.label_SOCAUTHI.Size = new System.Drawing.Size(100, 23);
            this.label_SOCAUTHI.TabIndex = 21;
            this.label_SOCAUTHI.Text = "00";
            // 
            // labelCONLAI
            // 
            this.labelCONLAI.AutoSize = true;
            this.labelCONLAI.Location = new System.Drawing.Point(223, 56);
            this.labelCONLAI.Name = "labelCONLAI";
            this.labelCONLAI.Size = new System.Drawing.Size(71, 20);
            this.labelCONLAI.TabIndex = 5;
            this.labelCONLAI.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Còn lại:";
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.LavenderBlush;
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelMaLop,
            this.label_MALOP,
            this.labelTenLop,
            this.label_TENLOP,
            this.labelHoVaTen,
            this.label_HOVATEN,
            this.labelDiem,
            this.label_DIEM});
            this.statusStrip2.Location = new System.Drawing.Point(3, 132);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1912, 32);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // labelMaLop
            // 
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(72, 25);
            this.labelMaLop.Text = "Mã lớp:";
            // 
            // label_MALOP
            // 
            this.label_MALOP.Name = "label_MALOP";
            this.label_MALOP.Size = new System.Drawing.Size(71, 25);
            this.label_MALOP.Text = "MALOP";
            // 
            // labelTenLop
            // 
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(148, 25);
            this.labelTenLop.Text = "               Tên lớp:";
            // 
            // label_TENLOP
            // 
            this.label_TENLOP.Name = "label_TENLOP";
            this.label_TENLOP.Size = new System.Drawing.Size(74, 25);
            this.label_TENLOP.Text = "TENLOP";
            // 
            // labelHoVaTen
            // 
            this.labelHoVaTen.Name = "labelHoVaTen";
            this.labelHoVaTen.Size = new System.Drawing.Size(179, 25);
            this.labelHoVaTen.Text = "                 Họ và Tên:";
            // 
            // label_HOVATEN
            // 
            this.label_HOVATEN.Name = "label_HOVATEN";
            this.label_HOVATEN.Size = new System.Drawing.Size(91, 25);
            this.label_HOVATEN.Text = "HOVATEN";
            // 
            // labelDiem
            // 
            this.labelDiem.Name = "labelDiem";
            this.labelDiem.Size = new System.Drawing.Size(133, 25);
            this.labelDiem.Text = "               Điểm:";
            // 
            // label_DIEM
            // 
            this.label_DIEM.BackColor = System.Drawing.SystemColors.Control;
            this.label_DIEM.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DIEM.ForeColor = System.Drawing.Color.Red;
            this.label_DIEM.Name = "label_DIEM";
            this.label_DIEM.Size = new System.Drawing.Size(69, 25);
            this.label_DIEM.Text = "DIEM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // sP_tabelTimKiemTableAdapter
            // 
            this.sP_tabelTimKiemTableAdapter.ClearBeforeFill = true;
            // 
            // FormThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 709);
            this.Controls.Add(this.gb_lop_thi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormThi";
            this.Text = "FormThi";
            this.Load += new System.EventHandler(this.FormThi_Load);
            this.gb_lop_thi.ResumeLayout(false);
            this.gb_dang_thi.ResumeLayout(false);
            this.gb_dap_an.ResumeLayout(false);
            this.gb_dap_an.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSpTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_tabelTimKiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSpTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgDapAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgCauHoi.Properties)).EndInit();
            this.gb_thong_tin.ResumeLayout(false);
            this.gb_thong_tin.PerformLayout();
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_lop_thi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gb_thong_tin;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Label labelCONLAI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.GroupBox gb_dang_thi;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnBDThi;
        private DevExpress.XtraBars.BarButtonItem btnNopBai;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnChonMonThi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.ToolStripStatusLabel labelMaLop;
        private System.Windows.Forms.ToolStripStatusLabel label_MALOP;
        private System.Windows.Forms.ToolStripStatusLabel labelTenLop;
        private System.Windows.Forms.ToolStripStatusLabel label_TENLOP;
        private System.Windows.Forms.ToolStripStatusLabel labelHoVaTen;
        private System.Windows.Forms.ToolStripStatusLabel label_HOVATEN;
        private System.Windows.Forms.ToolStripStatusLabel labelDiem;
        private System.Windows.Forms.ToolStripStatusLabel label_DIEM;
        private DevExpress.XtraBars.BarButtonItem btnThiTiep;
        private DevExpress.XtraEditors.RadioGroup rdgCauHoi;
        private System.Windows.Forms.GroupBox gb_dap_an;
        private DevExpress.XtraEditors.RadioGroup rdgDapAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCauHoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCauSo;
        private System.Windows.Forms.BindingSource sP_tabelTimKiemBindingSource;
        private DSTableAdapters.SP_tabelTimKiemTableAdapter sP_tabelTimKiemTableAdapter;
        private DevExpress.XtraGrid.GridControl gcSpTimKiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSpTimKiem;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private System.Windows.Forms.Label labelMAMH;
        private System.Windows.Forms.Label label_NGAYTHI;
        private System.Windows.Forms.Label label_LAN;
        private System.Windows.Forms.Label label_TENMH;
        private System.Windows.Forms.Label label_THOIGIAN;
        private System.Windows.Forms.Label label_TRINHDO;
        private System.Windows.Forms.Label label_SOCAUTHI;
        private DevExpress.XtraBars.BarButtonItem btnReload;
    }
}