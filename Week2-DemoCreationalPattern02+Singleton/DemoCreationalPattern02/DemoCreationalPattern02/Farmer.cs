﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCreationalPattern02
{
    public class Farmer : Unit
    {
        public override Unit Recruit()
        {
            return new Farmer();
        }
    }
}