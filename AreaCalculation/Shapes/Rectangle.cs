using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Shapes
{
    public class Rectangle
    {
        public static int GetArea()
        {
            Console.WriteLine("Dikdörtgenin yükseliğini sayısal olarak giriniz.");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin genişliğini sayısal ifade olarak giriniz.");
            int a = Convert.ToInt32(Console.ReadLine());

            int area;
            area = a * h;

            return 0;
        }
    }
}
