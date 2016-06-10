using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoPublisherSubscriber
{
    public class WebsiteFIT
    {
        static public List<Tin>[] BaiVietMoi = new List<Tin>[3];
        static public int[] ThoiGianDelay = new int[3];

        internal static void BoSungBaiViet(string noidung, List<string> tukhoa, int uuTien)
        {
            Tin tinMoi = TaoTinMoi(noidung, tukhoa);

            BaiVietMoi[uuTien-1].Add(tinMoi);
            if (uuTien==1)
                ThongBaoSV(tinMoi);
        }

        private static int counter = 0;
        public static void OnTimer()
        {
            counter++;
            for (int i=1; i<3; i++) // i==0 ==> realtime, da gui ngay khi co tin moi
            {
                if (counter % ThoiGianDelay[i] == 0) // den thoi diem can gui
                    ThongBaoCacTinMoi(i);
            }
            
        }

        private static void ThongBaoCacTinMoi(int i)
        {
            foreach (Tin tin in BaiVietMoi[i])
                ThongBaoSV(tin);
        }

        private static List<SinhVien> dssv = new List<SinhVien>();

        private static void ThongBaoSV(Tin tinMoi)
        {
            foreach (SinhVien sv in dssv)
            {
                if (CanThongBao(sv, tinMoi))
                    sv.CoTinMoi(tinMoi);
            }
        }

        private static bool CanThongBao(SinhVien sv, Tin tinMoi)
        {
            return NewsRecommenderSystem.IsAppropriate(sv, tinMoi);
        }

        internal static void BoSungSinhVien(SinhVien sinhVien)
        {
            dssv.Add(sinhVien);
        }

        private static Tin TaoTinMoi(string noidung, List<string> tukhoa)
        {
            Tin tin = new Tin(noidung, tukhoa);
            return tin;
        }
    }
}