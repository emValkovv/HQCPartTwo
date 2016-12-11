namespace Matrica.Tests
{
    using System;
    using Mathematics;
    using NUnit.Framework;

    [TestFixture]
    public class MatrixBuilderTest
    {
        [TestCase(0)]
        [TestCase(-43)]
        [TestCase(101)]
        [TestCase(12345)]
        [TestCase(-54313)]
        public void BulildMatrix_ShouldBuildMatrix_WhenSizeIsOutOfRange(int size)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MatrixBuilder(size));
        }

        [TestCase(6)]
        public void MatrixPrint_ShouldBeEqual_ToTheExceptedMatrix(int size)
        {
            int[,] expectedMatrix = new int[6, 6]
                {
                    {1, 16, 17, 18, 19, 20 },
                    {15, 2, 27, 28, 29, 21 },
                    {14, 31, 3, 26, 30, 22 },
                    {13, 36, 32, 4, 25, 23 },
                    {12, 35, 34, 33, 5, 24},
                    {11, 10, 9, 8, 7, 6},
                };
            var matrix = new MatrixBuilder(size);

            Assert.AreEqual(expectedMatrix, matrix.MatrixBuild());
        }
    }
}
