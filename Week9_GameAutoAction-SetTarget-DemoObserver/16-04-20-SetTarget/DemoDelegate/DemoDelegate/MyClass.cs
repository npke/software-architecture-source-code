using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDelegate
{
    public class MyClass
    {
        internal void StartVeryLongOperation()
        {
            
        }

        internal void Finish()
        {
            if (listener != null)
                listener.ShowMessage("Done");
        }

        IOnFinishListener listener = null;

        internal void setOnFinishListener(IOnFinishListener listener)
        {
            this.listener = listener;
        }

    }
}