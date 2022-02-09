using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNum
{
    class Program
    {

        //You might want to run this program by clicking "ctrl + f5" in visual studio :) Otherwise it might close as soon as it gives you the number.

        public static int Sum(int x, int y)
        {
            int z;
            if (x == y)
            {
                z = 3 * (x + y);
            }
            else
            {
                z = x + y;
            }
            return z;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n After I apply my magic to these numbers, they become : {0} \n", Sum(numOne, numTwo));
        }
    }
}
