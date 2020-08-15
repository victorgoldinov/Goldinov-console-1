using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace domzadanienomer1
{
    class zadanie6
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите в: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите с: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double s = a + b - c;
            if (s==0)
            {
                Console.Write("Деление на ноль");
            }
            else
            {
                double a1 = a / s * 100;
                double b1 = b / s * 100;
                double c1 = c / s * 100;
                Console.WriteLine($"Процент от А: {a1} Процент от В: {b1} Процент от С: {c1}");  
            }
           Console.ReadKey();
        }
    }
}
