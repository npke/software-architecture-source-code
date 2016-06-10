using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameAutoAction
{
    public class Farm
    {
        internal void ProduceFood()
        {
            Global.Food += Global.FoodProducedInATurn;
        }
    }
}