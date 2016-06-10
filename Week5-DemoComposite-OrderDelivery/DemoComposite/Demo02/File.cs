using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo02
{
    public class File : Item
    {
        protected int _MySize;
        public override int TotalSize()
        {
            return _MySize;
        }
    }
}