// https://www.hackerrank.com/challenges/mini-max-sum

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] temp_string = Console.ReadLine().Split(' ');
            //List<int> values = new List<int>();
            //foreach(string s in temp_string)
            //{
            //    values.Add(Convert.ToInt32(s));
            //}

            //int max = 0;
            //int min = 0;
            //int result = 0;

            //for(int i=0;i<values.Count;i++)
            //{
            //    result += values[i];
            //}
            //if(result>max)
            //{
            //    min = max;
            //    max = result;
            //}
            //Console.WriteLine(min + " " + max);

            string input = Console.ReadLine();
            List<long> data = new List<long>();
            for (int i = 0; i < input.Split(' ').Length; i++)
            {
                data.Add(Convert.ToInt64(input.Split(' ')[i]));
            }
            Console.WriteLine(data.OrderBy(x => x).Take(4).Sum() + " " + data.OrderByDescending(x => x).Take(4).Sum());
            Console.ReadLine();
        }
    }
}
