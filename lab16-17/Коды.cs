namespace _16_17
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите положительное целое N: ");
            string line = Console.ReadLine();
            if (line == null) { Console.WriteLine("Ввод завершён"); return; }
            int N = int.Parse(line);
            int count = 0;
            while (N % 2 == 0)
            {
                N /= 2;
                count++;
            }
            Console.WriteLine($"Показатель множителя 2: {count}");

            static void Main(string[] args)
            {
                Console.Write("Введите положительное целое N: ");
                string line = Console.ReadLine();
                if (line == null) { Console.WriteLine("Ввод завершён"); return; }
                int N = int.Parse(line);
                int count = 0;
                while (N > 1 && N % 5 == 0)
                {
                    N /= 5;
                    count++;
                }
                Console.WriteLine($"Число делений: {count}; остаток: {N}");
