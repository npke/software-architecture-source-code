using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSingleton
{
    public class Pyramid
    {
        protected /*private*/ Pyramid()
        {

        }
        private static Pyramid _SingleInstance = null;

        public static Pyramid Build()
        {
            if (_SingleInstance == null)
                _SingleInstance = new Pyramid();
            return _SingleInstance;
        }
    }
}