https://www.hackerrank.com/challenges/30-dictionaries-and-maps

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Dictionaries
{
    class Solution
    {
        static void Main(String[] args)
        {
            int Number_Of_Entries = Convert.ToInt32(Console.ReadLine());
           

            Dictionary<string, int> contact = new Dictionary<string, int>();

            for (int i=0;i<Number_Of_Entries;i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                contact.Add(temp[0], Convert.ToInt32(temp[1]));
            }

            string input = string.Empty;
            while(!String.IsNullOrEmpty(input=Console.ReadLine()))
            {
                if(contact.ContainsKey(input))
                {
                    Console.WriteLine(input + "=" + contact[input]);
                }
                else
                {
                    Console.WriteLine("Not" + " " + "found");
                }
            }
            
            
            Console.ReadLine();
        }
            
    }
}
