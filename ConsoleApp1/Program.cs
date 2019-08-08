using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 5;
            int end = 10;

            Console.WriteLine(" N/tx10/tx100/tx1000");
            Console.WriteLine("--\t---\t----\t-----");
            Console.WriteLine("\n... For loop ...");
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i}\t{i * 10}\t{i * 100}\t{i * 1000}");
            }

            Console.WriteLine("\n...While Loop ...");
            int counter = start;
            while (counter <= end)
            {
                Console.WriteLine($"{counter}\t{counter * 10}\t{counter * 100}\t{counter * 1000}");
                counter++;

            }

            Console.WriteLine("\n... Do While Loop ...");
            int counter2 = start;
            do
            {
                Console.WriteLine($"{counter2}\t{counter2 * 10}{counter2 * 100}\t{counter2 * 1000}");
                counter2++;
            } while (counter2 <= end);

        }
    }
}
