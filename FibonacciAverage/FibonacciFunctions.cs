using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciAverage
{
    public class FibonacciFunctions
    {
        public static int GetAverage(int n)
        {
            int ort;
            int toplam = 0;

            for (int i = 0; i < n-1; i++)
            {
                if (i !=0)
                {
                    toplam = toplam + ((i - 1) + (i));
                }
            }

            ort = toplam / n;

            return ort;
        }
    }
}
