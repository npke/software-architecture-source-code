using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFunctionIntegration
{
    public class Nhap1SoThuc : MyFunction
    {
        public override MyStruct Execute(MyStruct input)
        {
            MyStruct kq = new MyStruct();
            Input1SoThucForm form = new Input1SoThucForm();
            form.ShowDialog();

            kq.data.Add("_0", form.val);
            return kq;
        }
    }
}