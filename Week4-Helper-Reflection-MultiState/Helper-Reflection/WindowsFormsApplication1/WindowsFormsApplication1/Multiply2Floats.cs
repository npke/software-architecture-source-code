using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Multiply2Floats : AbstractOperator
    {
        public override string Execute(string v1, string v2)
        {
            float x1 = 0;
            float.TryParse(v1, out x1);
            float x2 = 0;
            float.TryParse(v2, out x2);

            return (x1 * x2).ToString();

        }
        public override string GetName()
        {
            return "Multiply 2 floating point numbers";
        }


    }
}