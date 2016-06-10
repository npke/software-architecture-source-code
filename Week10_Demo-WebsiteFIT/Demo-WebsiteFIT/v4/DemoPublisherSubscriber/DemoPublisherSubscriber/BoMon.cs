using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoPublisherSubscriber
{
    public class BoMon
    {
        public void GuiTin(string noidung, List<string> tukhoa)
        {
            WebsiteFIT.BoSungBaiViet(noidung, tukhoa);
        }
    }
}