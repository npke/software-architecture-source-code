using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SanPham[] sp = SanPham.TimSanPhamTheoTen("iPhone");
            for (int i = 0; i < sp.Length; i++)
            {
                Console.WriteLine(sp[i].TenSanPham);
            }
            sp[0].TenSanPham = "Smartphone iPhone v6s";

            Console.WriteLine("------");
            sp = SanPham.TimSanPhamTheoTen("iPhone");
            for (int i = 0; i < sp.Length; i++)
            {
                Console.WriteLine(sp[i].TenSanPham);
            }

        }
    }

}

    