namespace ТАВ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a1 = ");
            double a1 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a2 =");
            double a2 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a3 =");
            double a3 =
                Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b1 = ");
            double b1 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b2 =");
            double b2 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b3 =");
            double b3 =
                Convert.ToDouble(Console.ReadLine());

            double s1 = a1 + b1;
            double s2 = a2 + b2;
            double s3 = a3 + b3;

            double d1 = a1 - b1;
            double d2 = a2 - b2;
            double d3 = a3 - b3;

            double lS = Math.Sqrt(s1 * s1 + s2 * s2 + s3 * s3);
            double lD = Math.Sqrt(d1 * d1 + d2 * d2 + d3 * d3);

            Console.WriteLine();
            Console.WriteLine($"s =({s1}; {s2}; {s3})");
            Console.WriteLine($"d =({d1}; {d2}; {d3})");
            Console.WriteLine($"|s| = {lS}");
            Console.WriteLine($"|d| ={lD}");
        }
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("p1 = ");
        double p1 =
            Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("p2 =");
        double p2 =
            Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("p3 =");
        double p3 =
            Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("p4 = ");
        double p4 =
            Convert.ToDouble(Console.ReadLine());

        double sumln = Math.Log(p1) + Math.Log(p2) + Math.Log(p3) + Math.Log(p4);
        double L = -sumln / 4.0;
        double P = Math.Exp(L);

        Console.WriteLine();
        Console.WriteLine($"L ={L}");
        Console.WriteLine($"P ={P}");
    }
}
}


namespace КПМ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N = ");
            double N =
                Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("B = ");
            int B =
                Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("K = ");
            int K =
                Convert.ToInt32(Console.ReadLine());

            double parameters = N * 1000000000.0 * K;
            double Bytes = parameters * B;
            double GB = Bytes / (1024.0 * 1024.0 * 1024.0);

            Console.WriteLine();
            Console.WriteLine($"{parameters}");
            Console.WriteLine($"{GB}");
        }
    }
}


