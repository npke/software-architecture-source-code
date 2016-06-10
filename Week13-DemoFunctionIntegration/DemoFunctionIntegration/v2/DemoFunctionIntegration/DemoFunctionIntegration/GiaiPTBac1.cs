using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFunctionIntegration
{
    public class GiaiPTBac1 : MyFunction
    {
        public override int GetNumberOfOutput()
        {
            return 1;
        }

        public override MyStruct Execute(MyStruct input)
        {
            MyStruct kq = new MyStruct();
            double v0, v1;
            v0 = (double)input.data["_0"];
            v1 = (double)input.data["_1"];
            if (v0 != 0)
                kq.data.Add("_0", -v1 / v0);
            else
                kq.data.Add("_0", -123456789);
            return kq;

        }

    }
}