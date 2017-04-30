using Exceptions_Homework.Tests;

namespace Exceptions_Homework
{
    public class StartUp
    {
        public static void Main()
        {
            ExamTester.Run();
            UtilitiesTester.RunSubSubsequeneTest();
            UtilitiesTester.RunExtractEndingTest();
            UtilitiesTester.RunCheckPrimeTest();
        }
    }
}
