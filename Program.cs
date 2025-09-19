using System;

namespace TaskFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало 1 задачи");
            Console.WriteLine("======================");
            Console.Write("Ведите число n: ");
            string? buf = Console.ReadLine();
            int n = int.Parse(buf);
            Console.Write("Введите число m: ");
            buf = Console.ReadLine();
            int m = int.Parse(buf);

            int iresult = -m - n++;
            Console.WriteLine($" -m - n++ = {iresult}. После действий m = {m}; n = {n}.");
            bool bresult = m * m < n++;
            Console.WriteLine($"m * m < n++ Неравенство: {bresult}. После действий m = {m}; n = {n}.  ");
            bresult = n-- < ++m;
            Console.WriteLine($" n-- < ++m Неравенство: {bresult}. После действий m = {m}; n = {n}.");

            Console.Write("Введите число x: ");
            buf = Console.ReadLine();
            double x = double.Parse(buf);

            if (x == 0 || Math.Cos(x) == 0)
                Console.WriteLine("Нельзя делить на нуль!");
            else
            {
                double dresult = (Math.Tan(x) / x) - Math.Pow(5 - x, 4);
                Console.WriteLine($"tg(x) / x - (5 - x)^4 = {dresult} ");
            }
            Console.WriteLine("Конец 1 задачи");



            Console.WriteLine("Начало 2 задачи");
            Console.WriteLine("======================");
            Console.Write("Введите координату x: ");
            buf = Console.ReadLine();
            double xCoordinate = double.Parse(buf);
            Console.Write("Введите координату y: ");
            buf = Console.ReadLine();
            double yCoordinate = double.Parse(buf);

            bool circle = xCoordinate * xCoordinate + yCoordinate * yCoordinate <= 1;
            bool xIsCorrect = xCoordinate >= 0 && xCoordinate <= 1;
            Console.WriteLine($"Точка попала в заштрихованную область: {circle && xIsCorrect}");
            Console.WriteLine("Конец 2 задачи");
            
            Console.WriteLine("Начало 3 задачи");
            Console.WriteLine("======================");
            double a = 1000;
            double b = 0.0001;

            double cubeDifference = (a - b) * (a - b) * (a - b);
            double denominator = 3 * a * b * b - b * b * b;
            double numerator = cubeDifference - (a * a * a - 3 * a * a * b);
            double dfraction  = numerator  / denominator;
            Console.WriteLine("Результат с типом double : " + dfraction);

            float fcubeDifference = (float)((a - b) * (a - b) * (a - b));
            float fdenominator = (float)(3 * a * b * b - b * b * b);
            float fnumerator = (float)(fcubeDifference - (a * a * a - 3 * a * a * b));
            float ffraction = fnumerator / fdenominator;
            Console.WriteLine("Результат с типом float : " +ffraction);
            Console.WriteLine("Конец 3 задачи");
        }
    }
}