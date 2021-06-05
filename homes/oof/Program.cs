using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oof
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5, 5];
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
            Console.WriteLine("Write number");
            int a;
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                   if(numbers[i,j]== a*a  )
                   {
                        Console.Write(numbers[i,j] + " ");
                   }
                }
            }
            Console.ReadKey();
        }
    }
}
