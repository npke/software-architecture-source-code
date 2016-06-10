using System;
using System.Collections.Generic;
using System.Text;
using IPluginNameSpace;
namespace FlexibleMethod
{
    public class MyObject
    {
        public MyMethodManager Methods = new MyMethodManager();
        public bool AddMethod(IPlugin method)
        {
            return Methods.AddMethod(method);
        }

        public bool RemoveMethod(string name)
        {
            return Methods.RemoveMethod(name);
        }

        public object Execute(string name, object param1, object param2)
        {
            IPlugin method = Methods[name];
            if (method == null)
                return null;

            return method.Execute(param1, param2);
        }

        internal string[] GetAllMethods()
        {
            List<string> temp = new List<string>();
            foreach (string key in Methods.Methods.Keys)
                temp.Add(key);
            return temp.ToArray();            
        }
    }
}