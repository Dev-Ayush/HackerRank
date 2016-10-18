//https://www.hackerrank.com/challenges/30-binary-numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int result = 0;
            int n = Convert.ToInt32(Console.ReadLine());

            string binary = Convert.ToString(n, 2);

            for (int i =0; i< binary.Length; i++)
            {
               
                if(binary[i] == 49)
                {
                    count++;
                }
                else
                {
                   
                    if (count > result)
                        result = count;
                    count = 0;
                }
            }
            
            Console.WriteLine(result);

        }
    }
}
