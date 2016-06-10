using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSingleton
{
    public class Pyramid: IDisposable
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
                int idx = FindAvailableSlot();
                if (IsValid(idx))
                {
                    CreateInstanceAtIndex();
                    return instances[idx];
                }
            }
            return null;
        }

        public void Dispose()
        {
            int idx = Pyramid.FindMyPosition(this);
            instances[idx] = null; // available slot
//            throw new NotImplementedException();
        }

        private static int FindMyPosition(Pyramid pyramid)
        {
            for (int i = 0; i < instances.Count; i++)
                if (instances[i] == pyramid)
                    return i;
            return -1; // never~~~
        }
    }
}