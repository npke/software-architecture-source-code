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


        private static List<Pyramid> instances = new List<Pyramid>();
        public static int nMaxInstances = 1;

        public static Pyramid Build()
        {
            if (instances.Count< nMaxInstances)
            {
                instances.Add(new Pyramid());
                return instances[instances.Count - 1];
            }
            return null;
        }
    }
}