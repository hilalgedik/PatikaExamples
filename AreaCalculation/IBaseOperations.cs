using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class IBaseOperations
    {
        public static int WhichShape()
        {
            Console.WriteLine("Alanını hesaplamak istediğiniz şeklin kenar sayısını rakam olarak yazın.");
            int shape;
            try
            {
                shape = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Lütfen sayısal ifade giriniz.");
                throw;
            }


            return shape;
        }

        public static int[] GetLenght(int shape)
        {
            int[] lenghtArray= new int[shape];
            int len;

            for (int i = 0; i < shape; i++)
            {
                Console.WriteLine(i.ToString() + ". kenar uzunluğunu yazın;");
                try
                {
                    len = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lütfen sayısal ifade giriniz.");
                    throw;
                }

                lenghtArray[i] = len;

            }
            return lenghtArray;

        }
    }
}
