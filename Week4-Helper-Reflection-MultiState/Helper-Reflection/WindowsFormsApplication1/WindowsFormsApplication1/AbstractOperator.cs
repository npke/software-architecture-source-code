using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public abstract class AbstractOperator
    {
        public virtual string Execute(string v1, string v2)
        {
            return "";
        }

        public virtual string GetName()
        {
            return "Abstract Operator";
        }
    }
}