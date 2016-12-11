namespace Mathematics
{
    using System;

    public class MatrixProgram
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            int n = int.Parse(Console.ReadLine());
            MatrixBuilder matrix = new MatrixBuilder(n);

            matrix.MatrixBuild();
            matrix.PrintMatrix();
        }
    }
}
