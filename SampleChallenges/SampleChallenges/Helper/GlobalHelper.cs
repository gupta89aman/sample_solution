using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChallenges.Helper
{
    public static class GlobalHelper
    {
        public static int CalculateMostRepeatedCharInArray(int[] intarr)
        {
            Dictionary<int, int> dictarr = new Dictionary<int, int>();
            int maxlen = intarr.Length / 2;
            int result = 0;
            foreach (var i in intarr)
            {
                if (dictarr.ContainsKey(i))
                {
                    dictarr[i]++;
                    if (dictarr[i] > maxlen)
                        result = dictarr[i];
                }
                else
                    dictarr.Add(i, 1);

            }
            return result;
        }
    }
}