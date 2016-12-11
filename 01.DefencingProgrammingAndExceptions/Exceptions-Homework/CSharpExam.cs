using System;

namespace StudentSystem
{
    public class CSharpExam : Exam
    {
        public const int minScore = 0;
        public const int maxScore = 100;
        public int score;

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
                if (value < minScore || value > maxScore)
                {
                    throw new ArgumentOutOfRangeException("The score must be between 0 and 100!");
                }
                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
