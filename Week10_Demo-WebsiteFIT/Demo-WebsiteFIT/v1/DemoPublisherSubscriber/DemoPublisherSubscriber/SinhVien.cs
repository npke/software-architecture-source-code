using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoPublisherSubscriber
{
    public class SinhVien
    {
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

        public SinhVien(string mssv, string hoten)
        {
            MSSV = mssv;
            HoTen = hoten;
            WebsiteFIT.BoSungSinhVien(this);
        }

        internal void CoTinMoi(Tin tinMoi)
        {
            Console.WriteLine("Sinh vien " + HoTen + " (MSSV: " + MSSV + ") da doc tin " + tinMoi.NoiDung);
        }
    }
}