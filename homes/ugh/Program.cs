using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ugh
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =new int[10];
            int a = 0;
            int b;
            
            string userInput;
            bool isWork = true;
           
            while(isWork == true)
            {
                Console.WriteLine("Write number");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Если хотите продолжить нажмите Enter " +
                    "если подсчитать сумму чисел sum " +
                    "или больше не хотите напишите exit");
                userInput = Console.ReadLine();
               
                    if (userInput == "sum")
                    {
                        a += b;
                        Console.WriteLine(a);
                    }
                
                if (userInput == "exit")
                {
                    isWork = false;
                }
            }
        }
    }
}
