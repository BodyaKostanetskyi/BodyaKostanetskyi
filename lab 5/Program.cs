using System;

namespace lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int stovpov1 = 0;
            int stovpov2 = 0;
            int ryadkov1 = 0;
            int ryadkov2 = 0; 
            Console.WriteLine("M i N");
            int M = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[M, N];
            for (int i = 0; i < arr.GetLength(0); i++)
            {   
                for (int j = 0; j < arr.GetLength(1); j++)
                {          
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int k = 0;
                int n = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {                 
                    if (arr[i, j] == arr[0, j])
                    {

                        k++;
                    }
                    if (arr[i, j] == arr[(arr.GetLength(0) - 1), j])
                    {
                        n++; ;
                    }

                    if (k == arr.GetLength(1) - 1)

                    {
                        ryadkov1++;
                    }
                    if (n == arr.GetLength(1) - 1)

                    {
                        ryadkov2++;
                    }
                }
            }
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int k = 0;
                int n = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[j, i] == arr[j, 0])
                    {

                        k++;
                    }
                    if (arr[j, i] == arr[j, (arr.GetLength(1) - 1)])
                    {
                        n++; ;
                    }

                    if (k == arr.GetLength(0) - 1)

                    {
                        stovpov1++;
                    }
                    if (n == arr.GetLength(0) - 1)

                    {
                        stovpov2++;
                    }

                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");

                }
                Console.WriteLine();
            }           
            Console.WriteLine("рядков единтичных первому ряду=" + (ryadkov1-1));
            Console.WriteLine("рядков единтичных последнему ряду="+(ryadkov2 -1));
            Console.WriteLine("Стовпцов единтичных первому столбцу="+(stovpov1 - 1));
            Console.WriteLine("Стовпцов единтичных последнему столбцу=" + (stovpov2 - 1));
        }
    }
}