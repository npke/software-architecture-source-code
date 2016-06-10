using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffDemo
{
    class Program
    {
        static Hero[] h = new Hero[5];
        static void Main(string[] args)
        {

            h[0] = new Hero(50, "Võ Đang");
            h[1] = new Hero(100, "Thiếu Lâm");
            h[2] = new Hero(50, "Nga My");
            h[3] = new Hero(70, "Thúy Yên");
            h[4] = new Hero(90, "Thiên Vương");

            h[0].SetTarget(h[3]);
            h[0].OnBuff();

            h[0].SetTarget(h[4]);
            h[0].OnBuff();

            DisplayAll();

        }

        private static void DisplayAll()
        {
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Hero " + (i + 1).ToString());
                Console.WriteLine("Name:" + h[i].Name+" - HP: " +h[i].HP);

            }
        }
    }
}


