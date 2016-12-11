using System;

namespace StudentSystem
{
    public class ExamResult
    {
        public int grade;
        public int minGrade;
        public int maxGrade;
        public string comments;

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
                if (grade < 0)
                {
                    throw new ArgumentException("The grade must be bigger than 0!");
                }
                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }
            private set
            {
                if (value < this.MinGrade)
                {
                    throw new ArgumentException("The min grade must be smaller or equal to max grade!");
                }
                this.minGrade = value;
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
                if (value < 0)
                {
                    throw new ArgumentException("The grade must be bigger than 0!");
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
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("The comments cannot be null or empty!");
                }
                this.comments = value;
            }
        }
    }
}
