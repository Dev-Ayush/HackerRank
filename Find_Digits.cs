//https://www.hackerrank.com/challenges/find-digits/problem

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace FindDigits
{
    class Program
    {

        static int findDigits(int n)
        {
            int counter = 0;
            int default_data = n;
            List<int> digits = new List<int>();
            while (n > 0)
            {
                digits.Add(n%10);
                n = n / 10;
            }

            for (int i = 0; i < digits.Count; i++)
            {
                if (digits[i] != 0)
                {
                    if (default_data % digits[i] == 0)
                    {
                        counter++;
                    }
                }
            }

                return counter;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                Console.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}


//SOLVED