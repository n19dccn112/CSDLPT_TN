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
                labelMaLop.Text = "MÃ GV:";
                labelTenLop.Text = "TÊN GV: ";
                label_MALOP.Text = Program.username;
                label_TENLOP.Text = Program.mHoten;
                label_HOVATEN.Visible = labelHoVaTen.Visible = false;
            }
            else
            {
                label_MALOP.Text = Program.MaLopSV;
                label_HOVATEN.Text = Program.mHoten;
                label_TENLOP.Text = Program.TenLopSV;
            }
            try
            {
                this.sP_tabelTimKiemTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_tabelTimKiemTableAdapter.Fill(this.dS.SP_tabelTimKiem, Program.username);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            labelMAMH.Visible = labelDiem.Visible = label_DIEM.Visible = false;
            rdgCauHoi.Visible = labelCauSo.Visible = labelCauHoi.Visible = rdgDapAn.Visible = gbTime.Visible = false;
            btnChonMonThi.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = btnNopBai.Enabled = btnThiTiep.Enabled = btnBDThi.Enabled = false;
            dict.Add(0, "A");
            dict.Add(1, "B");
            dict.Add(2, "C");
            dict.Add(3, "D");

        }

        private DataTable layDeThiTiep()
        {
            DataTable dtDeThiDangThi = new DataTable();
            String sqlDeThi = "EXEC SP_DeThiDangThi @MAMH, @MASV, @LAN";

            Hashtable parasDeThiDangThi = new Hashtable();
            parasDeThiDangThi.Add("@MAMH", labelMAMH.Text);
            parasDeThiDangThi.Add("@MASV", Program.username);
            parasDeThiDangThi.Add("@LAN", Convert.ToInt32(label_LAN.Text));
            try
            {
                dtDeThiDangThi = Program.ExecSqlDataTable(sqlDeThi, parasDeThiDangThi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dề thi \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            return dtDeThiDangThi;
        }

        private DataTable layDeThi()
        {
            DataTable dtDeThi = new DataTable();
            String sqlDeThi = "EXEC SP_DeThi @MaMH, @TrinhDo, @SoCau";
            Hashtable parasDeThi = new Hashtable();
            parasDeThi.Add("@MaMH", labelMAMH.Text);
            parasDeThi.Add("@TrinhDo", label_TRINHDO.Text);
            parasDeThi.Add("@SoCau", label_SOCAUTHI.Text);
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

        private void btnThiTiep_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataTable dtDeThi = layDeThiTiep();
            bdsDethi = new BindingSource();
            bdsDethi.DataSource = dtDeThi;

            for (int i = 0; i < bdsDethi.Count; i++)
            {
                rdgCauHoi.Properties.Items.Add(new RadioGroupItem(i + 1, "Câu " + (i + 1)));
                deThi.Add(layCauHoThiTiep(i));
                deThi[i].ThuTu = i;
            }

            rdgCauHoi.SelectedIndex = 0;
            Diem1Cau = 10.0 / Double.Parse(label_SOCAUTHI.Text);
            btnBDThi.Enabled = btnThoat.Enabled = gcSpTimKiem.Visible = btnThiTiep.Enabled = false;
            rdgCauHoi.Visible = labelCauSo.Visible = labelCauHoi.Visible = rdgDapAn.Visible = gbTime.Visible = btnChonMonThi.Enabled = btnNopBai.Enabled = true;

            phut = Convert.ToInt32(label_THOIGIAN.Text) - 1;
            giay = 60;
            Timer timer = new Timer();
            timer.Interval = 1000; // thiết lập interval là 1000 milliseconds = 1 giây
            timer.Tick += timer1_Tick; // thêm sự kiện Tick cho Timer
            timer.Start(); //bắt đầu đếm ngược
        }

        private void btnBDThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dtDeThi = layDeThi();
            bdsDethi = new BindingSource();
            bdsDethi.DataSource = dtDeThi;

            String sqlThemBangTam = "EXEC SP_ThemBangThiTam @CAUHOI, @THUTU, @MAMH, @MASV, @LAN, @ARANDOM, " +
                                  "@BRANDOM, @CRANDOM, @DRANDOM, @DACHON";

            for (int i = 0; i < bdsDethi.Count; i++)
            {
                rdgCauHoi.Properties.Items.Add(new RadioGroupItem(i+1, "Câu " + (i+1)));
                deThi.Add(layCauHoi(i));
                deThi[i].ThuTu = i+1;
                Hashtable parasThemBangTam = new Hashtable();

                parasThemBangTam.Add("@MAMH", labelMAMH.Text);
                parasThemBangTam.Add("@MASV", Program.username);
                parasThemBangTam.Add("@LAN", Convert.ToInt32(label_LAN.Text));
                parasThemBangTam.Add("@CAUHOI", Convert.ToInt32(deThi[i].IDCauHoi));
                parasThemBangTam.Add("@THUTU", i);
                parasThemBangTam.Add("@ARANDOM", deThi[i].ThuTuDapAnRandom[0]);
                parasThemBangTam.Add("@BRANDOM", deThi[i].ThuTuDapAnRandom[1]);
                parasThemBangTam.Add("@CRANDOM", deThi[i].ThuTuDapAnRandom[2]);
                parasThemBangTam.Add("@DRANDOM", deThi[i].ThuTuDapAnRandom[3]);
                parasThemBangTam.Add("@DACHON", deThi[i].DaChon);

                if (Program.ExecSqlNonQuery(sqlThemBangTam, parasThemBangTam) != 0)
                    MessageBox.Show("Lỗi thêm bảng tạm câu hỏi " + i);
            }

            rdgCauHoi.SelectedIndex = 0;
            Diem1Cau = 10.0 / Double.Parse(label_SOCAUTHI.Text);
            btnBDThi.Enabled = btnThoat.Enabled = gcSpTimKiem.Visible = btnThiTiep.Enabled = false;
            rdgCauHoi.Visible = labelCauSo.Visible = labelCauHoi.Visible = rdgDapAn.Visible = gbTime.Visible = btnChonMonThi.Enabled = btnNopBai.Enabled = true;

            phut = Convert.ToInt32(label_THOIGIAN.Text) - 1;
            giay = 60;
            Timer timer = new Timer();
            timer.Interval = 1000; // thiết lập interval là 1000 milliseconds = 1 giây
            timer.Tick += timer1_Tick; // thêm sự kiện Tick cho Timer
            timer.Start(); //bắt đầu đếm ngược
        }

        public int[] Random(int[] dapAns)
        {
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

            cauHoi.DapAn = ((DataRowView)bdsDethi[vitri])["DAP_AN"].ToString().Trim();
            cauHoi.DaChonRandom = "X";
            cauHoi.DaChon = "X";

            return cauHoi;
        }

        private CauHoi layCauHoThiTiep(int vitri)
        {
            CauHoi cauHoi = new CauHoi();
            cauHoi.IDCauHoi = ((DataRowView)bdsDethi[vitri])["CAUHOI"].ToString().Trim();
            cauHoi.ThuTu = Convert.ToInt32(((DataRowView)bdsDethi[vitri])["THUTU"].ToString().Trim());
            cauHoi.MaMH = ((DataRowView)bdsDethi[vitri])["MAMH"].ToString().Trim();
            cauHoi.TrinhDo = ((DataRowView)bdsDethi[vitri])["TRINHDO"].ToString().Trim();
            cauHoi.NoiDung = ((DataRowView)bdsDethi[vitri])["NOIDUNG"].ToString().Trim();

            int[] thuTuDapAns = new int[4];
            thuTuDapAns[0] = Convert.ToInt32(((DataRowView)bdsDethi[vitri])["ARANDOM"].ToString().Trim());
            thuTuDapAns[1] = Convert.ToInt32(((DataRowView)bdsDethi[vitri])["BRANDOM"].ToString().Trim());
            thuTuDapAns[2] = Convert.ToInt32(((DataRowView)bdsDethi[vitri])["CRANDOM"].ToString().Trim());
            thuTuDapAns[3] = Convert.ToInt32(((DataRowView)bdsDethi[vitri])["DRANDOM"].ToString().Trim());
            cauHoi.ThuTuDapAnRandom = Random(thuTuDapAns).ToArray();

            cauHoi.DapAnABCD[cauHoi.ThuTuDapAnRandom[0]] = ((DataRowView)bdsDethi[vitri])["A"].ToString().Trim();
            cauHoi.DapAnABCD[cauHoi.ThuTuDapAnRandom[1]] = ((DataRowView)bdsDethi[vitri])["B"].ToString().Trim();
            cauHoi.DapAnABCD[cauHoi.ThuTuDapAnRandom[2]] = ((DataRowView)bdsDethi[vitri])["C"].ToString().Trim();
            cauHoi.DapAnABCD[cauHoi.ThuTuDapAnRandom[3]] = ((DataRowView)bdsDethi[vitri])["D"].ToString().Trim();

            cauHoi.DapAn = ((DataRowView)bdsDethi[vitri])["DAP_AN"].ToString().Trim();
            cauHoi.DaChon = ((DataRowView)bdsDethi[vitri])["DACHON"].ToString().Trim();

            switch (cauHoi.DaChon)
            {
                case "A":
                    cauHoi.DaChonRandom = dict[cauHoi.ThuTuDapAnRandom[0]];
                    break;
                case "B":
                    cauHoi.DaChonRandom = dict[cauHoi.ThuTuDapAnRandom[1]];
                    break;
                case "C":
                    cauHoi.DaChonRandom = dict[cauHoi.ThuTuDapAnRandom[2]];
                    break;
                case "D":
                    cauHoi.DaChonRandom = dict[cauHoi.ThuTuDapAnRandom[3]];
                    break;
            }

            return cauHoi;
        }

        private void tongDiem()
        {
            foreach (CauHoi cauHoi in deThi)
            {
                if (cauHoi.DaChon == cauHoi.DapAn)
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
                String sql = "exec SP_ThemBangDiemVaBaiThi @MASV, @MaMH, @Lan, @Diem";

                Hashtable paras = new Hashtable();
                paras.Add("@MASV", Program.username);
                paras.Add("@MaMH", labelMAMH.Text);
                paras.Add("@Lan", Convert.ToInt32(label_LAN.Text));
                paras.Add("@Diem", Convert.ToInt32(TongDiem));

                if (Program.ExecSqlNonQuery(sql, paras) != 0)
                {
                    MessageBox.Show("Lỗi thêm bảng điểm và bài thi " , "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                String sql = "EXEC SP_XoaBangTam @MASV";
                Hashtable paras = new Hashtable();
                paras.Add("@MASV", Program.username);
                if (Program.ExecSqlNonQuery(sql, paras) != 0)
                {
                    MessageBox.Show("Lỗi Xóa bảng thi tạm ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void xuLiSauNopBai()
        {
            tongDiem();
            InsertTableBangDiemVaBaiThi();

            phut = 0;
            giay = 0;
            labelCONLAI.Text = $"{phut:00}:{giay:00}";
            timer1.Stop();
            btnThoat.Enabled = true;
            btnNopBai.Enabled = false;
            rdgDapAn.Properties.Items.Clear();
            rdgCauHoi.Properties.Items.Clear();
            label_DIEM.Text = TongDiem.ToString();
            label_DIEM.Visible = labelDiem.Visible = true;
            labelCauSo.Visible = labelCauHoi.Visible = false;
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

        private void rdgDapAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdgDapAn.SelectedIndex != -1)
            {
                deThi[rdgCauHoi.SelectedIndex].DaChonRandom = rdgDapAn.EditValue.ToString();

                rdgCauHoi.Properties.Items.GetItemByValue(rdgCauHoi.SelectedIndex + 1).Description
                            = "Câu " + rdgCauHoi.EditValue.ToString() + ":  " + deThi[rdgCauHoi.SelectedIndex].DaChonRandom;

                switch (deThi[rdgCauHoi.SelectedIndex].DaChonRandom)
                {
                    case "A":
                        for (int i = 0; i < 4; i++)
                            if (deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[i] == 0)
                            {
                                deThi[rdgCauHoi.SelectedIndex].DaChon = dict[i];
                                break;
                            }
                        break;
                    case "B":
                        for (int i = 0; i < 4; i++)
                            if (deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[i] == 1)
                            {
                                deThi[rdgCauHoi.SelectedIndex].DaChon = dict[i];
                                break;
                            }
                        break;
                    case "C":
                        for (int i = 0; i < 4; i++)
                            if (deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[i] == 2)
                            {
                                deThi[rdgCauHoi.SelectedIndex].DaChon = dict[i];
                                break;
                            }
                        break;
                    case "D":
                        for (int i = 0; i < 4; i++)
                            if (deThi[rdgCauHoi.SelectedIndex].ThuTuDapAnRandom[i] == 3)
                            {
                                deThi[rdgCauHoi.SelectedIndex].DaChon = dict[i];
                                break;
                            }
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

            rdgDapAn.Properties.Items.Add(new RadioGroupItem("A", "A. " + deThi[rdgCauHoi.SelectedIndex].DapAnABCD[0]));
            rdgDapAn.Properties.Items.Add(new RadioGroupItem("B", "B. " + deThi[rdgCauHoi.SelectedIndex].DapAnABCD[1]));
            rdgDapAn.Properties.Items.Add(new RadioGroupItem("C", "C. " + deThi[rdgCauHoi.SelectedIndex].DapAnABCD[2]));
            rdgDapAn.Properties.Items.Add(new RadioGroupItem("D", "D. " + deThi[rdgCauHoi.SelectedIndex].DapAnABCD[3]));
        }

        private void btnChonMonThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            rdgCauHoi.Visible = labelCauSo.Visible = labelCauHoi.Visible = rdgDapAn.Visible = gbTime.Visible = labelMaLop.Visible = label_MALOP.Visible = false;
            btnChonMonThi.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = btnNopBai.Enabled = false;
        }

        private void gvSpTimKiem_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DateTime now = DateTime.Now;
            string ngaygio = now.ToString("d/M/yyyy");

            string strLenh = "SELECT COUNT(*) FROM tempTableThi WHERE MASV='" + Program.username + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int count = Program.myReader.GetInt32(0);
            Program.conn.Close();
            Program.myReader.Close();
            MessageBox.Show("1. now: " + ngaygio + "= sp: " + label_NGAYTHI.Text, "");
            if (label_NGAYTHI.Text.Equals(ngaygio))
            {
                MessageBox.Show("2. now: " + ngaygio + "= sp: " + label_NGAYTHI.Text, "");
                if (count != 0)
                {
                    btnThiTiep.Enabled = true;
                    btnBDThi.Enabled = false;
                }
                else
                {
                    btnThiTiep.Enabled = false;
                    btnBDThi.Enabled = true;
                }
            }
        }

        private void btnReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.sP_tabelTimKiemTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_tabelTimKiemTableAdapter.Fill(this.dS.SP_tabelTimKiem, Program.username);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (phut != 0 && giay != 0)
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
