using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoComposite
{
    public class MachSongSong : MachPhuc
    {
        public override float TinhRTuongDuong()
        {
            float R1 = 0;
            for (int i = 0; i < _ThanhPhan.Count; i++)
                R1 += (1/_ThanhPhan[i].TinhRTuongDuong());
            return 1/R1;
            //return base.TinhRTuongDuong();
        }

    }
}