using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CalculateSquare
    {
        int number;
        public CalculateSquare()
        {
            number = 10;
           square(number);

        }
        // This function calculates square of a number
        public void square(int number)
        {
            number *= number;
            Console.WriteLine("square is {0}", number);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            CalculateSquare cal = new CalculateSquare();
            Console.ReadLine();
        }
    }
}
