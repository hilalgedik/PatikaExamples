using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeASquare
{
    public class TakeASquare
    {
        public static int[] ReturnSquare()
        {
            Console.WriteLine("İşleme alınmasını istediğiniz sayıları arasında boşluk bırakarak yazınız.");
            string input = Console.ReadLine();
            string[] inputArray;
            inputArray = input.Split(" ");
            int[] intArray = new int[inputArray.Length];


           intArray= Array.ConvertAll(inputArray, int.Parse);
           int[] resultArray= new int[2];
           int smallSum = 0;
           int bigSum = 0;

           for (int i = 0; i < intArray.Length; i++)
           {
               if (intArray[i]<67)
               {
                   smallSum = smallSum + (67 - intArray[i]);
               }
               else
               {
                   bigSum = bigSum + ((intArray[i] - 67) *(intArray[i] - 67));
               }
           }

            resultArray[0] = smallSum;
            resultArray[1] = bigSum;

            return resultArray;

        }
    }
}
