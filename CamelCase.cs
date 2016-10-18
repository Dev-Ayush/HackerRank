//https://www.hackerrank.com/challenges/camelcase

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            string s = Console.ReadLine();

            for(int i =0;i<s.Length;i++)
            {
                if(char.IsUpper(s[i]))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            Console.ReadLine();

        }

       
        }
    }

