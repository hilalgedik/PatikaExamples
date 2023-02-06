using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCharacter
{
    public class ChangeCharacter
    {
        public static StringBuilder GetNewValue()
        {
            Console.WriteLine("İşlem yapılmasını istediğiniz kelimeyi giriniz.");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(input);

           // sb = sb.Replace(sb[0], sb[sb.Length - 1]);

            sb[0] = sb[sb.Length - 1];
            sb[sb.Length - 1] = input[0];




            return sb;
        }
    }
}
