namespace _20_21рпМ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double f1 = a * x1 + b * y1 + c;
            double f2 = a * x2 + b * y2 + c;
            if (f1 == 0 && f2 == 0)
            {
                Console.WriteLine("Отрезок лежит на прямой");
                Console.ReadLine();
                return;
            }
            if (f1 == 0 || f2 == 0)
            {
                Console.WriteLine("Отрезок пересекает прямую");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Отрезок лежит полностью по одну сторону от прямой");
            Console.ReadLine();
        }
    }
}
Console.WriteLine("Введите a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите c");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите x1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y2");
double y2 = Convert.ToDouble(Console.ReadLine());
double f1 = a * x1 + b * y1 + c;
double f2 = a * x2 + b * y2 + c;
if (f1 == 0 && f2 == 0)
{
    Console.WriteLine("Отрезок лежит на прямой");
    Console.ReadLine();
    return;
}
if (f1 == 0 || f2 == 0)
{
    Console.WriteLine("Отрезок пересекает прямую");
    Console.ReadLine();
    return;
}
Console.WriteLine("Отрезок лежит полностью по одну сторону от прямой");
Console.ReadLine();
        }
    }
}

    
