using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplier = 7;
            Console.WriteLine("...For Loop ...");
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine($"{multiplier} x {i} = {i * multiplier}");
            }

            Console.WriteLine("\n... While Loop...");
            int count = 0;
            while (count < 13)
            {
                Console.WriteLine($"{multiplier} x {count} = {count * multiplier}");
                count++;
            }

        }
    }
}
