using System;
using Exceptions_Homework.Contracts;

namespace Exceptions_Homework.Models
{
    public class CSharpExam : IExam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < MinScore || value > MaxScore)
                {
                    throw new ArgumentOutOfRangeException("Score must be between 0 and 100!");
                }

                this.score = value;
            }
        }

        public ExamResult Check()
        {
            var examResult = new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
            return examResult;
        }
    }
}
