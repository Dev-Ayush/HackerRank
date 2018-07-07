//https://www.hackerrank.com/challenges/counting-valleys/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Valleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;int v = 0;
            int steps = Convert.ToInt32(Console.ReadLine());
            string input_value = Console.ReadLine();
            char[] arr = input_value.ToCharArray();
            for(int i=0;i<steps;i++)
            {
                if (arr[i] == 'U')
                    t++;
                else
                    t--;
                if (t == 0 && arr[i] == 'U')
                    v++;
            }
            Console.WriteLine(v);
        }
    }
}
