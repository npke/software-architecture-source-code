using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoPublisherSubscriber
{
    public class SinhVien
    {
        private List<string> tuKhoa;

        private string mSSV;
        private string hoTen;

        public string MSSV
        {
            get
            {
                return mSSV;
            }

            set
            {
                mSSV = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public List<string> TuKhoa
        {
            get
            {
                return tuKhoa;
            }

            set
            {
                tuKhoa = value;
            }
        }

        public SinhVien(string mssv, string hoten)
        {
            MSSV = mssv;
            HoTen = hoten;
        }

        public void DuyetTinTuc()
        {
            List<Tin> cacBaiViet = WebsiteFIT.LocTinTuc(this);
            foreach (Tin baiviet in cacBaiViet)
                XemTinMoi(baiviet);
        }

        internal void XemTinMoi(Tin tinMoi)
        {
            Console.WriteLine("Sinh vien " + HoTen + " (MSSV: " + MSSV + ") da doc tin " + tinMoi.NoiDung);
        }
    }
}