using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDistributedObject
{
    class Program
    {
        static void Main(string[] args)
        {

            CFilm f1 = new CFilm("Hậu duệ mặt trăng", 5.1f);
            CFilm f2 = new CFilm("Batman & Spiderman", 5.1f);

            Console.WriteLine(f1.TenFilm);
            Console.WriteLine(f2.DanhGia);
            f2.DanhGia = 5.25f;
            f1.DanhGia = 5.25f;
            Console.WriteLine(f2.DanhGia);

        }
    }
}
