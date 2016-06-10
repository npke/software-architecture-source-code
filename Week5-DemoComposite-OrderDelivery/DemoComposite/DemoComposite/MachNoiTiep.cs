using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoComposite
{
    public class MachNoiTiep : MachPhuc
    {
        public override float TinhRTuongDuong()
        {
            float R = 0;
            for (int i = 0; i < _ThanhPhan.Count; i++)
                R += _ThanhPhan[i].TinhRTuongDuong();
            return R;
            //return base.TinhRTuongDuong();
        }
    }
}