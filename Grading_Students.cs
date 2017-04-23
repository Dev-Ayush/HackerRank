//https://www.hackerrank.com/challenges/grading

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < n; a0++)
            {
                int grade = Convert.ToInt32(Console.ReadLine());
                // your code goes here
                if (grade > 37)
                {
                    if (grade % 5 < 3)
                    {
                        Console.WriteLine(grade);
                    }
                    else if (grade / 5 > 3)
                    {
                        int new_grade = (int)Math.Round((decimal)grade / 5) * 5;
                        Console.WriteLine(new_grade);
                    }
                }
                else
                {
                    //grade = grade;
                    Console.WriteLine(grade);
                }
            }
        }

        
    }
}
