//https://www.hackerrank.com/challenges/30-data-types

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_hack
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            // Declare second integer, double, and String variables.

            // Read and save an integer, double, and String to your variables.
            int n = Convert.ToInt32(Console.ReadLine());
            double dd = Convert.ToDouble(Console.ReadLine());
            //string ss = Convert.ToString(Console.ReadLine());
            string ss = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            int sum = i + n;
            Console.WriteLine(sum);
            // Print the sum of the double variables on a new line.
            double sum2 = (d + dd);
            Console.WriteLine(sum2.ToString("0.0"));
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            string sum3 =( s + ss );
            Console.WriteLine(sum3);

            Console.ReadLine();
        }
    }
}
