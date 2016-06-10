using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCreationalPattern02
{
    public class Barrack : Building
    {
        public override void PopulateAllUnits()
        {
            base.PopulateAllUnits();

            Unit unit;
            unit = new Swordman();
            prototypes.Add(unit.Name, unit);
            unit = new Archer();
            prototypes.Add(unit.Name, unit);
        }

    }
}