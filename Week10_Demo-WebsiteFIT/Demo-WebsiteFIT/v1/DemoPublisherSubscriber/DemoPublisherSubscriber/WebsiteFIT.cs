using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoPublisherSubscriber
{
    public class WebsiteFIT
    {
        static public List<Tin> BaiVietMoi = new List<Tin>();

        internal static void BoSungBaiViet(string noidung, List<string> tukhoa)
        {
            Tin tinMoi = TaoTinMoi(noidung, tukhoa);
            BaiVietMoi.Add(tinMoi);
            ThongBaoSV(tinMoi);
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
            return true;
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