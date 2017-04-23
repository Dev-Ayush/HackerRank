//https://www.hackerrank.com/challenges/birthday-cake-candles

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
            int largest = 0;
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (height[i] >= largest)
                {
                    largest = height[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (height[i] == largest)
                    counter++;
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
