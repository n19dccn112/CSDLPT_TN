using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    class CauHoi
    {
        private string iDCauHoi;
        private int thuTu;
        private string maMH;
        private string maGV;
        private string trinhDo;
        private string noiDung;
        private int[] thuTuDapAnRandom = new int[4];
        private string[] dapAnABCD = new string[4];
        private string dapAn;
        private string daChonRandom;
        private string daChon;

        public CauHoi()
        {
        }

        public int ThuTu { get => thuTu; set => thuTu = value; }
        public string MaMH { get => maMH; set => maMH = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string DapAn { get => dapAn; set => dapAn = value; }
        public string DaChon { get => daChon; set => daChon = value; }
        public string IDCauHoi { get => iDCauHoi; set => iDCauHoi = value; }
        public string[] DapAnABCD { get => dapAnABCD; set => dapAnABCD = value; }
        public int[] ThuTuDapAnRandom { get => thuTuDapAnRandom; set => thuTuDapAnRandom = value; }
        public string DaChonRandom { get => daChonRandom; set => daChonRandom = value; }
    }
}
