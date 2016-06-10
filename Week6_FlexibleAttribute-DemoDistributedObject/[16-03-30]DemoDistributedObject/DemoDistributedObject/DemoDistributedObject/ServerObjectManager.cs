using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDistributedObject
{
    public class ServerObjectManager
    {
        // object pool
        static private Dictionary<int, ServerObjbect> obj = new Dictionary<int, ServerObjbect>();

        internal static bool CanAttachHandle(string className, int handle)
        {
            ServerObjbect o = FindByHandle(handle);
            if (o == null)
                return false;
            if (o.GetClassName() != className)
                return false;
            return true;
        }

        internal static void DetachHandle(int handle)
        {
            
        }

        internal static int CreateObject(string className)
        {
            ServerObjbect newObj = null;
            if (className=="Film")
            {
                newObj = new SFilm();
            }
            else if (className=="Cinema")
            {
                newObj = new SCinema();
            }
            if (newObj != null)
                return newObj.Handle;
            return 0;
        }

        private static int _NextHandle=1;

        public static int GetNextAvailableHandle()
        {
            return _NextHandle++;
        }

        public static void RegisterMe(ServerObjbect serverObjbect)
        {
            obj.Add(serverObjbect.Handle, serverObjbect);
        }

        public static ServerObjbect FindByHandle(int handle)
        {
            return obj[handle];
        }

        public static object GetAttributeValue(int handle, string attributeName)
        {
            ServerObjbect o = FindByHandle(handle);
            if (o == null)
                return null;
            return o.GetAttributeValue(attributeName);
        }

        public static bool SetAttributeValue(int handle, string attributeName, 
            object newValue)
        {
            ServerObjbect o = FindByHandle(handle);
            if (o == null)
                return false;
            return o.SetAttributeValue(attributeName, newValue);
        }

        public static object ExecuteFunction(int handle, string functionName,
            object parameters)
        {
            ServerObjbect o = FindByHandle(handle);
            if (o == null)
                return false;
            return o.ExecuteFunction(functionName, parameters);
        }













    }
}