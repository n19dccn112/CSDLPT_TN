using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;


namespace DXApplication1
{
    public partial class FormThi : Form
    {
        int giay, phut = 0;
        double Diem1Cau, TongDiem = 0.0;
        Dictionary<int, string> dict = new Dictionary<int, string>();

        List<CauHoi> deThi = new List<CauHoi>();
        BindingSource bdsDethi;
        public FormThi()
        {
            InitializeComponent();
        }
        private void FormThi_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "GIANGVIEN" || Program.mGroup == "COSO")
            {
                //labelTenLop.Text = "MÃ GV:";
                //labelHoVaTen.Text = "TÊN GV: ";
                //labelTENLOP.Text = Program.username;
                //labelHOVATEN.Text = Program.mHoten;
            }
            else
            {
                label_MALOP.Text = Program.MaLopSV;
                label_HOVATEN.Text = Program.mHoten;
                label_TENLOP.Text = Program.TenLopSV;
            }
            try
            {
                this.sP_tabelTimKiemTableAdapter.Fill(this.dS.SP_tabelTimKiem, Program.MaLopSV);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            labelMAMH.Visible = labelDiem.Visible = label_DIEM.Visible = false;
            gb_dang_thi.Visible = gbTime.Visible = false;
            btnChonMonThi.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = btnNopBai.Enabled = false;
            dict.Add(0, "A");
            dict.Add(1, "B");
            dict.Add(2, "C");
            dict.Add(3, "D");
        }
        private DataTable layDeThi()
        {
            DataTable dtDeThi = new DataTable();
            String sqlDeThi = "EXEC SP_DeThi @MaMH, @TrinhDo, @SoCau";
            Hashtable parasDeThi = new Hashtable();
            parasDeThi.Add("@MaMH", labelMAMH.Text);
            parasDeThi.Add("@TrinhDo", labelTRINHDO.Text);
            parasDeThi.Add("@SoCau", labelSOCAUTHI.Text);
            try
            {
                dtDeThi = Program.ExecSqlDataTable(sqlDeThi, parasDeThi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dề thi \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            return dtDeThi;
        }
        private void btnBDThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String sqlTaoBangThiTam = "EXEC SP_TaoBangThiTam";

            if (Program.ExecSqlNonQuery(sqlTaoBangThiTam) != 0)
            {
                MessageBox.Show("Lỗi tạo bảng tạm");
                return;
            }

            DataTable dtDeThi = layDeThi();
            bdsDethi = new BindingSource();
            bdsDethi.DataSource = dtDeThi;
            for (int i = 0; i < bdsDethi.Count; i++)
            {
                rdgCauHoi.Properties.Items.Add(new RadioGroupItem(i+1, "Câu " + (i+1)));
                deThi.Add(layCauHoi(i));
                deThi[i].ThuTu = i;
            }

            rdgCauHoi.SelectedIndex = 0;
            Diem1Cau = 10.0 / Double.Parse(labelSOCAUTHI.Text);
            btnBDThi.Enabled = btnThoat.Enabled = gcSpTimKiem.Visible = btnBDThi.Enabled = false;
            gb_dang_thi.Visible = gbTime.Visible = btnChonMonThi.Enabled = btnNopBai.Enabled = true;

            phut = (int)numberTHOIGIAN.Value - 1;
            giay = 60;
            Timer timer = new Timer();
            timer.Interval = 1000; // thiết lập interval là 1000 milliseconds = 1 giây
            timer.Tick += timer1_Tick; // thêm sự kiện Tick cho Timer
            timer.Start(); //bắt đầu đếm ngược
        }
        public int[] Random(int[] dapAns)
        {
            MessageBox.Show("TRƯỚC RAN: " + dapAns[0] + dapAns[1] + dapAns[2] + dapAns[3]);
            Random random = new Random();
            int[] viTris = new int[dapAns.Length];

            for (int i = 0; i < dapAns.Length; i++)
                viTris[i] = i;

            int index;
            for (int i = 0; i < dapAns.Length; i++)
            {
                index = random.Next(i, dapAns.Length-1);
                int temp = dapAns[i];
                dapAns[i] = dapAns[index];
                dapAns[index] = temp;
            }
            MessageBox.Show("SAU RAN: " + dapAns[0] + dapAns[1] + dapAns[2] + dapAns[3]);
            return dapAns;
        }
        private CauHoi layCauHoi(int vitri)
        {
            CauHoi cauHoi = new CauHoi();
            cauHoi.IDCauHoi = ((DataRowView)bdsDethi[vitri])["CAUHOI"].ToString().Trim();
            cauHoi.ThuTu = -1;
            cauHoi.MaMH = ((DataRowView)bdsDethi[vitri])["MAMH"].ToString().Trim();
            cauHoi.MaGV = ((DataRowView)bdsDethi[vitri])["MAGV"].ToString().Trim();
            cauHoi.TrinhDo = ((DataRowView)bdsDethi[vitri])["TRINHDO"].ToString().Trim();
            cauHoi.NoiDung = ((DataRowView)bdsDethi[vitri])["NOIDUNG"].ToString().Trim();

            int[] thuTuDapAns = new int[4];
            for (int i=0; i<4; i++) thuTuDapAns[i]=i;
            cauHoi.ThuTuDapAnRandom = Random(thuTuDapAns).ToArray();

            cauHoi.DapAnABCD[cauHoi.ThuTuDapAnRandom[0]] = ((DataRowView)bdsDethi[vitri])["A"].ToString().Trim();
            cauHoi.DapAnABCD[cauHoi.ThuTuDapAnRandom[1]] = ((DataRowView)bdsDethi[vitri])["B"].ToString().Trim();
            cauHoi.DapAnABCD[cauHoi.ThuTuDapAnRandom[2]] = ((DataRowView)bdsDethi[vitri])["C"].ToString().Trim();
            cauHoi.DapAnABCD[cauHoi.ThuTuDapAnRandom[3]] = ((DataRowView)bdsDethi[vitri])["D"].ToString().Trim();

            MessageBox.Show("DÁP ÁN TRƯỚC RAN: "+ ((DataRowView)bdsDethi[vitri])["DAP_AN"].ToString().Trim());
            switch (((DataRowView)bdsDethi[vitri])["DAP_AN"].ToString().Trim())
            {
                case "A":
                    cauHoi.DapAn = dict[cauHoi.ThuTuDapAnRandom[0]];
                    break;
                case "B":
                    cauHoi.DapAn = dict[cauHoi.ThuTuDapAnRandom[1]];
                    break;
                case "C":
                    cauHoi.DapAn = dict[cauHoi.ThuTuDapAnRandom[2]];
                    break;
                case "D":
                    cauHoi.DapAn = dict[cauHoi.ThuTuDapAnRandom[3]];
                    break;
            }
            MessageBox.Show("ĐÁP ÁN SAU RAN: " + cauHoi.DapAn);

            cauHoi.DaChonRandom = "X";
            cauHoi.DaChon = "X";

            String sqlThemBangTam = "EXEC SP_ThemBangThiTam @CAUHOI, @MAMH, @MASV, @LAN, @ARANDOM, " +
                                    "@BRANDOM, @CRANDOM, @DRANDOM, @DAP_AN, @DACHONRANDOM";

            Hashtable parasThemBangTam = new Hashtable();

            parasThemBangTam.Add("@CAUHOI", cauHoi.IDCauHoi);
            parasThemBangTam.Add("@MAMH", labelMAMH.Text);
            parasThemBangTam.Add("@MASV", Program.username);
            parasThemBangTam.Add("@LAN", labelLAN.Text);
            parasThemBangTam.Add("@ARANDOM", cauHoi.DapAnABCD[0]);
            parasThemBangTam.Add("@BRANDOM", cauHoi.DapAnABCD[1]);
            parasThemBangTam.Add("@CRANDOM", cauHoi.DapAnABCD[2]);
            parasThemBangTam.Add("@DRANDOM", cauHoi.DapAnABCD[3]);
            parasThemBangTam.Add("@DAP_AN", cauHoi.DapAn);
            parasThemBangTam.Add("@DACHONRANDOM", cauHoi.DaChonRandom);

            if (Program.ExecSqlNonQuery(sqlThemBangTam, parasThemBangTam) != 0)
                MessageBox.Show("Lỗi thêm bảng tạm câu hỏi " + vitri);

            return cauHoi;
        }
        private void rdgDapAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdgDapAn.SelectedIndex != -1)
            {
                deThi[rdgCauHoi.SelectedIndex].DaChonRandom = rdgDapAn.EditValue.ToString();

                rdgCauHoi.Properties.Items.GetItemByValue(rdgCauHoi.SelectedIndex+1).Description
                            = "Câu " + rdgCauHoi.EditValue.ToString() + ":  " + deThi[rdgCauHoi.SelectedIndex].DaChonRandom;

                switch (deThi[rdgCauHoi.SelectedIndex].DaChonRandom)
                {
                    case "A":
                        rdgDapAn.SelectedIndex = 0;
                        deThi[rdgCauHoi.SelectedIndex].DaChon = dict[deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[0]];
                        break;
                    case "B":
                        rdgDapAn.SelectedIndex = 1;
                        deThi[rdgCauHoi.SelectedIndex].DaChon = dict[deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[1]];
                        break;
                    case "C":
                        rdgDapAn.SelectedIndex = 2;
                        deThi[rdgCauHoi.SelectedIndex].DaChon = dict[deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[2]];
                        break;
                    case "D":
                        rdgDapAn.SelectedIndex = 3;
                        deThi[rdgCauHoi.SelectedIndex].DaChon = dict[deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[3]];
                        break;
                    case "X":
                        rdgDapAn.SelectedIndex = -1;
                        deThi[rdgCauHoi.SelectedIndex].DaChon = "X";
                        break;
                }
            }
        }
        private void rdgCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdgDapAn.SelectedIndex = -1;
            rdgDapAn.Properties.Items.Clear();
            labelCauSo.Text = "Câu " + rdgCauHoi.EditValue.ToString() + ": ";
            labelCauHoi.Text = deThi[rdgCauHoi.SelectedIndex].NoiDung;

            rdgDapAn.Properties.Items.Add(new RadioGroupItem("A", "A. " + deThi[rdgCauHoi.SelectedIndex].DapAnABCD[deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[0]]));
            rdgDapAn.Properties.Items.Add(new RadioGroupItem("B", "B. " + deThi[rdgCauHoi.SelectedIndex].DapAnABCD[deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[1]]));
            rdgDapAn.Properties.Items.Add(new RadioGroupItem("C", "C. " + deThi[rdgCauHoi.SelectedIndex].DapAnABCD[deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[2]]));
            rdgDapAn.Properties.Items.Add(new RadioGroupItem("D", "D. " + deThi[rdgCauHoi.SelectedIndex].DapAnABCD[deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[3]]));

        }
        private void tongDiem()
        {
            foreach (CauHoi cauHoi in deThi)
            {
                if (cauHoi.DaChonRandom == cauHoi.DapAn)
                {
                    TongDiem += Diem1Cau;
                }
            }

            if (TongDiem - Math.Floor(TongDiem) != 0 & TongDiem - Math.Floor(TongDiem) != 0.5) //!8.0 và !8.5
                if (TongDiem - Math.Floor(TongDiem) > 0.5)
                    TongDiem = Math.Floor(TongDiem) + 1;
                else TongDiem = Math.Floor(TongDiem) + 0.5;
        }
        private void InsertTableBangDiemVaBaiThi()
        {
            if (Program.mGroup == "SinhVien")
            {
                try
                {
                    String sqlThemBangDiem = "INSERT INTO BANGDIEMB ( MASV, MAMH , LAN , NGAYTHI , DIEM  ) VALUES(@UserName, @MaMH, @Lan, GETDATE(), @Diem)";
                    Hashtable parasThongTin = new Hashtable();
                    parasThongTin.Add("@UserName", Program.username);
                    parasThongTin.Add("@MaMH", labelMAMH.Text);
                    parasThongTin.Add("@Lan", labelLAN.Text);
                    parasThongTin.Add("@Diem", TongDiem.ToString());
                    
                    if (Program.ExecSqlNonQuery(sqlThemBangDiem, parasThongTin) == 0)
                    {
                        String sqlLayBaiThi = "SELECT ID FROM [dbo].[BANGDIEM] WHERE MASV=@UserName AND LAN=@Lan AND MAMH=@MaMH";
                        Hashtable parasLayBaiThi = new Hashtable();
                        parasLayBaiThi.Add("@UserName", Program.username);
                        parasLayBaiThi.Add("@MaMH", labelMAMH.Text);
                        parasLayBaiThi.Add("@Lan", labelLAN.Text);

                        Program.myReader = Program.ExecSqlDataReader(sqlLayBaiThi, parasLayBaiThi);
                        MessageBox.Show("TRƯỚC null");
                        if (Program.myReader == null)       return;
                        MessageBox.Show("sau null");
                        Program.myReader.Read();
                        int ID_BANGDIEM = Program.myReader.GetInt32(0);
                        Program.myReader.Close();

                        String sqlThemBaiThi;
                        Hashtable parasThemBaiThi = new Hashtable();
                        MessageBox.Show("TRƯỚC FOR");
                        foreach (CauHoi cauHoi in deThi)
                        {
                            MessageBox.Show("@IdBangDiem: " + ID_BANGDIEM + "@CauHoi: " + cauHoi.IDCauHoi + "@ThuTu: " + cauHoi.ThuTu + "@DaChon: " + cauHoi.DaChon + "@DaChonRandom: " + cauHoi.DaChonRandom);
                            sqlThemBaiThi = "INSERT INTO BAITHI ( ID_BANGDIEM, CAUHOI, THUTU, DACHON) VALUES(@IdBangDiem, @CauHoi, @ThuTu, @DaChon)";
                            parasThemBaiThi.Add("@IdBangDiem", ID_BANGDIEM);
                            parasThemBaiThi.Add("@CauHoi", cauHoi.IDCauHoi);
                            parasThemBaiThi.Add("@ThuTu", cauHoi.ThuTu);
                            parasThemBaiThi.Add("@DaChon", cauHoi.DaChon);

                            if (Program.ExecSqlNonQuery(sqlThemBaiThi) != 0)
                                MessageBox.Show("Lỗi sửa bài thi! Câu hỏi: " + cauHoi.NoiDung, "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("" + e.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }
        private void xuLiSauNopBai()
        {
            tongDiem();
            InsertTableBangDiemVaBaiThi();
            timer1.Stop();
            phut = 0;
            giay = 0;
            labelCONLAI.Text = $"{phut:00}:{giay:00}";
            btnThoat.Enabled = true;
            btnNopBai.Enabled = false;
            rdgDapAn.Properties.Items.Clear();
            rdgCauHoi.Properties.Items.Clear();
            label_DIEM.Text = TongDiem.ToString();
            label_DIEM.Visible = labelDiem.Visible = true;

            String sqlXoaBaiThi = "exec SP_XoaBangThiTam";
            if (Program.ExecSqlNonQuery(sqlXoaBaiThi) != 0)
                MessageBox.Show("Lỗi xóa tabel tạm bài thi! ", "Thông báo", MessageBoxButtons.OK);
        }
        private void btnNopBai_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (phut != 0 && giay != 0)
            {
                if (MessageBox.Show("Chưa hết thời gian, bạn có muốn nộp bài?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (CauHoi cauHoi in deThi)
                    {
                        if (cauHoi.DaChonRandom == "X")
                        {
                            if (MessageBox.Show("Chưa chọn hết đáp án, bạn có muốn nộp bài?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                xuLiSauNopBai();
                            return;
                        }
                    }
                    xuLiSauNopBai();
                }
                else
                    return;
            }
        }
        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void btnChonMonThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            gb_dang_thi.Visible = gbTime.Visible = labelMaLop.Visible = label_MALOP.Visible = false;
            btnChonMonThi.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = btnNopBai.Enabled = false;
            btnBDThi.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            giay--;
            if (giay == 0)
            {
                phut--;
                giay = 60;
            }
            if (phut == 0 && giay == 0)
            {
                xuLiSauNopBai();
            }
            labelCONLAI.Text = $"{phut:00}:{giay:00}";
        }
    }
}
