using System;
using System.Collections.Generic;
using System.Text;
using IPluginNamespace;

namespace FlexibleMethod
{
    public class MyMethodManager
    {
        public Dictionary<string, IPlugin> Methods = new Dictionary<string, IPlugin>();
        public bool AddMethod (IPlugin method)
        {
            if (IsExist(method.Name()))
            {
                Methods[method.Name()] = method;
                return true;
            }
            Methods.Add(method.Name(), method);
            return true;
        }

        public bool RemoveMethod(string name)
        {
            if (IsExist(name))
            {
                Methods.Remove(name);
                return true;
            }
            return false;

        }

        public IPlugin this[string methodname]
        {
            get
            {
                if (IsExist(methodname))
                    return Methods[methodname];
                return null;
            }
        }

        private bool IsExist(string name)
        {
            return Methods.ContainsKey(name);
        }
    }
}