using System;

namespace Метод_Эйлера
{
    internal class Program
    {
        static double F(double x, double y)
        {
            return y - 2*x/y;
        }

        static void Main()
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите шаг h: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите необходимое значение абсциссы b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            while (x <= b)
            {
                y = y + h * F(x, y);
                x = x + h;
            }
            Console.WriteLine($"Ответ: {Math.Round(y, 3)}");
            Console.ReadLine();
        }
    }
}
