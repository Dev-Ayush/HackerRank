//https://www.hackerrank.com/challenges/30-inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12_Inheritence
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }
    class Student : Person
    {
        private int[] testScores;
        private char grade;
        //private int avg;

        public Student(string firstName, string lastName,int id,int[] testScores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.testScores = testScores;
        }
        public char calculate()
        {
            int totalMarks = 0;
            for(int j = 0; j < testScores.Length; j++)
            {
                totalMarks = testScores[j] + totalMarks;
                                                                
            }
            int avg = totalMarks / testScores.Length;
         
            if (avg >= 90 && avg <= 100)
            {
                grade = 'O';
            }
            else if(avg >= 80 && avg < 90)
            {
                grade = 'E';
            }
            else if (avg >= 70 && avg < 80)
            {
                grade = 'A';
            }
            else if (avg >= 55 && avg < 70)
            {
                grade = 'P';
            }
            else if (avg >= 40 && avg < 55)
            {
                grade = 'D';
            }
            else if(avg < 40)
            {
                grade = 'T';
            }
            return grade;
        }

    }

    class Solution
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.calculate() + "\n");
            Console.ReadKey();
        }
    }
}
