using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class IsGreater2Integers : AbstractOperator
    {
        public override string Execute(string v1, string v2)
        {
            int x1 = 0;
            int.TryParse(v1, out x1);
            int x2 = 0;
            int.TryParse(v2, out x2);

            if (x1 > x2)
                return "true";
            return "false";

        }
        public override string GetName()
        {
            return "Is v1 greater than v2";
        }

    }
}