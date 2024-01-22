using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, s;char d;
            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите действие");
            d = Convert.ToChar(Console.ReadLine());
            switch (d)
            {
                case '+': s = a + b; Console.WriteLine("Сумма = "+s); break;
                case '-': s = a - b; Console.WriteLine("Разность = "+s); break;
                case '*': s = a * b; Console.WriteLine("Произведение = "+s); break;
                case '/': s = a / b; Console.WriteLine("Частное = "+s); break;
                    default: Console.WriteLine("Нет такого действия"); break;
            }
            Console.ReadKey();
        }
    }
}
