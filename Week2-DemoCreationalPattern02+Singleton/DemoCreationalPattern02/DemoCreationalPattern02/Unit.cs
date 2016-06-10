using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCreationalPattern02
{
    public abstract class Unit
    {
        protected string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract Unit Recruit();
    }
}