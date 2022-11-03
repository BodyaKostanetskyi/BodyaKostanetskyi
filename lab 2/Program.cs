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
            
            Console.WriteLine("Введите чилсо k");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите чилсо n");
            double n = Convert.ToDouble(Console.ReadLine());
            double a = (Math.Pow((-1), Math.Pow(k, 2) + k + 1) * Math.Pow(k, 2) / (2 * Math.Pow(k, 2) + 5));
            if (0 <= n * n && n * n <= n * k)
            {
                Console.WriteLine(a);
                
            }
            // else { Convert.ToInt32(Console.WriteLine((Math.Pow((-1), Math.Pow(k, 2) + k + 1) * Math.Pow(k, 2) / (2 * Math.Pow(k, 2) + 5))));
            // }
            else {
                Console.WriteLine("Ты дурак");
            }
        }
    }
}