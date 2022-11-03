using System;



namespace lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite 4islo");
            int k = Convert.ToInt32(Console.ReadLine());
           
            

            if (k > 1000 & k < 9999)
            {
                if ((k / 1000 + (k / 100 % 10)) == (k%100/10+k%10))
                {
                    Console.WriteLine("krasava");
                    
                }
                else
                {
                    Console.WriteLine("nepravilno");                }

                
            }
            else
            {
                Console.WriteLine("tu dyrak");
            }
        }
    }
}
