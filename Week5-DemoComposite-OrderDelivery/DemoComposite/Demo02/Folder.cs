using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo02
{
    public class Folder : Item
    {
        protected List<Item> _SubItems;
        public List<Item> SubItems
        {
            get
            {
                return _SubItems;
            }
/*            set
            {
                _SubItems = value;
            }*/
        }

        public override int TotalSize()
        {
            int size = 0;
            for (int i = 0; i < _SubItems.Count; i++)
                size += _SubItems[i].TotalSize();
            return size;
        }
    }
}