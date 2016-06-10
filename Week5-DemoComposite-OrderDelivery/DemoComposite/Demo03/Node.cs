using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo03
{
    public abstract class Node
    {
        public int Key;
        public abstract Node FindKey(int x);
    }


}