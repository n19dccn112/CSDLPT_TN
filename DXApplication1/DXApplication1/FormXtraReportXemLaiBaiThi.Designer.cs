
namespace DXApplication1
{
    partial class FormXtraReportXemLaiBaiThi
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label labelMASV;
            System.Windows.Forms.Label labelHOTEN;
            System.Windows.Forms.Label labelMALOP;
            System.Windows.Forms.Label labelLOP;
            System.Windows.Forms.Label labelMAMH;
            System.Windows.Forms.Label labelTENMH;
            System.Windows.Forms.Label labelLAN;
            System.Windows.Forms.Label labelNGAYTHI;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXtraReportXemLaiBaiThi));
            this.panelChuyenCS = new System.Windows.Forms.Panel();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.dS = new DXApplication1.DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnXEMBAITHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcSP_XEMLAIBAITHI = new DevExpress.XtraGrid.GridControl();
            this.bdsSPXemLaiBaiThi = new System.Windows.Forms.BindingSource(this.components);
            this.gvSP_XEMLAIBAITHI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_XEMLAIBAITHITableAdapter = new DXApplication1.DSTableAdapters.SP_XEMLAIBAITHITableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edtNGAYTHI = new DevExpress.XtraEditors.DateEdit();
            this.edtLAN = new DevExpress.XtraEditors.SpinEdit();
            this.edtTENMH = new DevExpress.XtraEditors.TextEdit();
            this.edtMAMH = new DevExpress.XtraEditors.TextEdit();
            this.edtLOP = new DevExpress.XtraEditors.TextEdit();
            this.edtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.edtHOTEN = new DevExpress.XtraEditors.TextEdit();
            this.edtMASV = new DevExpress.XtraEditors.TextEdit();
            this.tableAdapterManager = new DXApplication1.DSTableAdapters.TableAdapterManager();
            mAMHLabel = new System.Windows.Forms.Label();
            labelMASV = new System.Windows.Forms.Label();
            labelHOTEN = new System.Windows.Forms.Label();
            labelMALOP = new System.Windows.Forms.Label();
            labelLOP = new System.Windows.Forms.Label();
            labelMAMH = new System.Windows.Forms.Label();
            labelTENMH = new System.Windows.Forms.Label();
            labelLAN = new System.Windows.Forms.Label();
            labelNGAYTHI = new System.Windows.Forms.Label();
            this.panelChuyenCS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSP_XEMLAIBAITHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPXemLaiBaiThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP_XEMLAIBAITHI)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtNGAYTHI.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNGAYTHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTENMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMAMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHOTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMASV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(27, 90);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(0, 20);
            mAMHLabel.TabIndex = 0;
            // 
            // labelMASV
            // 
            labelMASV.AutoSize = true;
            labelMASV.Location = new System.Drawing.Point(67, 24);
            labelMASV.Name = "labelMASV";
            labelMASV.Size = new System.Drawing.Size(104, 20);
            labelMASV.TabIndex = 1;
            labelMASV.Text = "Mã sinh viên: ";
            // 
            // labelHOTEN
            // 
            labelHOTEN.AutoSize = true;
            labelHOTEN.Location = new System.Drawing.Point(552, 24);
            labelHOTEN.Name = "labelHOTEN";
            labelHOTEN.Size = new System.Drawing.Size(65, 20);
            labelHOTEN.TabIndex = 3;
            labelHOTEN.Text = "Họ tên: ";
            // 
            // labelMALOP
            // 
            labelMALOP.AutoSize = true;
            labelMALOP.Location = new System.Drawing.Point(67, 72);
            labelMALOP.Name = "labelMALOP";
            labelMALOP.Size = new System.Drawing.Size(64, 20);
            labelMALOP.TabIndex = 5;
            labelMALOP.Text = "Mã lớp: ";
            // 
            // labelLOP
            // 
            labelLOP.AutoSize = true;
            labelLOP.Location = new System.Drawing.Point(552, 72);
            labelLOP.Name = "labelLOP";
            labelLOP.Size = new System.Drawing.Size(44, 20);
            labelLOP.TabIndex = 7;
            labelLOP.Text = "Lớp: ";
            // 
            // labelMAMH
            // 
            labelMAMH.AutoSize = true;
            labelMAMH.Location = new System.Drawing.Point(67, 121);
            labelMAMH.Name = "labelMAMH";
            labelMAMH.Size = new System.Drawing.Size(104, 20);
            labelMAMH.TabIndex = 9;
            labelMAMH.Text = "Mã môn học: ";
            // 
            // labelTENMH
            // 
            labelTENMH.AutoSize = true;
            labelTENMH.Location = new System.Drawing.Point(552, 117);
            labelTENMH.Name = "labelTENMH";
            labelTENMH.Size = new System.Drawing.Size(109, 20);
            labelTENMH.TabIndex = 11;
            labelTENMH.Text = "Tên môn học: ";
            // 
            // labelLAN
            // 
            labelLAN.AutoSize = true;
            labelLAN.Location = new System.Drawing.Point(67, 159);
            labelLAN.Name = "labelLAN";
            labelLAN.Size = new System.Drawing.Size(44, 20);
            labelLAN.TabIndex = 13;
            labelLAN.Text = "Lần: ";
            // 
            // labelNGAYTHI
            // 
            labelNGAYTHI.AutoSize = true;
            labelNGAYTHI.Location = new System.Drawing.Point(552, 163);
            labelNGAYTHI.Name = "labelNGAYTHI";
            labelNGAYTHI.Size = new System.Drawing.Size(74, 20);
            labelNGAYTHI.TabIndex = 15;
            labelNGAYTHI.Text = "Ngày thi: ";
            // 
            // panelChuyenCS
            // 
            this.panelChuyenCS.Controls.Add(this.cmbCoSo);
            this.panelChuyenCS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChuyenCS.Location = new System.Drawing.Point(0, 55);
            this.panelChuyenCS.Name = "panelChuyenCS";
            this.panelChuyenCS.Size = new System.Drawing.Size(1309, 55);
            this.panelChuyenCS.TabIndex = 6;
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
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnXEMBAITHI,
            this.btnTHOAT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXEMBAITHI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnXEMBAITHI
            // 
            this.btnXEMBAITHI.Caption = "Xem bài thi";
            this.btnXEMBAITHI.Id = 1;
            this.btnXEMBAITHI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXEMBAITHI.ImageOptions.Image")));
            this.btnXEMBAITHI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXEMBAITHI.ImageOptions.LargeImage")));
            this.btnXEMBAITHI.Name = "btnXEMBAITHI";
            this.btnXEMBAITHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXEMBAITHI_ItemClick);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Thoát";
            this.btnTHOAT.Id = 2;
            this.btnTHOAT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.btnTHOAT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1309, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 580);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1309, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 525);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1309, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 525);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcSP_XEMLAIBAITHI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 251);
            this.panel2.TabIndex = 12;
            // 
            // gcSP_XEMLAIBAITHI
            // 
            this.gcSP_XEMLAIBAITHI.DataSource = this.bdsSPXemLaiBaiThi;
            this.gcSP_XEMLAIBAITHI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSP_XEMLAIBAITHI.Location = new System.Drawing.Point(0, 0);
            this.gcSP_XEMLAIBAITHI.MainView = this.gvSP_XEMLAIBAITHI;
            this.gcSP_XEMLAIBAITHI.MenuManager = this.barManager1;
            this.gcSP_XEMLAIBAITHI.Name = "gcSP_XEMLAIBAITHI";
            this.gcSP_XEMLAIBAITHI.Size = new System.Drawing.Size(1309, 251);
            this.gcSP_XEMLAIBAITHI.TabIndex = 0;
            this.gcSP_XEMLAIBAITHI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSP_XEMLAIBAITHI});
            // 
            // bdsSPXemLaiBaiThi
            // 
            this.bdsSPXemLaiBaiThi.DataMember = "SP_XEMLAIBAITHI";
            this.bdsSPXemLaiBaiThi.DataSource = this.dS;
            // 
            // gvSP_XEMLAIBAITHI
            // 
            this.gvSP_XEMLAIBAITHI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            this.colTENMH,
            this.colLAN});
            this.gvSP_XEMLAIBAITHI.GridControl = this.gcSP_XEMLAIBAITHI;
            this.gvSP_XEMLAIBAITHI.Name = "gvSP_XEMLAIBAITHI";
            this.gvSP_XEMLAIBAITHI.OptionsBehavior.ReadOnly = true;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 30;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 112;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 30;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 112;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 30;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 2;
            this.colTENMH.Width = 112;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 30;
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 3;
            this.colLAN.Width = 112;
            // 
            // sP_XEMLAIBAITHITableAdapter
            // 
            this.sP_XEMLAIBAITHITableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(labelNGAYTHI);
            this.panel1.Controls.Add(this.edtNGAYTHI);
            this.panel1.Controls.Add(labelLAN);
            this.panel1.Controls.Add(this.edtLAN);
            this.panel1.Controls.Add(labelTENMH);
            this.panel1.Controls.Add(this.edtTENMH);
            this.panel1.Controls.Add(labelMAMH);
            this.panel1.Controls.Add(this.edtMAMH);
            this.panel1.Controls.Add(labelLOP);
            this.panel1.Controls.Add(this.edtLOP);
            this.panel1.Controls.Add(labelMALOP);
            this.panel1.Controls.Add(this.edtMALOP);
            this.panel1.Controls.Add(labelHOTEN);
            this.panel1.Controls.Add(this.edtHOTEN);
            this.panel1.Controls.Add(labelMASV);
            this.panel1.Controls.Add(this.edtMASV);
            this.panel1.Controls.Add(mAMHLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 219);
            this.panel1.TabIndex = 7;
            // 
            // edtNGAYTHI
            // 
            this.edtNGAYTHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPXemLaiBaiThi, "NGAYTHI", true));
            this.edtNGAYTHI.EditValue = null;
            this.edtNGAYTHI.Location = new System.Drawing.Point(722, 155);
            this.edtNGAYTHI.MenuManager = this.barManager1;
            this.edtNGAYTHI.Name = "edtNGAYTHI";
            this.edtNGAYTHI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtNGAYTHI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtNGAYTHI.Size = new System.Drawing.Size(201, 28);
            this.edtNGAYTHI.TabIndex = 16;
            // 
            // edtLAN
            // 
            this.edtLAN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPXemLaiBaiThi, "LAN", true));
            this.edtLAN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edtLAN.Location = new System.Drawing.Point(215, 155);
            this.edtLAN.MenuManager = this.barManager1;
            this.edtLAN.Name = "edtLAN";
            this.edtLAN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtLAN.Size = new System.Drawing.Size(150, 28);
            this.edtLAN.TabIndex = 14;
            // 
            // edtTENMH
            // 
            this.edtTENMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPXemLaiBaiThi, "TENMH", true));
            this.edtTENMH.Location = new System.Drawing.Point(722, 109);
            this.edtTENMH.MenuManager = this.barManager1;
            this.edtTENMH.Name = "edtTENMH";
            this.edtTENMH.Size = new System.Drawing.Size(401, 28);
            this.edtTENMH.TabIndex = 12;
            // 
            // edtMAMH
            // 
            this.edtMAMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPXemLaiBaiThi, "MAMH", true));
            this.edtMAMH.Location = new System.Drawing.Point(215, 113);
            this.edtMAMH.MenuManager = this.barManager1;
            this.edtMAMH.Name = "edtMAMH";
            this.edtMAMH.Size = new System.Drawing.Size(150, 28);
            this.edtMAMH.TabIndex = 10;
            // 
            // edtLOP
            // 
            this.edtLOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPXemLaiBaiThi, "LOP", true));
            this.edtLOP.Location = new System.Drawing.Point(722, 64);
            this.edtLOP.MenuManager = this.barManager1;
            this.edtLOP.Name = "edtLOP";
            this.edtLOP.Size = new System.Drawing.Size(320, 28);
            this.edtLOP.TabIndex = 8;
            // 
            // edtMALOP
            // 
            this.edtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPXemLaiBaiThi, "MALOP", true));
            this.edtMALOP.Location = new System.Drawing.Point(215, 68);
            this.edtMALOP.MenuManager = this.barManager1;
            this.edtMALOP.Name = "edtMALOP";
            this.edtMALOP.Size = new System.Drawing.Size(150, 28);
            this.edtMALOP.TabIndex = 6;
            // 
            // edtHOTEN
            // 
            this.edtHOTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPXemLaiBaiThi, "HOTEN", true));
            this.edtHOTEN.Location = new System.Drawing.Point(722, 16);
            this.edtHOTEN.MenuManager = this.barManager1;
            this.edtHOTEN.Name = "edtHOTEN";
            this.edtHOTEN.Size = new System.Drawing.Size(320, 28);
            this.edtHOTEN.TabIndex = 4;
            // 
            // edtMASV
            // 
            this.edtMASV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPXemLaiBaiThi, "MASV", true));
            this.edtMASV.Location = new System.Drawing.Point(215, 20);
            this.edtMASV.MenuManager = this.barManager1;
            this.edtMASV.Name = "edtMASV";
            this.edtMASV.Size = new System.Drawing.Size(150, 28);
            this.edtMASV.TabIndex = 2;
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
            // FormXtraReportXemLaiBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1309, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChuyenCS);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormXtraReportXemLaiBaiThi";
            this.Text = "FormXtraReportXemLaiBaiThi";
            this.Load += new System.EventHandler(this.FormXtraReportXemLaiBaiThi_Load);
            this.panelChuyenCS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSP_XEMLAIBAITHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPXemLaiBaiThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP_XEMLAIBAITHI)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtNGAYTHI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNGAYTHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTENMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMAMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHOTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMASV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelChuyenCS;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private DS dS;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnXEMBAITHI;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bdsSPXemLaiBaiThi;
        private DSTableAdapters.SP_XEMLAIBAITHITableAdapter sP_XEMLAIBAITHITableAdapter;
        private DevExpress.XtraGrid.GridControl gcSP_XEMLAIBAITHI;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSP_XEMLAIBAITHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.DateEdit edtNGAYTHI;
        private DevExpress.XtraEditors.SpinEdit edtLAN;
        private DevExpress.XtraEditors.TextEdit edtTENMH;
        private DevExpress.XtraEditors.TextEdit edtMAMH;
        private DevExpress.XtraEditors.TextEdit edtLOP;
        private DevExpress.XtraEditors.TextEdit edtMALOP;
        private DevExpress.XtraEditors.TextEdit edtHOTEN;
        private DevExpress.XtraEditors.TextEdit edtMASV;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}