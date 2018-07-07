// https://www.hackerrank.com/challenges/apple-and-orange

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_and_Orange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

            int counter_apple = 0;
            int counter_orange = 0;

            for(int i=0;i<apple.Length;i++)
            {
                if((a+apple[i])>=s && (a + apple[i]) <= t )
                {
                    counter_apple++;
                }
            }
            for(int i=0;i<orange.Length;i++)
            {
                if((b+orange[i])>=s && (b + orange[i]) <= t)
                {
                    counter_orange++;
                }
            }
            Console.WriteLine(counter_apple);
            Console.WriteLine(counter_orange);
        }
    }
}
