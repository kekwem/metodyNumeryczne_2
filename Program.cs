using System;

namespace metodaBisekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            //metoda bisekcji
            //zadanie domowe

            Console.WriteLine("Wprowadz punkt a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz punkt b:");
            double b = Convert.ToDouble(Console.ReadLine());
            if (b < a)
            {
                double zmienna = a;
                a = b;
                b = zmienna;
            }
            Console.WriteLine("Funkcja: A*x^3 + B*x^2 + C*x + D = 0");
            Console.WriteLine("Wprowadz A:");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz B:");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz C:");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz D:");
            double D = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz epsilon:");
            double epsilon = Convert.ToDouble(Console.ReadLine());
            double x_final = 0;
            double f_srednia = Double.MaxValue;
            Console.WriteLine("--------------------------------------");
            do
            {
                double f_a = A * Math.Pow(a, 3) + B * Math.Pow(a, 2) + C * a + D;
                double f_b = A * Math.Pow(b, 3) + B * Math.Pow(b, 2) + C * b + D;

                double srednia = (a + b) / 2;

                f_srednia = A * Math.Pow(srednia, 3) + B * Math.Pow(srednia, 2) + C * srednia + D;
                if (f_srednia < 0)
                {
                    b = srednia;
                    x_final = srednia;
                }
                else
                {
                    a = srednia;
                    x_final = srednia;
                }
                Console.WriteLine(x_final);
            } while (Math.Abs(f_srednia) >= epsilon);



            /*dla zadania z zalecia
            Console.WriteLine("Wprowadz punkt a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz punkt b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Funkcja: x^3 - x - 4,5 = 0");
            Console.WriteLine("Wprowadz epsilon:");
            if (b < a)
            {
                double zmienna = a;
                a = b;
                b = zmienna;
            }
            double epsilon = Convert.ToDouble(Console.ReadLine());
            double x_final = 0;
            double f_srednia = Double.MaxValue;
            do
            {
                double f_a = Math.Pow(a, 3) - a - 4.5;
                double f_b = Math.Pow(b, 3) - b - 4.5;

                double srednia = (a + b) / 2;

                 f_srednia = Math.Pow(srednia, 3) - srednia - 4.5;
                if (f_srednia < 0)
                {
                    a = srednia;
                    x_final = srednia;
                }
                else
                {
                    b = srednia;
                    x_final = srednia;
                }
                Console.WriteLine(x_final);
            } while (Math.Abs(f_srednia) >= epsilon);
            */




            //metoda stycznych
            //zadanie domowe
            /*
            Console.WriteLine("Wprowadz punkt a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz punkt b:");
            double b = Convert.ToDouble(Console.ReadLine());
            if (b < a)
            {
                double zmienna = a;
                a = b;
                b = zmienna;
            }
            Console.WriteLine("Funkcja: A*x^3 + B*x^2 + C*x + D = 0");
            Console.WriteLine("Wprowadz A:");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz B:");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz C:");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz D:");
            double D = Convert.ToDouble(Console.ReadLine());
            double f_srednia = Double.MaxValue;
            Console.WriteLine("Wprowadz epsilon:");
            double epsilon = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------");

            double srednia = (a + b) / 2;
            double f1_srednia = A * Math.Pow(srednia, 3) + B * Math.Pow(srednia, 2) + C * srednia + D;
            //double f1_b = A * Math.Pow(b, 3) + B * Math.Pow(b, 2) + C * b + D;

            double f2_srednia = 3 * A * Math.Pow(srednia, 2) + 2 * B * srednia + C;
            //double f2_b = 3 * A * Math.Pow(b, 2) + 2 * B * b + C;

            double f3_srednia = 6 * A * srednia + 2 * B;
            //double f3_b = 6 * A * b + 2 * B;

            double x = 0;

            if (f2_srednia * f3_srednia > 0)
            {
                x = b;
            }
            else if (f2_srednia * f3_srednia < 0)
            {
                x = a;
            }
            double f1_x;
            double f1_test;
            do {
                Console.WriteLine(x);
                f1_x = A * Math.Pow(x, 3) + B * Math.Pow(x, 2) + C * x + D;
                double f2_x = 3 * A * Math.Pow(x, 2) + 2 * B * x + C;
                double f3_x = 6 * A * x + 2 * B;
                //Console.WriteLine(f1_x + " to f(x)");
                x = x - f1_x / f2_x;
                f1_test = A * Math.Pow(x, 3) + B * Math.Pow(x, 2) + C * x + D;
            } while (Math.Abs(f1_x) >= epsilon);
            */
            

            /*
            Console.WriteLine("Wprowadz punkt a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadz punkt b:");
            double b = Convert.ToDouble(Console.ReadLine());
            if (b < a)
            {
                double zmienna = a;
                a = b;
                b = zmienna;
            }
            Console.WriteLine("Funkcja: A*x^3 + B*x^2 + C*x + D = 0");
            double f_srednia = Double.MaxValue;
            Console.WriteLine("--------------------------------------");

            double srednia = (a + b) / 2;
            double f1_srednia = Math.Pow(srednia, 3) + srednia + Math.Cos(srednia);
            //double f1_b = A * Math.Pow(b, 3) + B * Math.Pow(b, 2) + C * b + D;

            double f2_srednia = 3 * Math.Pow(srednia, 2) + 1 - Math.Sin(srednia);
            //double f2_b = 3 * A * Math.Pow(b, 2) + 2 * B * b + C;

            double f3_srednia = 6 * srednia - Math.Cos(srednia);
            //double f3_b = 6 * A * b + 2 * B;

            double x = 0;

            if (f2_srednia * f3_srednia > 0)
            {
                x = b;
            }
            else if (f2_srednia * f3_srednia < 0)
            {
                x = a;
            }
            double f1_x;
            double f1_test;
            do
            {
                Console.WriteLine(x);
                f1_x = Math.Pow(x, 3) + x + Math.Cos(x);
                double f2_x = 3 * Math.Pow(x, 2) + 1 - Math.Sin(x);
                double f3_x = 6 * x - Math.Cos(x);
                x = x - f1_x / f2_x;
                f1_test = Math.Pow(x, 3) + x + Math.Cos(x);
                
            } while (f1_x != f1_test);
            */








        }
    }
}
