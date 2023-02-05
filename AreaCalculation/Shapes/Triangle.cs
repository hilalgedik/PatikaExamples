using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Shapes
{
    public class Triangle
    {
        public static int GetArea()
        {
            try
            {
                Console.WriteLine("Üçgenin yükseliğini sayısal olarak giriniz.");
                int h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Üçgenin taban kenarının uzunluğunu sayısal ifade olarak giriniz.");
                int a = Convert.ToInt32(Console.ReadLine());

                int area;
                area = a * h / 2;

                return area;
            }
            catch (Exception e)
            {
                Console.WriteLine("Girdiğiniz ifadelerin doğruluğundan emin olunuz.");
                throw;
            }

        }
    }
}
