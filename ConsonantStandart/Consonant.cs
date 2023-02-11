using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consonant
{
    public class Consonant
    {
        public static bool GetValue()
        {
            Console.WriteLine("İşlem görmesini istediğiniz kelimeyi yazınız.");
            string input = Console.ReadLine();
            string[] vowel = new[] { "a", "e", "ı", "i", "u", "ü", "o", "ö" };

            for (int i = 0; i < input.Length-1; i++)
            {
                if (vowel.Contains(input[i].ToString().ToLower())==false && vowel.Contains(input[i+1].ToString().ToLower())==false)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
