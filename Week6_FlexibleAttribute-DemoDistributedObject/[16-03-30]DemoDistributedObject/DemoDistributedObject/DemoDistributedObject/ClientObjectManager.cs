using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDistributedObject
{
    public class ClientObjectManager
    {
        internal static bool CanAttachHandle(string className, int handle)
        {
            return ServerObjectManager.CanAttachHandle(className, handle);
        }

        internal static int CreateRemoteObject(string className)
        {
            return ServerObjectManager.CreateObject(className);
        }


        internal static void DetachHandle(int handle)
        {
            ServerObjectManager.DetachHandle(handle);
        }

        public static object GetAttributeValue(int handle, string attributeName)
        {
            return ServerObjectManager.GetAttributeValue(handle, attributeName);
        }

        public static bool SetAttributeValue(int handle, string attributeName, object newValue)
        {
            return ServerObjectManager.SetAttributeValue(handle, attributeName, newValue);
        }

        public static object ExecuteFunction(int handle, string functionName, object parameters)
        {
            return ServerObjectManager.ExecuteFunction(handle, functionName, parameters);
        }






    }
}