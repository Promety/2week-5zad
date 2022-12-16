using System;

namespace _1zad_5_
{
    class Program
    {
        static double f(double x)
        {
            try
            {
               
                if (x <= 1) throw new Exception();
                else return Math.Log(x-1);
            }
            catch 
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)
                    try
                    {
                        if (i == 1)
                        {
                            Console.WriteLine("y({0})=error", i);
                            continue;
                        }
                        Console.WriteLine("y({0})={1}", i, Math.Round(f(i), 4));
                        
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
    }
}


