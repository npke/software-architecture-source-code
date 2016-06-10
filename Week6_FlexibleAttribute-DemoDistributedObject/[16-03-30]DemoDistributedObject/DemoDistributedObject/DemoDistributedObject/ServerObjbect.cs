using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDistributedObject
{
    public abstract class ServerObjbect
    {
        private int handle;
        public ServerObjbect()
        {
            handle = ServerObjectManager.GetNextAvailableHandle();            
            ServerObjectManager.RegisterMe(this);
        }

        public int Handle
        {
            get
            {
                return handle;
            }

            set
            {
                handle = value;
            }
        }

        public abstract string GetClassName();
        public virtual object GetAttributeValue(string attributeName)
        {
            return null;
        }

        public virtual bool SetAttributeValue(string attributeName, object newValue)
        {
            return false;
        }

        public virtual object ExecuteFunction(string functionName, object parameters)
        {
            return null;
        }
    }
}