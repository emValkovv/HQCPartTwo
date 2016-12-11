using System;
using Searching;
using Selection;

public class AssertionsHomework
{
    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionMethods.SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionMethods.SelectionSort(new int[0]); // Test sorting empty array
        SelectionMethods.SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(SearchingMethods.BinarySearch(arr, -1000));
        Console.WriteLine(SearchingMethods.BinarySearch(arr, 0));
        Console.WriteLine(SearchingMethods.BinarySearch(arr, 17));
        Console.WriteLine(SearchingMethods.BinarySearch(arr, 10));
        Console.WriteLine(SearchingMethods.BinarySearch(arr, 1000));
    }
}
