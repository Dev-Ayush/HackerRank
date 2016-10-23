//https://www.hackerrank.com/challenges/linkedin-practice-nested-logic

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Logic
{
    class Solution
    {
        static void Main(string[] args)
        {
            int fine = 0;
            int diff = 0;

            string[] s = Console.ReadLine().Split(' ');
            int returned_day = Convert.ToInt32(s[0]);
            int returned_month = Convert.ToInt32(s[1]);
            int returned_year = Convert.ToInt32(s[2]);

            string[] s2 = Console.ReadLine().Split(' ');
            int expected_day = Convert.ToInt32(s2[0]);
            int expected_month = Convert.ToInt32(s2[1]);
            int expected_year = Convert.ToInt32(s2[2]);


            if (returned_year > expected_year)
            {
                diff = returned_year - expected_year;
                fine = 10000 * 1;
            }

            else if (returned_month > expected_month && returned_year==expected_year)
            {
                diff = returned_month - expected_month;
                fine = 500 * diff;
            }

            else if (returned_day>expected_day && returned_month==expected_month && returned_year==expected_year)
            {
                diff = returned_day - expected_day;
                fine = 15 * diff;
            }
            
            else
            {
                fine = 0;
            }
            Console.WriteLine(fine);
            Console.ReadLine();
        }
    }
}
