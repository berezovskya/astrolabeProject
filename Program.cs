using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string Parallelepiped()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Объем через высоту\n" +
                    "2)Объем через синус угла\n" +
                    "3)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double A = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите площадь основания");
                                    if (double.TryParse(Console.ReadLine(), out A))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double h = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите высоту");
                                    if (double.TryParse(Console.ReadLine(), out h))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (A * h);
                            }
                        case 2:
                            {
                                double a = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите a");
                                    if (double.TryParse(Console.ReadLine(), out a))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double b = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out b))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double c = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите c");
                                    if (double.TryParse(Console.ReadLine(), out c))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double alf = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите угол");
                                    if (double.TryParse(Console.ReadLine(), out alf))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (a * b * c * Math.Sin(alf * Math.PI / 180));
                            }
                        case 3:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }

        static string Cylinder()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Объем\n" +
                    "2)Площадь боковой поверхности\n" +
                    "3)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double r = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите радиус");
                                    if (double.TryParse(Console.ReadLine(), out r))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double h1 = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите высоту");
                                    if (double.TryParse(Console.ReadLine(), out h1))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (r * r * Math.PI * h1);
                            }
                        case 2:
                            {
                                double r = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите радиус");
                                    if (double.TryParse(Console.ReadLine(), out r))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double h = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите высоту");
                                    if (double.TryParse(Console.ReadLine(), out h))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Площадь боковой поверхности = " + (2 * Math.PI * r * h);
                            }
                        case 3:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }

        }
        static string Pyramid()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Объем\n" +
                    "2)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double A = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите площадь основания");
                                    if (double.TryParse(Console.ReadLine(), out A))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double h = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите высоту");
                                    if (double.TryParse(Console.ReadLine(), out h))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (A * h / 3);
                            }
                        case 2:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }
        static string RectangularParallelepiped()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Объем\n" +
                    "2)Площадь поверхности\n" +
                    "3)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double a = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите a");
                                    if (double.TryParse(Console.ReadLine(), out a))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double b = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out b))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double c = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите c");
                                    if (double.TryParse(Console.ReadLine(), out c))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (a * b * c);
                            }
                        case 2:
                            {
                                double a = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите a");
                                    if (double.TryParse(Console.ReadLine(), out a))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double b = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out b))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double c = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите c");
                                    if (double.TryParse(Console.ReadLine(), out c))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Площадь боковой поверхности = " + (2 * (a * b + a * c + b * c));
                            }
                        case 3:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }
        static string TruncatedCone()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Объем\n" +
                    "2)Площадь боковой поверхности через ребро\n" +
                    "3)Площадь боковой поверхности через высоту\n" +
                    "4)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double a = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите a");
                                    if (double.TryParse(Console.ReadLine(), out a))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double b = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out b))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double h = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите высоту");
                                    if (double.TryParse(Console.ReadLine(), out h))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (Math.PI * h * (a * a + a * b + b * b) / 3);
                            }
                        case 2:
                            {
                                double a = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите a");
                                    if (double.TryParse(Console.ReadLine(), out a))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double b = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out b))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double l = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите l");
                                    if (double.TryParse(Console.ReadLine(), out l))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Площадь боковой поверхности = " + (Math.PI * (a + b) * l);
                            }
                        case 3:
                            {
                                double a = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите a");
                                    if (double.TryParse(Console.ReadLine(), out a))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double b = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out b))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double h = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите высоту");
                                    if (double.TryParse(Console.ReadLine(), out h))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Площадь боковой поверхности = " + (Math.PI * (a + b) * Math.Sqrt(h * h + (b - a) * (b - a)));
                            }
                        case 4:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }
        static string Cone()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Объем\n" +
                    "2)Площадь поверхности\n" +
                    "3)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double r = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите r");
                                    if (double.TryParse(Console.ReadLine(), out r))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double h = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out h))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (Math.PI * r * r * h / 3);
                            }
                        case 2:
                            {
                                double r = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите r");
                                    if (double.TryParse(Console.ReadLine(), out r))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double l = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите l");
                                    if (double.TryParse(Console.ReadLine(), out l))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Площадь боковой поверхности = " + (Math.PI * r * l);
                            }
                        case 3:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }
        static string SphericalSegment()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Объем\n" +
                    "2)Площадь поверхности\n" +
                    "3)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double r = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите r");
                                    if (double.TryParse(Console.ReadLine(), out r))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double h = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out h))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (Math.PI * h * h * (3 * r - h) / 3);
                            }
                        case 2:
                            {
                                double r = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите r");
                                    if (double.TryParse(Console.ReadLine(), out r))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double h = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите h");
                                    if (double.TryParse(Console.ReadLine(), out h))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Площадь боковой поверхности = " + (Math.PI * 2 * r * h);
                            }
                        case 3:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }
        static string Sphere()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Объем\n" +
                    "2)Площадь поверхности\n" +
                    "3)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double r = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите r");
                                    if (double.TryParse(Console.ReadLine(), out r))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (Math.PI * r * r * r * 4 / 3);
                            }
                        case 2:
                            {
                                double r = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите r");
                                    if (double.TryParse(Console.ReadLine(), out r))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Площадь боковой поверхности = " + (Math.PI * r * r * 4);
                            }
                        case 3:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }
        static string Torus()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Объем\n" +
                    "2)Площадь поверхности\n" +
                    "3)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double a = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите a");
                                    if (double.TryParse(Console.ReadLine(), out a))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double b = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out b))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (Math.PI * Math.PI * (a + b) * (b - a) * (b - a) / 4);
                            }
                        case 2:
                            {
                                double a = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите a");
                                    if (double.TryParse(Console.ReadLine(), out a))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double b = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out b))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Площадь боковой поверхности = " + (Math.PI * Math.PI * (b * b - a * a));
                            }
                        case 3:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }
        static string SphericalTriangle()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Площадь\n" +
                    "2)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double a = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите угол a");
                                    if (double.TryParse(Console.ReadLine(), out a))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double b = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите угол b");
                                    if (double.TryParse(Console.ReadLine(), out b))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double с = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите угол с");
                                    if (double.TryParse(Console.ReadLine(), out с))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double r = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите r");
                                    if (double.TryParse(Console.ReadLine(), out r))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + ((a * Math.PI / 180 + b * Math.PI / 180 + с * Math.PI / 180 - Math.PI ) * r * r);
                            }
                        case 2:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }
        static string Parabaloid()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Объем\n" +
                    "2)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double a = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите a");
                                    if (double.TryParse(Console.ReadLine(), out a))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double b = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out b))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (Math.PI*b*b*a/2);
                            }
                        case 2:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }
        static string Ellipsoid()
        {
            while (true)
            {
                Console.WriteLine("Найти:\n" +
                    "1)Объем\n" +
                    "2)Выход\n"
                    );
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            {
                                double a = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите a");
                                    if (double.TryParse(Console.ReadLine(), out a))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double b = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите b");
                                    if (double.TryParse(Console.ReadLine(), out b))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                double c = 0;
                                while (true)
                                {
                                    Console.WriteLine("Введите c");
                                    if (double.TryParse(Console.ReadLine(), out c))
                                        break;
                                    else
                                        Console.WriteLine("Неверный ввод");
                                }
                                return "Объем = " + (Math.PI * a * b * c * 4 / 3);
                            }
                        case 2:
                            return "";
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }

        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                Console.WriteLine("Выберите фигуру:\n" +
                    "1)Параллелепипед\n" +
                    "2)Цилиндр\n" +
                    "3)Пирамида\n" +
                    "4)Прямоугольный Параллелепипед\n" +
                    "5)Усеченный конус\n" +
                    "6)Конус\n" +
                    "7)Сферический сегмент\n" +
                    "8)Сфера\n" +
                    "9)Тор\n" +
                    "10)Сферический треугольник\n" +
                    "11)Парабалоид\n" +
                    "12)Эллипсоид\n" +
                    "13)Выход\n"
                    );
                string F = "";
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    switch (choise)
                    {
                        case 1:
                            F = Parallelepiped();
                            if (F != "")
                            {
                                if(!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 2:
                            F = Cylinder();
                            if (F != "")
                            {
                                if (!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 3:
                            F = Pyramid();
                            if (F != "")
                            {
                                if (!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 4:
                            F = RectangularParallelepiped();
                            if (F != "")
                            {
                                if (!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 5:
                            F = TruncatedCone();
                            if (F != "")
                            {
                                if (!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 6:
                            F = Cone();
                            if (F != "")
                            {
                                if (!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 7:
                            F = SphericalSegment();
                            if (F != "")
                            {
                                if (!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 8:
                            F = Sphere();
                            if (F != "")
                            {
                                if (!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 9:
                            F = Torus();
                            if (F != "")
                            {
                                if (!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 10:
                            F = SphericalTriangle();
                            if (F != "")
                            {
                                if (!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 11:
                            F = Parabaloid();
                            if (F != "")
                            {
                                if (!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 12:
                            F = Ellipsoid();
                            if (F != "")
                            {
                                if (!F.Contains("-") && F != "0")
                                    Console.WriteLine(F);
                                else
                                    Console.WriteLine("Неверный ввод значений");
                            }
                            break;
                        case 13:
                            b = false;
                            break;
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }

                }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }
    }
}
