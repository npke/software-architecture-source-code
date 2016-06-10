using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDistributedObject
{
    public abstract class ClientObject
    {
        protected int _Handle = 0;

        public bool AttachHandle(int handle)
        {
            if (ClientObjectManager.CanAttachHandle(this.GetClassName(), handle))
            {
                ClientObjectManager.DetachHandle(this._Handle);
                _Handle = handle;
                return true;
            }
            return false;
        }

        public void DetachHandle()
        {
            ClientObjectManager.DetachHandle(_Handle);
            _Handle = 0;
        }

        public abstract string GetClassName();

        public int Handle
        {
            get
            {
                return _Handle;
            }

            set
            {
                _Handle = value;
            }
        }


    }
}