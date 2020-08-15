using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7
{
    class zadanie7
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш рост в сантиметрах: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int id_ves = a - 100;
            Console.WriteLine($"Ваш идеальный вес в киллограмах: {id_ves}");
            Console.ReadKey();
        }
    }
}
