using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo03
{
    public class LeafNode : Node
    {
        public override Node FindKey(int x)
        {
            if (x == this.Key)
                return this;
            return null;
        }
    }
}