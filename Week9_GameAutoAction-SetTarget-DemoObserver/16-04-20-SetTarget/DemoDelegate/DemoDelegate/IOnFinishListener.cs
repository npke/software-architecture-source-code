using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDelegate
{
    public interface IOnFinishListener
    {
        void ShowMessage(string s);
    }
}