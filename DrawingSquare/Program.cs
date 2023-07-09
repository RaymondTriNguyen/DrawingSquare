using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSquare
{
    internal class Program
    {
        static void drawing(int side)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    if (i == 0 || j == 0 || i == side - 1 || j == side - 1)

                        Console.Write("* ");
                    else

                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            do {
            Console.WriteLine("Put in a side length: ");
            int side = int.Parse(Console.ReadLine());
       
                drawing(side);

            Console.WriteLine("Type '1' to make another square.");

            }
            // int condition = int.Parse(Console.ReadLine());
            while (Console.ReadLine() == "1");// if the input is =1
        }
    }
}
