
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
            System.Windows.Forms.Label label_TenMH;
            System.Windows.Forms.Label label_NgayThi;
            System.Windows.Forms.Label label_Lan;
            System.Windows.Forms.Label label_MaMH;
            System.Windows.Forms.Label label_TrinhDo;
            System.Windows.Forms.Label label_SoCauThi;
            System.Windows.Forms.Label label_ThoiGian;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThi));
            this.gb_lop_thi = new System.Windows.Forms.GroupBox();
            this.gb_dang_thi = new System.Windows.Forms.GroupBox();
            this.gb_cau_hoi = new System.Windows.Forms.GroupBox();
            this.rdgCauHoi = new DevExpress.XtraEditors.RadioGroup();
            this.gb_dap_an = new System.Windows.Forms.GroupBox();
            this.rdgDapAn = new DevExpress.XtraEditors.RadioGroup();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCauHoi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCauSo = new System.Windows.Forms.Label();
            this.gb_thong_tin = new System.Windows.Forms.GroupBox();
            this.labelMAMH = new System.Windows.Forms.Label();
            this.sP_tabelTimKiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DXApplication1.DS();
            this.labelLAN = new System.Windows.Forms.Label();
            this.labelNGAYTHI = new System.Windows.Forms.Label();
            this.labelTENMH = new System.Windows.Forms.Label();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.numberTHOIGIAN = new System.Windows.Forms.NumericUpDown();
            this.labelTRINHDO = new System.Windows.Forms.Label();
            this.labelSOCAUTHI = new System.Windows.Forms.Label();
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBDThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnNopBai = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnChonMonThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sP_tabelTimKiemTableAdapter = new DXApplication1.DSTableAdapters.SP_tabelTimKiemTableAdapter();
            this.tableAdapterManager = new DXApplication1.DSTableAdapters.TableAdapterManager();
            this.gcSpTimKiem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            label_TenMH = new System.Windows.Forms.Label();
            label_NgayThi = new System.Windows.Forms.Label();
            label_Lan = new System.Windows.Forms.Label();
            label_MaMH = new System.Windows.Forms.Label();
            label_TrinhDo = new System.Windows.Forms.Label();
            label_SoCauThi = new System.Windows.Forms.Label();
            label_ThoiGian = new System.Windows.Forms.Label();
            this.gb_lop_thi.SuspendLayout();
            this.gb_dang_thi.SuspendLayout();
            this.gb_cau_hoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgCauHoi.Properties)).BeginInit();
            this.gb_dap_an.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgDapAn.Properties)).BeginInit();
            this.gb_thong_tin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_tabelTimKiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.gbTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberTHOIGIAN)).BeginInit();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSpTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_TenMH
            // 
            label_TenMH.AutoSize = true;
            label_TenMH.Location = new System.Drawing.Point(9, 39);
            label_TenMH.Name = "label_TenMH";
            label_TenMH.Size = new System.Drawing.Size(105, 20);
            label_TenMH.TabIndex = 2;
            label_TenMH.Text = "Tên môn học:";
            // 
            // label_NgayThi
            // 
            label_NgayThi.AutoSize = true;
            label_NgayThi.Location = new System.Drawing.Point(599, 39);
            label_NgayThi.Name = "label_NgayThi";
            label_NgayThi.Size = new System.Drawing.Size(70, 20);
            label_NgayThi.TabIndex = 4;
            label_NgayThi.Text = "Ngày thi:";
            // 
            // label_Lan
            // 
            label_Lan.AutoSize = true;
            label_Lan.Location = new System.Drawing.Point(456, 39);
            label_Lan.Name = "label_Lan";
            label_Lan.Size = new System.Drawing.Size(40, 20);
            label_Lan.TabIndex = 6;
            label_Lan.Text = "Lần:";
            // 
            // label_MaMH
            // 
            label_MaMH.AutoSize = true;
            label_MaMH.Location = new System.Drawing.Point(245, 10);
            label_MaMH.Name = "label_MaMH";
            label_MaMH.Size = new System.Drawing.Size(0, 20);
            label_MaMH.TabIndex = 8;
            // 
            // label_TrinhDo
            // 
            label_TrinhDo.AutoSize = true;
            label_TrinhDo.Location = new System.Drawing.Point(387, 61);
            label_TrinhDo.Name = "label_TrinhDo";
            label_TrinhDo.Size = new System.Drawing.Size(70, 20);
            label_TrinhDo.TabIndex = 18;
            label_TrinhDo.Text = "Trình độ:";
            // 
            // label_SoCauThi
            // 
            label_SoCauThi.AutoSize = true;
            label_SoCauThi.Location = new System.Drawing.Point(387, 22);
            label_SoCauThi.Name = "label_SoCauThi";
            label_SoCauThi.Size = new System.Drawing.Size(84, 20);
            label_SoCauThi.TabIndex = 16;
            label_SoCauThi.Text = "Số câu thi:";
            // 
            // label_ThoiGian
            // 
            label_ThoiGian.AutoSize = true;
            label_ThoiGian.Location = new System.Drawing.Point(108, 20);
            label_ThoiGian.Name = "label_ThoiGian";
            label_ThoiGian.Size = new System.Drawing.Size(77, 20);
            label_ThoiGian.TabIndex = 19;
            label_ThoiGian.Text = "Thời gian:";
            // 
            // gb_lop_thi
            // 
            this.gb_lop_thi.Controls.Add(this.gb_dang_thi);
            this.gb_lop_thi.Controls.Add(this.gb_thong_tin);
            this.gb_lop_thi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_lop_thi.Location = new System.Drawing.Point(0, 55);
            this.gb_lop_thi.Name = "gb_lop_thi";
            this.gb_lop_thi.Size = new System.Drawing.Size(1924, 634);
            this.gb_lop_thi.TabIndex = 3;
            this.gb_lop_thi.TabStop = false;
            // 
            // gb_dang_thi
            // 
            this.gb_dang_thi.Controls.Add(this.gb_cau_hoi);
            this.gb_dang_thi.Controls.Add(this.gb_dap_an);
            this.gb_dang_thi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_dang_thi.Location = new System.Drawing.Point(3, 182);
            this.gb_dang_thi.Name = "gb_dang_thi";
            this.gb_dang_thi.Size = new System.Drawing.Size(1918, 449);
            this.gb_dang_thi.TabIndex = 6;
            this.gb_dang_thi.TabStop = false;
            this.gb_dang_thi.Text = "ĐANG THI";
            // 
            // gb_cau_hoi
            // 
            this.gb_cau_hoi.Controls.Add(this.rdgCauHoi);
            this.gb_cau_hoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_cau_hoi.Location = new System.Drawing.Point(911, 22);
            this.gb_cau_hoi.Name = "gb_cau_hoi";
            this.gb_cau_hoi.Size = new System.Drawing.Size(1004, 424);
            this.gb_cau_hoi.TabIndex = 5;
            this.gb_cau_hoi.TabStop = false;
            this.gb_cau_hoi.Text = "CÂU HỎI";
            // 
            // rdgCauHoi
            // 
            this.rdgCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgCauHoi.Location = new System.Drawing.Point(3, 22);
            this.rdgCauHoi.Name = "rdgCauHoi";
            this.rdgCauHoi.Size = new System.Drawing.Size(998, 399);
            this.rdgCauHoi.TabIndex = 0;
            this.rdgCauHoi.SelectedIndexChanged += new System.EventHandler(this.rdgCauHoi_SelectedIndexChanged);
            // 
            // gb_dap_an
            // 
            this.gb_dap_an.Controls.Add(this.rdgDapAn);
            this.gb_dap_an.Controls.Add(this.label4);
            this.gb_dap_an.Controls.Add(this.labelCauHoi);
            this.gb_dap_an.Controls.Add(this.label5);
            this.gb_dap_an.Controls.Add(this.labelCauSo);
            this.gb_dap_an.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_dap_an.Location = new System.Drawing.Point(3, 22);
            this.gb_dap_an.Name = "gb_dap_an";
            this.gb_dap_an.Size = new System.Drawing.Size(908, 424);
            this.gb_dap_an.TabIndex = 3;
            this.gb_dap_an.TabStop = false;
            // 
            // rdgDapAn
            // 
            this.rdgDapAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgDapAn.Location = new System.Drawing.Point(3, 102);
            this.rdgDapAn.Name = "rdgDapAn";
            this.rdgDapAn.Size = new System.Drawing.Size(902, 319);
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
            // gb_thong_tin
            // 
            this.gb_thong_tin.Controls.Add(label_MaMH);
            this.gb_thong_tin.Controls.Add(this.labelMAMH);
            this.gb_thong_tin.Controls.Add(label_Lan);
            this.gb_thong_tin.Controls.Add(this.labelLAN);
            this.gb_thong_tin.Controls.Add(label_NgayThi);
            this.gb_thong_tin.Controls.Add(this.labelNGAYTHI);
            this.gb_thong_tin.Controls.Add(label_TenMH);
            this.gb_thong_tin.Controls.Add(this.labelTENMH);
            this.gb_thong_tin.Controls.Add(this.gbTime);
            this.gb_thong_tin.Controls.Add(this.statusStrip2);
            this.gb_thong_tin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_thong_tin.Location = new System.Drawing.Point(3, 22);
            this.gb_thong_tin.Name = "gb_thong_tin";
            this.gb_thong_tin.Size = new System.Drawing.Size(1918, 160);
            this.gb_thong_tin.TabIndex = 5;
            this.gb_thong_tin.TabStop = false;
            // 
            // labelMAMH
            // 
            this.labelMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "MAMH", true));
            this.labelMAMH.Location = new System.Drawing.Point(168, 75);
            this.labelMAMH.Name = "labelMAMH";
            this.labelMAMH.Size = new System.Drawing.Size(100, 23);
            this.labelMAMH.TabIndex = 9;
            this.labelMAMH.Text = "MAMH";
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
            // labelLAN
            // 
            this.labelLAN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "LAN", true));
            this.labelLAN.Location = new System.Drawing.Point(502, 39);
            this.labelLAN.Name = "labelLAN";
            this.labelLAN.Size = new System.Drawing.Size(100, 23);
            this.labelLAN.TabIndex = 7;
            this.labelLAN.Text = "0";
            // 
            // labelNGAYTHI
            // 
            this.labelNGAYTHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "NGAYTHI", true));
            this.labelNGAYTHI.Location = new System.Drawing.Point(675, 39);
            this.labelNGAYTHI.Name = "labelNGAYTHI";
            this.labelNGAYTHI.Size = new System.Drawing.Size(100, 23);
            this.labelNGAYTHI.TabIndex = 5;
            this.labelNGAYTHI.Text = "00/00/0000";
            // 
            // labelTENMH
            // 
            this.labelTENMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "TENMH", true));
            this.labelTENMH.Location = new System.Drawing.Point(120, 39);
            this.labelTENMH.Name = "labelTENMH";
            this.labelTENMH.Size = new System.Drawing.Size(261, 23);
            this.labelTENMH.TabIndex = 3;
            this.labelTENMH.Text = "TENMH";
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(label_ThoiGian);
            this.gbTime.Controls.Add(this.numberTHOIGIAN);
            this.gbTime.Controls.Add(label_TrinhDo);
            this.gbTime.Controls.Add(this.labelTRINHDO);
            this.gbTime.Controls.Add(label_SoCauThi);
            this.gbTime.Controls.Add(this.labelSOCAUTHI);
            this.gbTime.Controls.Add(this.labelCONLAI);
            this.gbTime.Controls.Add(this.label1);
            this.gbTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbTime.Location = new System.Drawing.Point(819, 22);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(1096, 103);
            this.gbTime.TabIndex = 2;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "ĐANG THI";
            // 
            // numberTHOIGIAN
            // 
            this.numberTHOIGIAN.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sP_tabelTimKiemBindingSource, "THOIGIAN", true));
            this.numberTHOIGIAN.Location = new System.Drawing.Point(227, 20);
            this.numberTHOIGIAN.Name = "numberTHOIGIAN";
            this.numberTHOIGIAN.Size = new System.Drawing.Size(98, 26);
            this.numberTHOIGIAN.TabIndex = 20;
            // 
            // labelTRINHDO
            // 
            this.labelTRINHDO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "TRINHDO", true));
            this.labelTRINHDO.Location = new System.Drawing.Point(489, 61);
            this.labelTRINHDO.Name = "labelTRINHDO";
            this.labelTRINHDO.Size = new System.Drawing.Size(100, 23);
            this.labelTRINHDO.TabIndex = 19;
            this.labelTRINHDO.Text = "A";
            // 
            // labelSOCAUTHI
            // 
            this.labelSOCAUTHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_tabelTimKiemBindingSource, "SOCAUTHI", true));
            this.labelSOCAUTHI.Location = new System.Drawing.Point(489, 21);
            this.labelSOCAUTHI.Name = "labelSOCAUTHI";
            this.labelSOCAUTHI.Size = new System.Drawing.Size(100, 23);
            this.labelSOCAUTHI.TabIndex = 17;
            this.labelSOCAUTHI.Text = "30 câu";
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
            this.statusStrip2.Location = new System.Drawing.Point(3, 125);
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
            this.label_DIEM.Name = "label_DIEM";
            this.label_DIEM.Size = new System.Drawing.Size(55, 25);
            this.label_DIEM.Text = "DIEM";
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
            this.btnBDThi,
            this.btnNopBai,
            this.btnPhucHoi,
            this.btnHoanTac,
            this.btnChonMonThi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBDThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNopBai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChonMonThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 2;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
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
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 689);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 634);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 634);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sP_tabelTimKiemTableAdapter
            // 
            this.sP_tabelTimKiemTableAdapter.ClearBeforeFill = true;
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
            // gcSpTimKiem
            // 
            this.gcSpTimKiem.DataSource = this.sP_tabelTimKiemBindingSource;
            this.gcSpTimKiem.Location = new System.Drawing.Point(0, 258);
            this.gcSpTimKiem.MainView = this.gridView1;
            this.gcSpTimKiem.Name = "gcSpTimKiem";
            this.gcSpTimKiem.Size = new System.Drawing.Size(1910, 399);
            this.gcSpTimKiem.TabIndex = 7;
            this.gcSpTimKiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENMH,
            this.colLAN,
            this.colNGAYTHI});
            this.gridView1.GridControl = this.gcSpTimKiem;
            this.gridView1.Name = "gridView1";
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
            // FormThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 709);
            this.Controls.Add(this.gcSpTimKiem);
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
            this.gb_cau_hoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgCauHoi.Properties)).EndInit();
            this.gb_dap_an.ResumeLayout(false);
            this.gb_dap_an.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgDapAn.Properties)).EndInit();
            this.gb_thong_tin.ResumeLayout(false);
            this.gb_thong_tin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_tabelTimKiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberTHOIGIAN)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSpTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private System.Windows.Forms.GroupBox gb_cau_hoi;
        private DevExpress.XtraEditors.RadioGroup rdgCauHoi;
        private System.Windows.Forms.GroupBox gb_dap_an;
        private DevExpress.XtraEditors.RadioGroup rdgDapAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCauHoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCauSo;
        private DS dS;
        private System.Windows.Forms.BindingSource sP_tabelTimKiemBindingSource;
        private DSTableAdapters.SP_tabelTimKiemTableAdapter sP_tabelTimKiemTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcSpTimKiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnBDThi;
        private DevExpress.XtraBars.BarButtonItem btnNopBai;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.Bar bar3;
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
        private System.Windows.Forms.Label labelMAMH;
        private System.Windows.Forms.Label labelLAN;
        private System.Windows.Forms.Label labelNGAYTHI;
        private System.Windows.Forms.Label labelTENMH;
        private System.Windows.Forms.Label labelTRINHDO;
        private System.Windows.Forms.Label labelSOCAUTHI;
        private System.Windows.Forms.NumericUpDown numberTHOIGIAN;
    }
}