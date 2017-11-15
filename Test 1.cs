using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            int i = 12;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i <= 11)
                    keepLooping = false;
                i++;
                Console.WriteLine(i);
            }
        }
    }
}

{
    class Program
{
    static void Main()
    {
        int i = 2; while (i <= 128) { { if ((i % 2) == 0) { Console.WriteLine("[{0}]", i); } else if ((i % 2) != 0) { Console.Write(""); } i *= 2; } }
    }
}
}

{
    class Program
{
    static void Main()
    {
        string j = ",";
        int i;
        for (i = 49; i >= 1; --i)
        {
            Console.Write(i);
            if (i >= 2)
            {
                Console.Write(j);
            }
        }
    }
}

{
    class Program
{
    static void Main()
    {
        int i = 1; while (i <= 21) { { if ((i % 2) == 0) { Console.Write(" "); } else if ((i % 2) != 0) { Console.Write(i); } i++; } }
    }
}

{
    class Program
{
    static void Main(string[] args)
    {
        int n = 8;
        int i = 10; // initialize
        while (i < n) ; // test condition
        {
            Console.Write("*");
            i++; // update!
        }
    }
}
// There was no difference in the outputs between a do-while and while code

{
    class Program
{
    static void Main(string[] args)
    {
        bool icyRain = false; bool tornadoWarning = false;
        if (!icyRain && !tornadoWarning)
        {
            Console.WriteLine("Let's Go Outside!");
        }
    }
}


