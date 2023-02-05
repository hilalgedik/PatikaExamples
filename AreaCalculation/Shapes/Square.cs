using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Shapes
{
    public class Square
    {
        public static int GetArea()
        {
            Console.WriteLine("Karenin kenar uzunluğunu sayısal olarak giriniz.");
            int a = Convert.ToInt32(Console.ReadLine());
            int area;

            area = a * a;

            return area;
        }
    }
}
