using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFoodCourt
{
    public class BeefSteak : Food
    {
        public BeefSteak(double price, string name, int sizeID)
        {
            Price = price;
            Name = name;
            SizeID = sizeID;
        }

        public override Food Cook()
        {
            Food dish;
            dish = new BeefSteak(Price, Name, SizeID);
            return dish;
        }
    }
}