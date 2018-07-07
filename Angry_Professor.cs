//https://www.hackerrank.com/challenges/angry-professor/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angry_Professor
{
    class Program
    {
        static string angryProfessor(int k, int[] a)
        {
            int late=0;
            int early = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    late++;
                }
                else
                {
                    early++;
                }
            }
            if(a.Length-early<k)
                return "YES";
            else
                return "NO";
        }


        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                string result = angryProfessor(k, a);
                
                Console.WriteLine(a.Count(x => x <= 0) < k ? "YES" : "NO");
            }
        }
    }
}