using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoComposite
{
    public class MachR : MachDon
    {
        protected float R;
        public override float TinhRTuongDuong()
        {
            return R;
            //return base.TinhRTuongDuong();
        }
    }
}