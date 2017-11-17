using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("Hello\\World!");

            int integer1;
            int integer2;
            int sum;

            Console.WriteLine("Enter the first integer: ");
            integer1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer: ");
            integer2 = int.Parse(Console.ReadLine());

            sum = integer1 + integer2;

            Console.WriteLine($"Sum is {sum}");

                int x;
                int y;
                int z;
                int result;
                x = 10;
                y = 15;
                z = 5;

                result = (x + y) * (z + 10);
                Console.WriteLine($"Product is {result}");

            }
        }
}
