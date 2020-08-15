using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie22
{
    class zadanie22
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальное расстояние между автомобилями в километрах: ");
            double s0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость первого автомобиля в км/ч: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость второго автомобиля в км/ч: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите время движения автомобилей в часах: ");
            double t = Convert.ToDouble(Console.ReadLine());
            double s = s0 + v1 * t + v2 * t;
            Console.WriteLine($"Расстояние между автомобилями через {t} часов равно " +
                $"{s} километров.");
            Console.ReadKey();
        }
    }
}
