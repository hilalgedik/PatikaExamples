// See https://aka.ms/new-console-template for more information


using AreaCalculation;
using AreaCalculation.Shapes;

int Shape = IBaseOperations.WhichShape();



double area;

switch (Shape)
{
    case 0:
        area = Circle.GetArea();
        Console.WriteLine(area);
        break;
    case 3:
        area = Triangle.GetArea();
        Console.WriteLine(area);
        break;
    case 4:
        area = Rectangle.GetArea();
        Console.WriteLine(area);
        break;
    default:
        Console.WriteLine("Geçerli bir ifade giriniz.");
        break;
}


