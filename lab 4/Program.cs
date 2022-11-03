using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int shift;
            Console.WriteLine("Введите shift");
            shift = int.Parse(Console.ReadLine());

            int arrayLength;
            Console.WriteLine("Введите arrayLength");
            arrayLength = int.Parse(Console.ReadLine());

            if (0 >= shift || shift >= arrayLength)
            { 
                Console.WriteLine("Ты дурак");
                return;
            }

            int[] arr = new int[arrayLength];
            //var rand = new Random();
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.Write(arr[i] +  " ");
            }
            Console.WriteLine("]");

            for (int i = 0; i < shift; i++)
            {
                int temp = arr[0];
                int temp2 = arr[0];
                for (int j = 0; j < arrayLength; j++)
                {
                    if (j == arr.Length - 1)
                    {
                        arr[0] = temp;
                        break;
                    }
                    temp2 = arr[j + 1];
                    arr[j + 1] = temp;
                    temp = temp2;
                }
            }
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}