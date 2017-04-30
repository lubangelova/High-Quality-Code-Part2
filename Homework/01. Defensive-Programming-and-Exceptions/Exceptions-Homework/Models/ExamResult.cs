using System;

namespace Exceptions_Homework.Models
{
    public class ExamResult
    {
        private int grade;
        private int minGarde;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Grade must be positive!");
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGarde;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("MinGrade must be positive!");
                }

                this.minGarde = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value <= this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException("MaxGrade must be greater then minGrade");
                }

                this.maxGrade = value;
            }
        }
        
        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Comments can not be empty!");
                }

                this.comments = value;
            }
        }
    }
}
