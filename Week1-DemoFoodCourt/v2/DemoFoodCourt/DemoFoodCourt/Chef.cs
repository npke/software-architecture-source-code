using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFoodCourt
{
    public class Chef
    {
        /*        public Food ProcessOrder(string name)
                {
                    Food dish;
                    if ("Salad" == name)
                        dish = new Salad();
                    else if ("Fried Chicken" == name)
                        dish = new FriedChicken();
                    //.........
                    else // last option
                        dish = GiveBestOption();
                    return dish;

                }*/
        public Food ProcessOrder(string name)
        {
            Food dish = null;
            for (int i = 0; i < menu.Count; i++)
                if (IsMatchByName(name, menu[i].Name))
                    dish = menu[i].Cook(); // Clone
            if (null == dish)
                dish = GiveBestOption();
            return dish;

        }

        private bool IsMatchByName(string name1, string name2)
        {
            return name1 == name2;
        }

        private Food GiveBestOption()
        {
            return menu[0].Cook();
        }

        private List<Food> menu = new List<Food>();


        public void InitMenu()
        {
            menu = new List<Food>();
            menu.Add(new BeefSteak(8.5, "Beef Steak - Small", 1));
            menu.Add(new BeefSteak(10, "Beef Steak - Medium", 2));
            menu.Add(new BeefSteak(11, "Beef Steak - Large", 3));
            menu.Add(new Salad(7, "Salad", 3));
            menu.Add(new FriedChicken(8.75, "Fried Chicken- Small", 1));
            menu.Add(new BoiledChicken(8.5, "Boiled Chicken- Small", 1));


            menu.Add(new FriedChicken(5.75, "Fried Chicken- Small", 1));
        }

        public Food ProcessOrder(double minPrice, double maxPrice)
        {
            // Developer oriented!!!
            for (int i = 0; i < menu.Count; i++)
                if (menu[i].Price >= minPrice && menu[i].Price <= maxPrice)
                    return ProcessOrder(menu[i].Name);

            return ProcessOrderInExceptionCaseWithPrice(minPrice, maxPrice);

        }

        private Food ProcessOrderInExceptionCaseWithPrice(double minPrice, double maxPrice)
        {
            return menu[0].Cook();
        }
    }
}