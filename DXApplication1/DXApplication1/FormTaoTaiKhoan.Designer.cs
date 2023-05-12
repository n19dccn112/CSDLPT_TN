
namespace DXApplication1
{
    partial class FormTaoTaiKhoan
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
            System.Windows.Forms.Label labelMaGV;
            System.Windows.Forms.Label labelHoVaTen;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label labelDiaChi;
            System.Windows.Forms.Label labelMaKhoa;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoTaiKhoan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.labelMK = new System.Windows.Forms.Label();
            this.cmbLoginName = new System.Windows.Forms.ComboBox();
            this.labelLoginName = new System.Windows.Forms.Label();
            this.label_NHOM = new System.Windows.Forms.Label();
            this.labelNhom = new System.Windows.Forms.Label();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.label_MAKHOA = new System.Windows.Forms.Label();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DXApplication1.DS();
            this.label_DIACHI = new System.Windows.Forms.Label();
            this.label_TEN = new System.Windows.Forms.Label();
            this.label_HO = new System.Windows.Forms.Label();
            this.label_MAGV = new System.Windows.Forms.Label();
            this.gcGiaoVien = new DevExpress.XtraGrid.GridControl();
            this.gvGiaoVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.gIAOVIENTableAdapter = new DXApplication1.DSTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new DXApplication1.DSTableAdapters.TableAdapterManager();
            labelMaGV = new System.Windows.Forms.Label();
            labelHoVaTen = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            labelDiaChi = new System.Windows.Forms.Label();
            labelMaKhoa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.p4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMaGV
            // 
            labelMaGV.AutoSize = true;
            labelMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelMaGV.Location = new System.Drawing.Point(82, 16);
            labelMaGV.Name = "labelMaGV";
            labelMaGV.Size = new System.Drawing.Size(119, 20);
            labelMaGV.TabIndex = 0;
            labelMaGV.Text = "Mã giáo viên: ";
            // 
            // labelHoVaTen
            // 
            labelHoVaTen.AutoSize = true;
            labelHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelHoVaTen.Location = new System.Drawing.Point(82, 70);
            labelHoVaTen.Name = "labelHoVaTen";
            labelHoVaTen.Size = new System.Drawing.Size(91, 20);
            labelHoVaTen.TabIndex = 2;
            labelHoVaTen.Text = "Họ và tên:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(291, 65);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(0, 20);
            tENLabel.TabIndex = 4;
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDiaChi.Location = new System.Drawing.Point(82, 125);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new System.Drawing.Size(74, 20);
            labelDiaChi.TabIndex = 6;
            labelDiaChi.Text = "Địa chỉ: ";
            // 
            // labelMaKhoa
            // 
            labelMaKhoa.AutoSize = true;
            labelMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelMaKhoa.Location = new System.Drawing.Point(82, 173);
            labelMaKhoa.Name = "labelMaKhoa";
            labelMaKhoa.Size = new System.Drawing.Size(87, 20);
            labelMaKhoa.TabIndex = 8;
            labelMaKhoa.Text = "Mã khoa: ";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnReload,
            this.btnHuy,
            this.btnThoat});
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 3;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1453, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 545);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1453, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 511);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1453, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 511);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.p4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1453, 511);
            this.panel1.TabIndex = 4;
            // 
            // p4
            // 
            this.p4.AutoScroll = true;
            this.p4.Controls.Add(this.panel3);
            this.p4.Controls.Add(this.gcGiaoVien);
            this.p4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p4.Location = new System.Drawing.Point(0, 42);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(1453, 469);
            this.p4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxMK);
            this.panel3.Controls.Add(this.labelMK);
            this.panel3.Controls.Add(this.cmbLoginName);
            this.panel3.Controls.Add(this.labelLoginName);
            this.panel3.Controls.Add(this.label_NHOM);
            this.panel3.Controls.Add(this.labelNhom);
            this.panel3.Controls.Add(this.cmbNhom);
            this.panel3.Controls.Add(labelMaKhoa);
            this.panel3.Controls.Add(this.label_MAKHOA);
            this.panel3.Controls.Add(labelDiaChi);
            this.panel3.Controls.Add(this.label_DIACHI);
            this.panel3.Controls.Add(tENLabel);
            this.panel3.Controls.Add(this.label_TEN);
            this.panel3.Controls.Add(labelHoVaTen);
            this.panel3.Controls.Add(this.label_HO);
            this.panel3.Controls.Add(labelMaGV);
            this.panel3.Controls.Add(this.label_MAGV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1453, 205);
            this.panel3.TabIndex = 1;
            // 
            // textBoxMK
            // 
            this.textBoxMK.Location = new System.Drawing.Point(1142, 141);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(250, 26);
            this.textBoxMK.TabIndex = 18;
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMK.Location = new System.Drawing.Point(937, 147);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(88, 20);
            this.labelMK.TabIndex = 17;
            this.labelMK.Text = "Mật khẩu:";
            // 
            // cmbLoginName
            // 
            this.cmbLoginName.FormattingEnabled = true;
            this.cmbLoginName.Location = new System.Drawing.Point(1142, 86);
            this.cmbLoginName.Name = "cmbLoginName";
            this.cmbLoginName.Size = new System.Drawing.Size(250, 28);
            this.cmbLoginName.TabIndex = 16;
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginName.Location = new System.Drawing.Point(937, 94);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(114, 20);
            this.labelLoginName.TabIndex = 15;
            this.labelLoginName.Text = "Login Name: ";
            // 
            // label_NHOM
            // 
            this.label_NHOM.AutoSize = true;
            this.label_NHOM.Location = new System.Drawing.Point(1138, 40);
            this.label_NHOM.Name = "label_NHOM";
            this.label_NHOM.Size = new System.Drawing.Size(57, 20);
            this.label_NHOM.TabIndex = 14;
            this.label_NHOM.Text = "NHOM";
            // 
            // labelNhom
            // 
            this.labelNhom.AutoSize = true;
            this.labelNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhom.Location = new System.Drawing.Point(937, 40);
            this.labelNhom.Name = "labelNhom";
            this.labelNhom.Size = new System.Drawing.Size(55, 20);
            this.labelNhom.TabIndex = 13;
            this.labelNhom.Text = "Nhóm";
            // 
            // cmbNhom
            // 
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Location = new System.Drawing.Point(1274, 37);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(165, 28);
            this.cmbNhom.TabIndex = 12;
            // 
            // label_MAKHOA
            // 
            this.label_MAKHOA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAKH", true));
            this.label_MAKHOA.Location = new System.Drawing.Point(215, 170);
            this.label_MAKHOA.Name = "label_MAKHOA";
            this.label_MAKHOA.Size = new System.Drawing.Size(100, 23);
            this.label_MAKHOA.TabIndex = 9;
            this.label_MAKHOA.Text = "MAKHOA";
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIAOVIEN";
            this.bdsGV.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_DIACHI
            // 
            this.label_DIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "DIACHI", true));
            this.label_DIACHI.Location = new System.Drawing.Point(215, 125);
            this.label_DIACHI.Name = "label_DIACHI";
            this.label_DIACHI.Size = new System.Drawing.Size(420, 28);
            this.label_DIACHI.TabIndex = 7;
            this.label_DIACHI.Text = "DIACHI";
            // 
            // label_TEN
            // 
            this.label_TEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "TEN", true));
            this.label_TEN.Location = new System.Drawing.Point(352, 70);
            this.label_TEN.Name = "label_TEN";
            this.label_TEN.Size = new System.Drawing.Size(100, 23);
            this.label_TEN.TabIndex = 5;
            this.label_TEN.Text = "TEN";
            // 
            // label_HO
            // 
            this.label_HO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "HO", true));
            this.label_HO.Location = new System.Drawing.Point(215, 70);
            this.label_HO.Name = "label_HO";
            this.label_HO.Size = new System.Drawing.Size(131, 23);
            this.label_HO.TabIndex = 3;
            this.label_HO.Text = "HO";
            // 
            // label_MAGV
            // 
            this.label_MAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAGV", true));
            this.label_MAGV.Location = new System.Drawing.Point(215, 16);
            this.label_MAGV.Name = "label_MAGV";
            this.label_MAGV.Size = new System.Drawing.Size(100, 23);
            this.label_MAGV.TabIndex = 1;
            this.label_MAGV.Text = "MAGV";
            // 
            // gcGiaoVien
            // 
            this.gcGiaoVien.DataSource = this.bdsGV;
            this.gcGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.gcGiaoVien.MainView = this.gvGiaoVien;
            this.gcGiaoVien.MenuManager = this.barManager1;
            this.gcGiaoVien.Name = "gcGiaoVien";
            this.gcGiaoVien.Size = new System.Drawing.Size(1453, 469);
            this.gcGiaoVien.TabIndex = 0;
            this.gcGiaoVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGiaoVien});
            // 
            // gvGiaoVien
            // 
            this.gvGiaoVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colMAKH});
            this.gvGiaoVien.GridControl = this.gcGiaoVien;
            this.gvGiaoVien.Name = "gvGiaoVien";
            this.gvGiaoVien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvGiaoVien_FocusedRowChanged);
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 30;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 112;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 112;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCoSo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1453, 42);
            this.panel2.TabIndex = 4;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(0, 0);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(274, 28);
            this.cmbCoSo.TabIndex = 14;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DXApplication1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormTaoTaiKhoan";
            this.Text = "FormTaoTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.p4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsGV;
        private DS dS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Panel panel2;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_MAKHOA;
        private System.Windows.Forms.Label label_DIACHI;
        private System.Windows.Forms.Label label_TEN;
        private System.Windows.Forms.Label label_HO;
        private System.Windows.Forms.Label label_MAGV;
        private DevExpress.XtraGrid.GridControl gcGiaoVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.Label label_NHOM;
        private System.Windows.Forms.Label labelNhom;
        private System.Windows.Forms.ComboBox cmbLoginName;
        private System.Windows.Forms.Label labelLoginName;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.Label labelMK;
        private System.Windows.Forms.ComboBox cmbCoSo;
    }
}