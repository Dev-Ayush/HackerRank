//https://www.hackerrank.com/challenges/kaprekar-numbers/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Kaprekar_Number
{
    class Program
    {

        static void kaprekarNumbers(int p, int q)
        {
            int kaprekar = 0;
            bool _kaprekar = false;
            string invalid = "INVALID RANGE";
            string left = "";
            string right = "";
            string finalOutput = "";

            for (int i = p; i <= q; i++)
            {
                long squareOfNumber = (long)i * (long)i;
                int lengthOfSquare = squareOfNumber.ToString().Length;
                left = squareOfNumber.ToString().Substring(squareOfNumber.ToString().Length-i.ToString().Length);
                if (squareOfNumber.ToString().Length > 1)
                {
                    right = Regex.Replace(squareOfNumber.ToString(), @"(" + left + ")$", "").ToString().Trim();
                    kaprekar = Convert.ToInt32(left) + Convert.ToInt32(right);
                }
                else
                {
                    kaprekar = Convert.ToInt32(left);
                }
                if (kaprekar == i)
                {
                    finalOutput = finalOutput+i + " ";
                    _kaprekar = true;
                }
            }
            Console.WriteLine(!_kaprekar?invalid:finalOutput.Trim());
        }

        static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());

            int q = Convert.ToInt32(Console.ReadLine());

            kaprekarNumbers(p, q);
        }
    }
}
