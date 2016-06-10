using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>();
            A.Add(1); A.Add(3); A.Add(2); A.Add(4); A.Add(0); A.Add(6);
            Comparator compHelper = new Comparator1();
            Evaluator evalHelper = new Evaluator1();
            MyQuery query = new MyQuery();
            
            List<object> res = query.Select(ConvertToObjectArray(A), evalHelper, compHelper);
            for (int i = 0; i < res.Count; i++)
                Console.Write(res[i].ToString() + " ");
        }

        private static object[] ConvertToObjectArray(List<int> a)
        {
            object[] res = new object[a.Count];
            for (int i = 0; i < a.Count; i++)
                res[i] = a[i];
            return res;
        }

        private class Comparator1 : Comparator
        {
            public override bool NeedSwaping(object v1, object v2)
            {
                if (((int)v1) > ((int)v2))
                    return true;
                return false;
            }
        }

        private class Evaluator1 : Evaluator
        {
            public override bool IsOK(object v)
            {
                return ((int)v) %2 ==0;
            }
        }
    }
}
