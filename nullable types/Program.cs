using System;
using System.Dynamic;

namespace nullable_types
{
    class Program
    {
        static void Main(string[] args)
        {
            var P= new Marks();
            double? mark = P.Cats() + P.Labs() + P.Exams();
            if (mark != null)
            {
                Console.WriteLine(mark);
            }
            else
            {
                Console.WriteLine("incomplete");
            }

            Console.ReadKey();
        }

       
    }

    class Marks
    {
        public double? Cats ()
        {
            int? cat1 = 20;
            int? cat2 = 30;
            int? cat3 = 20;
            double? totalcats = (cat1 + cat2 + cat3) / 3;
            return totalcats;
        }

        public double? Labs ()
        {
            int? lab1 = 10;
            int? lab2 = 5;
            int? lab3 = 5;
            double? totallabs = (lab1 + lab2 + lab3)/3;
            return totallabs;
        }

        public double? Exams ()
        {
            int? ex1 = 50;
            int? ex2 = 60;
            int? ex3 = 60;
            int? ex4 = 50;
            int? ex5 = 50;
            int? ex6 = 60;
            int? ex7 = 70;
            double? totalex = (ex1 + ex2 + ex3 + ex4 + ex5 + ex6 + ex7)/7;
            return totalex;
        }
    }
}
