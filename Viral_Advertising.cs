//https://www.hackerrank.com/challenges/strange-advertising/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viral_Advertising
{
    class Program
    {

        static int viralAdvertising(int n)
        {
            int people = 5;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                people = (int)Math.Floor(Convert.ToDouble(people / 2));
                sum += people;
                people *= 3;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = viralAdvertising(n);
            Console.WriteLine(result);
        }
    }
}
