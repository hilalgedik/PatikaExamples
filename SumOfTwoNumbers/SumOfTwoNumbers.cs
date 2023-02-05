using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    public class SumOfTwoNumbers
    {
        public static double[] GetSum(int[] sInts)
        {
            double value;
            double sum;
            double[] results = new double[sInts.Length/2];
            int j = 0;
            for (int i = 0; i < sInts.Length - 1; i=i+2)
            {
                if (i != sInts.Length - 1)
                {
                    if (sInts[i] == sInts[i + 1])
                    {
                        sum = sInts[i] + sInts[i + 1];
                        value = sum * sum;
                        results[j] = value;
                        j = j + 1;
                    }
                    else if (sInts[i] != sInts[i + 1])
                    {
                        sum = sInts[i] + sInts[i + 1];
                        results[j] = sum;
                        j = j + 1;
                    }
                }
                else if (i == sInts.Length-1)
                {
                    //if ((sInts.Length%2)!=0)
                    //{
                    //    results[j] = Convert.ToDouble(sInts[i]);
                    //}
                }
            }
            return results;
        }
    }
}
