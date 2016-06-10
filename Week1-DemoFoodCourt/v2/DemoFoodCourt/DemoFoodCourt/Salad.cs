using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFoodCourt
{
    public class Salad : Food
    {
        public Salad(double price, string name, int sizeID)
        {
            Price = price;
            Name = name;
            SizeID = sizeID;
        }

        public override Food Cook()
        {
            Food dish;
            dish = new Salad(Price, Name, SizeID);
            return dish;
        }

    }
}