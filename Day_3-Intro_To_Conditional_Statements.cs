﻿//https://www.hackerrank.com/challenges/30-conditional-statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 != 0){
                Console.WriteLine("Weird");
            }
            else if( N>=2 && N<=5 )
            {
                Console.WriteLine("Not Weird");
            }
            else if ( N>=6 && N<=20 )
            {
                Console.WriteLine("Weird");
            }
            else if ( N>20 )
            {
                Console.WriteLine("Not Weird");
            }
           Console.ReadKey();
        }
    }
}
