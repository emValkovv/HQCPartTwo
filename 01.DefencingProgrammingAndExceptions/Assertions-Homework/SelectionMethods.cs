using Others;
using System;
using System.Diagnostics;

namespace Selection
{
    public class SelectionMethods
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array cannot be null!");
            Debug.Assert(arr.Length > 0, "The array must have at least one element!");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = OtherMethods.FindMinElementIndex(arr, index, arr.Length - 1);
                OtherMethods.Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }
    }
}
