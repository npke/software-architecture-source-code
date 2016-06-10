using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCreationalPattern02
{
    public class TownCenter : Building
    {
        public override void PopulateAllUnits()
        {
            base.PopulateAllUnits();

            Unit unit;
            unit = new Farmer();
            prototypes.Add(unit.Name, unit);
            unit = new Worker();
            prototypes.Add(unit.Name, unit);
        }
    }
}