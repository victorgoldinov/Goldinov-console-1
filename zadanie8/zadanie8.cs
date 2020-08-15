using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    class zadanie8
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада: ");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите проценты: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество месяцев: ");
            int m = Convert.ToInt32(Console.ReadLine());
            double percept = (p / 12) * m;
            money = (money / 100) * (100 + percept);
            Console.WriteLine($"Причитающаяся вам сумма через {m} месяца при {p}" +
                $" процентах годовых равна: {money} рублей.");
            Console.ReadKey();
        }
    }
}
