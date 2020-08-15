using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie14
{
    class zadanie14
    {
        static void Main(string[] args)
        {
            Console.Write("Растояние между школой и стадионом в километрах: ");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.Write("Скорость школьника в км/ч: ");
            double v = Convert.ToDouble(Console.ReadLine());
            double t = s / v * 60;
            Console.WriteLine($"Время движения школьника: {t} минут.");
            Console.ReadKey();
        }
    }
}
