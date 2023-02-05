using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteInReverse
{
    public class WriteInReverse
    {
        public static string Reverse(string input)
        {
            char[] charArray1 = new char[input.Length];
            char[] charArray2 = new char[input.Length];

            charArray1 = input.ToCharArray();
            int j = (charArray1.Length - 1);

            for (int i = 0; i < charArray1.Length; i++)
            {
                
                    charArray2[i] = charArray1[j];
                    j = j - 1;
                    
            }

            string value = new string(charArray2);

            return value;
        }
    }
}
