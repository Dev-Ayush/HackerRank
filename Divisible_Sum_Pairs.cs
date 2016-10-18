﻿//https://www.hackerrank.com/challenges/divisible-sum-pairs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_Sum_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int counter = 0;
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    var temp = a[i] +a[j];
                    if(temp % k ==0)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
