//https://www.hackerrank.com/challenges/minimum-distances

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Distance_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] A_temp = Console.ReadLine().Split(' ');
            int[] A = Array.ConvertAll(A_temp, Int32.Parse);
            
            int x=0;
            int min_dist=A.Length;


            for(int i=0;i<A.Length;i++)
            {
                for(int j=i+1;j<A.Length;j++)
                {
                    if( i!=j && A[i] == A[j] )
                    {
                        int temp = Math.Abs(i - j);
                        if(x == 0 || temp < x)
                        {
                            x = temp;
                        }

                    }
                }
            }
            if (x > 0)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("-1");
            }
            Console.ReadLine();
        }
    }
}
