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
//            ThongBaoSV(tinMoi);
        }
        private static Tin TaoTinMoi(string noidung, List<string> tukhoa)
        {
            Tin tin = new Tin(noidung, tukhoa);
            return tin;
        }

        internal static List<Tin> LocTinTuc(SinhVien sv)
        {
            List<Tin> kq = new List<Tin>();
            foreach (Tin baiviet in BaiVietMoi)
                if (NewsRecommenderSystem.IsAppropriate(sv, baiviet))
                    kq.Add(baiviet);
            return kq;
        }
    }
}