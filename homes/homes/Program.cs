using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homes
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = 7;
            int number = 0;
            int[,] numbers = new int[5,5];
            Random random = new Random();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(0, 10+1);
                    Console.Write(numbers[i, j] + " ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    int[] nusad=new int[1];
                    for (int k = 0; k < nusad.Length; k++)
                    {
                        if (numbers[i, j] % magicNumber == 0)
                        {
                            nusad[0] = numbers[i, j];
                            number++;
                        }
                        Console.Write(nusad[k]+ " ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                        if (numbers[i, j] % magicNumber == 0)
                        {
                            number++;
                        }
                }
            }
            Console.WriteLine();
            Console.Write(number + " ");

            Console.ReadKey();
        }
    }
}
