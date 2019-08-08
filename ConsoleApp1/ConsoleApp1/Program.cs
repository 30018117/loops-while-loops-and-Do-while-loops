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
            int counter2 = start;
            while (counter2 <= end)
            {

            }
        }
    }
}
