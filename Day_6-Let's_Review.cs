//https://www.hackerrank.com/challenges/30-review-loop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int test_case = Convert.ToInt32(Console.ReadLine());
            string[] inputs = new string[test_case];

            for (int j = 0; j < test_case; j++)
            {
                inputs[j] = Console.ReadLine();
            }

            for (int i = 0; i < test_case; i++)
            {
                string even = "" ;
                string odd = "";
                for (int j = 0; j < inputs[i].Length; j++)
                {
                    if(j%2 == 0)
                    {
                        even += inputs[i][j];
                    }
                    else
                    {
                        odd += inputs[i][j];
                    }
                    
                }
                Console.WriteLine(even + " " + odd);
            }
            Console.ReadLine();
        }
    }
}
