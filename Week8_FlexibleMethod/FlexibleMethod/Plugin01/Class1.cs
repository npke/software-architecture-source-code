using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPluginNamespace;

namespace Plugin01
{
    public class Compare2Integers: IPlugin
    {
        public string Name()
        {
            return "Compare 2 Integers";
        }

        public object Execute(object param1, object param2)
        {
            int v1 = (int)param1;
            int v2 = (int)param2;
            if (v1 == v2)                
                return v1.ToString()+" is equal to " +v2.ToString();
            else if (v1< v2)
                return v1.ToString() + " is less than " + v2.ToString();
            else
                return v1.ToString() + " is greater than" + v2.ToString();
        }

    }
}
