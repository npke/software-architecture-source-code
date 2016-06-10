using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFramework
{
    public class MyQuery
    {
        public List<object>  Select(object[] A, Evaluator evalHelper, Comparator compHelper)
        {
            List<object> res = new List<object>();

            for (int i=0; i<A.Length; i++)
            {
                if (evalHelper.IsOK(A[i]))
                    res.Add(A[i]);
            }

            Sort(res, compHelper);


            return res;
        }

        private void Sort(List<object> res, Comparator compHelper)
        {
            //res.Sort(/**/);
            int n = res.Count;
            object temp;
            for (int i=0; i<n-1; i++)
                for (int j=i+1; j< n; j++)
                {
                    if (compHelper.NeedSwaping(res[i], res[j]))
                    {
                        temp = res[i]; res[i] = res[j]; res[j] = temp;
                    }
                }
        }
    }
}