using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // http://blog.codinghorror.com/why-cant-programmers-program/
            // Write a program that prints the numbers from 1 to 100. But for multiples of 
            // three print "Fizz" instead of the number and for the multiples of five print 
            // "Buzz". For numbers which are multiples of both three and five print "FizzBuzz". 

            for (int counter = 1; counter < 101; counter++)
            {
                if (counter % 3 == 0 && counter % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (counter % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (counter % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}