using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @is
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int max = 0;
            int[,] numbers = new int[10 , 10];
            Random random = new Random();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(0, 10 + 1);
                    Console.Write(numbers[i, j] + " ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if(numbers[i,j] > max)
                    {
                        max = numbers[i, j];
                        a = i;
                        b = j;
                    }
                    numbers[a, b] = 0;
                }
               
            }
            Console.WriteLine();
            Console.WriteLine(max);
            Console.WriteLine();
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
