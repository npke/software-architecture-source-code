using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFoodCourt
{
    public class FriedChicken : Food
    {
        public FriedChicken(double price, string name, int sizeID)
        {
            Price = price;
            Name = name;
            SizeID = sizeID;
        }

        public override Food Cook()
        {
            Food dish;
            dish = new FriedChicken(Price, Name, SizeID);
            return dish;
        }

        private bool hot;

        public bool Hot
        {
            get
            {
                return hot;
            }

            set
            {
                hot = value;
            }
        }
    }
}