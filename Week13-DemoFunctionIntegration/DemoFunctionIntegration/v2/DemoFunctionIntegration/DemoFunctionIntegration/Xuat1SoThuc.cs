using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoFunctionIntegration
{
    public class Xuat1SoThuc : MyFunction
    {
        
        public override MyStruct Execute(MyStruct input)
        {
            MessageBox.Show(input.data["_0"].ToString());
            return new MyStruct();
        }
    }
}