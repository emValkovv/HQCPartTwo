using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Utility
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array cannot be null or empty");
            }
            if (arr.Length <= startIndex || startIndex < 0)
            {
                throw new IndexOutOfRangeException("Start index must be between 0 and array's length!");
            }
            if (count < 0 || count >= arr.Length)
            {
                throw new ArgumentOutOfRangeException("The count must be between 0 and array's length!");
            }
            if (startIndex + count > arr.Length)
            {
                throw new ArgumentException("Start index + count must be lower than array's length");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }
            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length || count < 0)
            {
                throw new ArgumentOutOfRangeException("Count must be between 0 and str's Length!");
            }

            if (str == null || str == "")
            {
                throw new ArgumentNullException("String cannot be null or empty!");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }
            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            if (number < 2)
            {
                throw new ArgumentException("The number must be greater than 0!");
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
