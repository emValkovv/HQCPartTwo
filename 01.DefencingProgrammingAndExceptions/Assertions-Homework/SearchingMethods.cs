using System;
using System.Diagnostics;

namespace Searching
{
    public class SearchingMethods
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array cannot be null!");
            Debug.Assert(arr.Length > 0, "The array must have at least one element!");
            Debug.Assert(value != null, "Value cannot be null");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array cannot be null!");
            Debug.Assert(arr.Length > 0, "The array must have at least one element!");
            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "StartIndex should be between 0 and array's length");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "EndIndex should be between 0 and array's length");
            Debug.Assert(startIndex <= endIndex, "StartIndex should be smaller or equal to EndIndex");
            Debug.Assert(value != null, "Value cannot be null");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
