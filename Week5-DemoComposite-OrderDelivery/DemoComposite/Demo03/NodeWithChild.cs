using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo03
{
    public class NodeWithChild : Node
    {
        protected Node pLeft = null;
        protected Node pRight = null;
        public Node Left
        {
            get { return pLeft;}

            set { pLeft = value;}
        }

        public Node Right
        {
            get { return pRight;}

            set{ pRight = value;}
        }

        public override Node FindKey(int x)
        {
            if (x == this.Key)
                return this;
            if (x < this.Key)
            {
                if (this.pLeft != null)
                    return pLeft.FindKey(x);
                return null;
            }
            if (this.pRight != null)
                return pRight.FindKey(x);
            return null;
        }
    }
}