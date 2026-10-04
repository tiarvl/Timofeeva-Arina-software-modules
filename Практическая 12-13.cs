namespace _12_13практическая
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = double.Parse(Console.ReadLine());
            string result = ((a >= 0) && (b >= 0) || (a < 0 && b < 0)) ? "Одинаковый знак" : "Разный знак";
            Console.WriteLine(result);



            Console.WriteLine("Введите первое число:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            double c = double.Parse(Console.ReadLine());
            if (a < b && b < c)
            {
                Console.WriteLine("Числа расположены строго по возрастанию");
            }
            else
            {
                Console.WriteLine("Числа НЕ расположены строго по возрастанию");
            }



            Console.Write("Введите символ (W, A, S, D): ");
            char key = char.ToUpper(Console.ReadLine()[0]);

            switch (key)
            {
                case 'W':
                    Console.WriteLine("Вверх");
                    break;
                case 'A':
                    Console.WriteLine("Влево");
                    break;
                case 'S':
                    Console.WriteLine("Вниз");
                    break;
                case 'D':
                    Console.WriteLine("Вправо");
                    break;
                default:
                    Console.WriteLine("Неизвестное направление");
                    break;
            }
        }
    }
}


Console.Write("Введите количество здоровья (0-100): ");
int hp = int.Parse(Console.ReadLine());
string state = hp switch
{
    <= 0 => "Погиб",
    >= 1 and <= 20 => "Критическое",
    >= 21 and <= 70 => "Ранен",
    >= 71 and <= 99 => "Здоров",
    100 => "Полное здоровье"
};
Console.WriteLine(state);





