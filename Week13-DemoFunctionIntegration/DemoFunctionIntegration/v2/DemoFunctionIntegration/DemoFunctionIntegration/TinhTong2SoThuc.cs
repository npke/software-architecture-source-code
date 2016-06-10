using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFunctionIntegration
{
    public class TinhTong2SoThuc : MyFunction
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
            kq.data.Add("_0", v0 +v1);
            return kq;

        }

    }
}