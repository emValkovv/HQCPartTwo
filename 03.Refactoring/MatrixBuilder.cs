namespace Mathematics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MatrixBuilder
    {
        private int sizeOfMatrix;
        private int[,] matrix;

        public MatrixBuilder(int sizeOfMatrix)
        {
            this.SizeOfMatrix = sizeOfMatrix;
        }

        public int SizeOfMatrix
        {
            get
            {
                return this.SizeOfMatrix;
            }

            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The size of matrix must be between 1 ana 100!");
                }
                
                this.sizeOfMatrix = value;
            }
        }

        public int[,] MatrixBuild()
        {
            int n = this.sizeOfMatrix;
            this.matrix = new int[n, n];
            int startNumber = 1;
            int row = 0;
            int col = 0;

            MatrixLoop(this.matrix, row, col, ref startNumber, n);
            startNumber++;

            FindEmptyCell(this.matrix, ref row, ref col);

            MatrixLoop(this.matrix, row, col, ref startNumber, n);
            return this.matrix;
        }

        public void PrintMatrix()
        {
            if (this.matrix == null)
            {
                throw new ArgumentNullException("The matrix cannot be null. You need to build it first!");
            }

            for (int row = 0; row < this.sizeOfMatrix; row++)
            {
                for (int col = 0; col < this.sizeOfMatrix; col++)
                {
                    Console.Write("{0,3}", this.matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void MatrixLoop(int[,] matrix, int row, int col, ref int startNumber, int n)
        {
            int deltaX = 1;
            int deltaY = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[row, col] = startNumber;

                    if (!MatrixCheck(matrix, row, col))
                    {
                        break;
                    }

                    while (row + deltaX >= n ||
                            row + deltaX < 0 ||
                            col + deltaY >= n ||
                            col + deltaY < 0 ||
                            matrix[row + deltaX, col + deltaY] != 0)
                    {
                        DirectionChange(ref deltaX, ref deltaY);
                    }

                    row += deltaX;
                    col += deltaY;
                    startNumber++;
                }
            }
        }

        private static void DirectionChange(ref int deltaX, ref int deltaY)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int directionIndex = 0;

            for (int count = 0; count < directionX.Length; count++)
            {
                if (directionX[count] == deltaX && directionY[count] == deltaY)
                {
                    directionIndex = count;
                    break;
                }
            }

            if (directionIndex == directionX.Length - 1)
            {
                deltaX = directionX[0];
                deltaY = directionY[0];
                return;
            }

            deltaX = directionX[directionIndex + 1];
            deltaY = directionY[directionIndex + 1];
        }

        private static bool MatrixCheck(int[,] arr, int x, int y)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < 8; i++)
            {
                if (x + directionX[i] >= arr.GetLength(0) || x + directionX[i] < 0)
                {
                    directionX[i] = 0;
                }

                if (y + directionY[i] >= arr.GetLength(0) || y + directionY[i] < 0)
                {
                    directionY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + directionX[i], y + directionY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void FindEmptyCell(int[,] arr, ref int x, ref int y)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }
    }
}