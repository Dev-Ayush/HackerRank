//https://www.hackerrank.com/contests/rookierank/challenges/counting-valleys

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
            
            long up = 0, dn = 0, valley = 0, cur = 0;
            long prev = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            
            string s = Console.ReadLine().ToUpper();
            if (s.Length == n)
            {
                char[] ch = s.ToCharArray();

                for(int i=0;i<ch.Length;i++)
                {
                   if(ch[i] == 'U')
                    {
                        up++;
                        cur++;
                    }
                    else
                    {
                        dn++;
                        cur--;
                    }

                   if(cur == 0 && up - dn == 0 && prev == -1)
                    {
                        valley++;
                    }
                    prev = cur;
                }
            }
            Console.WriteLine(valley);
            Console.ReadLine();
        }
    }
}
