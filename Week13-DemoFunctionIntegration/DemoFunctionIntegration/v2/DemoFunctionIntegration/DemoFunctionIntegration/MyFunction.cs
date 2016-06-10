using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFunctionIntegration
{
    public class MyFunction
    {
        public virtual int  GetNumberOfOutput()
        {
            return 0;
        }
        public virtual MyStruct     Execute(MyStruct input)
        {
            return new MyStruct();
        }
    }
}