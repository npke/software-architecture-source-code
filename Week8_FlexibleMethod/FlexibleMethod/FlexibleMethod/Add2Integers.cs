using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPluginNamespace;

namespace FlexibleMethod
{
    public class Add2Integers: IPlugin
    {
        public string Name()
        {
            return "Add 2 Integers";
        }

        public object Execute(object param1, object param2)
        {
            int v1 = (int)param1;
            int v2 = (int)param2;
            return v1 + v2;
        }
    }
}