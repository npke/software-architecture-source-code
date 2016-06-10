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
        public static int nMaxInstances = 1024000000;

        public static Pyramid Build()
        {
            if (CanBuildAPyramid())
            {
                instances.Add(new Pyramid());
                return instances[instances.Count - 1];
            }
            return null;
        }

        private static bool CanBuildAPyramid()
        {
            //return nMaxInstances > instances.Count;
            if ((Global.CurrentPlayer.Level >= 50) ||
                (Global.CurrentPlayer.VIPLevel >= 2))
                return true;
            return false;if  
        }

        private static void CreateInstanceAtIndex()
        {
            throw new NotImplementedException();
        }

        private static bool IsValid(int idx)
        {
            throw new NotImplementedException();
        }

        private static int FindAvailableSlot()
        {
            throw new NotImplementedException();
        }

    }
}