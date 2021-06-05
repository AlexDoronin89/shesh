using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooof
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            int imin = 0;
            int jmin = 0;
            int imax = 0;
            int jmax = 0;
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
                    if(numbers[i,j] > max)
                    {
                        max = numbers[i, j];
                        imax = i;
                        jmax = j;
                       
                    }
                    if(numbers[i,j] < min)
                    {
                        min = numbers[i, j];
                        imin = i;
                        jmin = j;
                    }
                    

                }
            }
            int temp = numbers[imin, jmin];
            numbers[imin, jmin] = numbers[imax,jmax];
            numbers[imax, jmax] = temp;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
