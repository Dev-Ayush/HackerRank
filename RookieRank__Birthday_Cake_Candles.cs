//https://www.hackerrank.com/contests/rookierank/challenges/birthday-cake-candles

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);

            int max_number_inside_array = height.Max();
            int maximun_counter = 0;
            for(int i=0;i<n;i++)
            {
                if(height[i] == max_number_inside_array)
                {
                    maximun_counter++;
                }
            }
            Console.WriteLine(maximun_counter);
            Console.ReadLine();
        }
    }
}
