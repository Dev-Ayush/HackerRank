using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strong_Password
{
    class Program
    {

        static int Charcter_Counter(string password)
        {
            int counter = 0;
            int short_of_length = 6 - password.Length;
            if (!Regex.IsMatch(password, @"[0-9]")) { counter++; }
            if (!Regex.IsMatch(password, @"[A-Z]")) { counter++; }
            if (!Regex.IsMatch(password, @"[a-z]")) { counter++; }
            if (!Regex.IsMatch(password, @"\!|\@|\#|\$|\%|\^|\&|\*|\(|\)|\-|\+")) { counter++; }
            if (counter < short_of_length)
                return short_of_length;
            else
                return counter;
        }

        static int minimumNumber(int n, string password)
        {
            
            if (n >= 6)
            {
                return Charcter_Counter(password);
            }
            else
            {
                return Charcter_Counter(password);
            }
            
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string password = Console.ReadLine();
            int answer = minimumNumber(n, password);
            Console.WriteLine(answer);
        }
    }
}
