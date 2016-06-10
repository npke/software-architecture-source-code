using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication1.ServiceReference;

namespace ConsoleApplication1
{
    public class ServerConnectionHelper
    {
        static private ServiceReference.ServiceSoapClient helper = new ServiceReference.ServiceSoapClient();

        static ServerConnectionHelper()
        {
            Helper.Init();
        }

        public static ServiceSoapClient Helper
        {
            get
            {
                return helper;
            }

        }
    }
}