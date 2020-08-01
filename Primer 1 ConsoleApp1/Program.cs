using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Primer_1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите размер зарплаты: ");
            decimal zarplata = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height} м  Зарплата: {zarplata} руб");

            Console.ReadKey();
        }
    }
}
