using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class IsLonger : AbstractOperator
    {
        public override string Execute(string v1, string v2)
        {
            int x2 = 0;
            int.TryParse(v2, out x2);

            if (v1.Length > x2)
                return "true";
            return "false";
        }

        public override string GetName()
        {
            return "String v1 has the length greater than v2";
        }

    }
}