//https://www.hackerrank.com/challenges/day-of-the-programmer/problem

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

namespace DayOfProgrammer
{
    class Program
    {

        static string solve(int year)
        {
            if (year == 1918)
                return "26.09.1918";
            else if (((year <= 1917) && (year % 4 == 0)) || ((year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0)))
            { return "12.09." + year; }
            else { return "13.09." + year; }
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int year = Convert.ToInt32(Console.ReadLine());

            string result = solve(year);

            Console.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
