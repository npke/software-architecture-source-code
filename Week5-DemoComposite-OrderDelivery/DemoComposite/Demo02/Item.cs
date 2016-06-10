using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo02
{
    public abstract class Item
    {
        public string Name;
        public DateTime DateOfCreation;
        public DateTime LastAccess;
        public DateTime LastModification;

        public virtual int TotalSize()
        {
            return 0;
        }
    }
}