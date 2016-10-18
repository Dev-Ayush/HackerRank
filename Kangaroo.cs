//https://www.hackerrank.com/challenges/kangaroo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);

            int speed_diff = v2-v1;
            int distance_diff = x1-x2;
            if (speed_diff == 0)
            {
                Console.WriteLine("NO");
            }
            else if ((distance_diff % speed_diff == 0) && (distance_diff / speed_diff > 0))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
            Console.ReadLine();
        }
    }
}
