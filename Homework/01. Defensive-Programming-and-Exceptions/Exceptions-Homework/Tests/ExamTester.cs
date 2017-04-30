using System;
using System.Collections.Generic;
using Exceptions_Homework.Contracts;
using Exceptions_Homework.Models;
using Exceptions_Homework.Utilities;

namespace Exceptions_Homework.Tests
{
    public class ExamTester
    {
        public static void Run()
        {
            try
            {
                GetPeterResults();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GetPeterResults()
        {
            List<IExam> peterExams = new List<IExam>()
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
