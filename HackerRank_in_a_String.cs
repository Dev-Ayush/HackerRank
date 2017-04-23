using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                
                string h = "hackerrank";
                int k = 0;
                for (int j=0;j<s.Length;j++)
                {
                    if (j < h.Length && s[j] == h[j])
                        k++;
                }
                if (k == h.Length)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

            }
        }
        //private static string FindHackerRank(string ss)
        //{
        //    char[] c = "hackerrank".ToCharArray();
        //    int CurrentIndex = 0;

        //    for(int i=0;i<ss.Length;i++)
        //    {
        //        if (ss[i] == c[CurrentIndex])
        //        {
        //            CurrentIndex++;
        //        }                
        //    }
        //    if (CurrentIndex == 10)
        //    {
        //        return "YES";
        //    }
        //    else
        //    {
        //        return "NO";
        //    }
            
        //}

        
    }
}