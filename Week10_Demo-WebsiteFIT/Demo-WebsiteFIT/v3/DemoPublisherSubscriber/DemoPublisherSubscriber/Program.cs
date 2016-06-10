using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPublisherSubscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            BoMon CS = new BoMon(), IS = new BoMon(), SE = new BoMon(), 
                NT = new BoMon(), KE = new BoMon(), CVR = new BoMon();
            List<string> tukhoaSV;
            tukhoaSV = new List<string>();
            tukhoaSV.Add("kw1"); 
            SinhVien sv;
            sv = new SinhVien("1312181", "Nguyen Phuc Hau");
            sv.TuKhoa = tukhoaSV;

            tukhoaSV = new List<string>();
            tukhoaSV.Add("kw2"); tukhoaSV.Add("kw3");
            sv = new SinhVien("1312375", "Tran Tu Nam");
            sv.TuKhoa = tukhoaSV;

            tukhoaSV = new List<string>();
            sv = new SinhVien("1312016", "Nguyen Thanh An");
            sv.TuKhoa = tukhoaSV;

            List<string> tukhoa;
            tukhoa = new List<string>();
            tukhoa.Add("kw1"); tukhoa.Add("kw2");
            IS.GuiTin("Thong bao cua bo mon HTTT 001",tukhoa, 2);
            tukhoa.Clear(); tukhoa.Add("kw3");
            CS.GuiTin("Thong bao cua bo mon KHMT 001", tukhoa, 1);
            CS.GuiTin("Thong bao cua bo mon KHMT 002", tukhoa, 3);
        }
    }
}
