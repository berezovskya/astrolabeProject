using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double Trapeze(double m, double n, int razb, double a, double b)
        {

            double yn = 0, y0, h = (n - m) / razb, x0 = m + h, first, last;

            for (int i = 0; i <= razb; i++)
            {
                if (x0 != 0)
                {
                    if (Math.Abs((a * x0 + b) / x0) >0)
                    {
                        y0 = -1.0 / b * Math.Log(Math.Abs((a * x0 + b) / x0));
                        yn += y0;
                    }
                }
                x0 += h;
            }
            if (m != 0)
                if(Math.Abs((a * m + b) / m) > 0)
                    first = -1.0 / b * Math.Log(Math.Abs((a * m + b) / m));
                else
                    first = 0;
            else
                first = 0;
            if (n != 0)
                if(Math.Abs((a * n + b) / n) > 0)
                    last = -1.0 / b * Math.Log(Math.Abs((a * n + b) / n));
                else
                    last = 0;
            else
                last = 0;

            return h * (( first + last) / 2 + yn);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите пределы интегрирования");
            int razb;
            double a, b, m, n;
            while (true)
            {
                Console.WriteLine("Введите n");
                if (double.TryParse(Console.ReadLine(), out n))
                    break;
                else
                    Console.WriteLine("Неверный ввод");
            }
            while (true)
            {
                Console.WriteLine("Введите m");
                if (double.TryParse(Console.ReadLine(), out m))
                    break;
                else
                    Console.WriteLine("Неверный ввод");
            }
            while (true)
            {
                Console.WriteLine("Введите a");
                if (double.TryParse(Console.ReadLine(), out a))
                    break;
                else
                    Console.WriteLine("Неверный ввод");
            }
            while (true)
            {
                Console.WriteLine("Введите b");
                if (double.TryParse(Console.ReadLine(), out b) && b != 0)
                    break;
                else
                    Console.WriteLine("Неверный ввод");
            }
            while (true)
            {
                Console.WriteLine("Введите количесвто разбиений (при razb >=1000 наблюдается точность вычесления)");
                if (int.TryParse(Console.ReadLine(), out razb) && razb > 0)
                    break;
                else
                    Console.WriteLine("Неверный ввод");
            }
            double result = 0;
            if (n > m)
                result = Trapeze(m, n, razb, a, b);
            else
                result = Trapeze(n, m, razb, a, b);
            Console.WriteLine($"Формула трапеций: {result}");
            Console.ReadKey();
        }
    }
}
