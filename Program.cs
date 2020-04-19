using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int a = 0, b = 0, c = 0;

            //Requesting data from the user
            Console.Write(" Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the second number: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                Console.Write(" The biggest is: {0}", a);
            }
            else
            {
                if ((b > a) && (b > c))
                {
                    Console.Write(" The biggest is: {0}", b);
                }
                else
                {
                    if ((c > a) && (c > b))
                    {
                        Console.Write(" The biggest is: {0}", c);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
