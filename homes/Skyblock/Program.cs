using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyblock
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = 0;
            int magicNumber2 = 4;

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
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[magicNumber,magicNumber]> numbers[magicNumber, magicNumber2])
                    {
                        int temp = numbers[magicNumber, magicNumber];
                        numbers[magicNumber, magicNumber] = numbers[magicNumber, magicNumber2];
                        numbers[magicNumber, magicNumber2] = temp;
                    }
                    Console.Write(numbers[i,j]+ " ");
                }
            }
            Console.ReadKey();
        }
    }
}
