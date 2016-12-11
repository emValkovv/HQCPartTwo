using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    class ExceptionsHomework
    {
        static void Main()
        {
            var substr = Utility.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Utility.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Utility.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 3);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Utility.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(Utility.ExtractEnding("I love C#", 2));
            Console.WriteLine(Utility.ExtractEnding("Nakov", 4));
            Console.WriteLine(Utility.ExtractEnding("beer", 4));
            Console.WriteLine(Utility.ExtractEnding("Hi", 1));

            if (Utility.CheckPrime(23))
            {       
                Console.WriteLine("23 is prime.");
            }
            else
            {
                Console.WriteLine("23 is not prime");
            }

            if (Utility.CheckPrime(33))
            {
                Console.WriteLine("33 is prime.");
            }
            else
            {
                Console.WriteLine("33 is not prime");
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}