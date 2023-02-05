using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Algorithm
    {
        public static string ReturnValue(string input)
        {
            int index;
            int numb1;
            int numb2;

            input = input.Replace(" ", "");
            numb1 = input.IndexOf(",");
            numb2 = Convert.ToInt32(input.Substring(numb1+1));
            if (numb2> input.Length)
            {
                Console.WriteLine("Verilen sayı bölünecek ifadenin uzunluğundan büyük olamaz!");
                Console.ReadKey();
            }
           
            StringBuilder stringBuilder = new StringBuilder(input);

            stringBuilder.Remove(numb2, 1);
            stringBuilder.Remove((numb1-1), input.Length - (numb1));

           return  stringBuilder.ToString();


            


        }
    }
}
