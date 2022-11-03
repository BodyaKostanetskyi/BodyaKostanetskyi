using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lessons
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Задайте висоту в метрах");
            Console.WriteLine("Задайте початкову швидкость в м/c");
            double h;
            double v;

            h = Convert.ToDouble(Console.ReadLine());
            v= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(h);
            Console.WriteLine(v);
            double t = (Math.Sqrt(2 * h * 10  + Math.Pow(v, 2)) - v) / 10;
            Console.WriteLine(t + " с");   
        }
    }
}