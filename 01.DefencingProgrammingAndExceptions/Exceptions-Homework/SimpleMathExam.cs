using System;

namespace StudentSystem
{
    public class SimpleMathExam : Exam
    {
        public int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            if (problemsSolved < 0)
            {
                problemsSolved = 0;
            }
            if (problemsSolved > 10)
            {
                problemsSolved = 10;
            }

            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }
            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new IndexOutOfRangeException("Solved problems must be between 0 and 10!");
                }
                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            if (ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
            else if (ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            }
            else if (ProblemsSolved == 2)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }
            else if (ProblemsSolved == 3)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }
            else if (ProblemsSolved == 4)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }
            else if (ProblemsSolved == 5)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }
            else if (ProblemsSolved == 6)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }
            else if (ProblemsSolved == 7)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }
            else if (ProblemsSolved == 8)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }
            else if (ProblemsSolved == 9)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }
            else if (ProblemsSolved == 10)
            {
                return new ExamResult(6, 2, 6, "Average result: sehr gut, mein Freund.");
            }
            return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }
    }
}
