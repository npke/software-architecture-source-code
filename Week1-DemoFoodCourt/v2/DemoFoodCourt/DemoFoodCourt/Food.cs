using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFoodCourt
{
    public abstract class Food
    {
        protected double _price;
        protected string _name;
        protected int _sizeID;

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int SizeID
        {
            get
            {
                return _sizeID;
            }

            set
            {
                _sizeID = value;
            }
        }

        public abstract Food Cook();
    }
}