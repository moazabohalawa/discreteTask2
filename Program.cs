using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            for(int i =num1; i<+num2; i++)
            {
                int sum = 0;
                
                for(int y =1; y<i; y++)
                {
                    if (i % y == 0)
                        sum += y;
                }
                if (sum == i && i != 0)
                    Console.WriteLine("the perfect number is" + i);
            }   

        }
    }
}
