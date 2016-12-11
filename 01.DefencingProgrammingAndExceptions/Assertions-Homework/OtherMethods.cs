using System;
using System.Diagnostics;

namespace Others
{
    public class OtherMethods
    {
        public static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array cannot be null!");
            Debug.Assert(arr.Length > 0, "The array must have at least one element!");
            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "StartIndex should be between 0 and array's length");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "EndIndex should be between 0 and array's length");
            Debug.Assert(startIndex <= endIndex, "StartIndex should be smaller or equal to EndIndex");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }
            return minElementIndex;
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null || y != null, "The value to swap cannot be null!");

            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
