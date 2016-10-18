//https://www.hackerrank.com/challenges/jumping-on-the-clouds

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumping_On_The_Clouds__Finding_Shortest_Path_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = -1;

            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);


            for (int i = 0; i < n; i++, count++)
            {
                if (i < n - 2 && c[i + 2] == 0) i++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
