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
            SinhVien sv;
            sv = new SinhVien("1312181", "Nguyen Phuc Hau");
            sv = new SinhVien("1312375", "Tran Tu Nam");
            sv = new SinhVien("1312016", "Nguyen Thanh An");
            List<string> tukhoa;
            tukhoa = new List<string>();
            tukhoa.Add("kw1"); tukhoa.Add("kw2");
            IS.GuiTin("Thong bao cua bo mon HTTT 001",tukhoa);
            tukhoa.Clear(); tukhoa.Add("kw3");
            CS.GuiTin("Thong bao cua bo mon KHMT 001", tukhoa);
            CS.GuiTin("Thong bao cua bo mon KHMT 002", tukhoa);
        }
    }
}
