using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Shapes
{
    public class Circle
    {
        public static double GetArea()
        {
            Console.WriteLine("Çemberin yarıçapının sayısal olarak giriniz.");
            int r = Convert.ToInt32(Console.ReadLine());
            double area;

            area = Math.PI * Math.Pow(r, 2);

            return area;
        }
    }
}
