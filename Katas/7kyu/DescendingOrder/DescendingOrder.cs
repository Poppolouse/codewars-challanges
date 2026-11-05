using System.Reflection.Metadata.Ecma335;

namespace Codewars.Katas._7kyu.DescendingOrder
{

    /*
     https://www.codewars.com/kata/5467e4d82edf8bbf40000155/train/csharp

    Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order.
    Essentially, rearrange the digits to create the highest possible number.

    Examples:
    Input: 42145 Output: 54421

    Input: 145263 Output: 654321

    Input: 123456789 Output: 987654321

     */


    internal class Solution
    {

        /// <summary>
        /// This method takes a non-negative integer as input and returns the integer with its digits rearranged in descending order.
        /// It converts the integer to a string, finds the largest digit iteratively, and constructs a new integer from the sorted digits.
        /// </summary>
        /// <param name="number">A non-negative integer to be rearranged.</param>
        /// <returns>The integer with its digits in descending order.</returns>
        /// 
        /// <example>
        /// <code>
        /// int result = Solution.DescendingOrder(42145); // 54421
        /// </code>
        /// </example>
        public static int DescendingOrder(int number)
        {
            string str = number.ToString();
            int[] toBeReturned = new int[str.Length];
            int arrayLength = str.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                char currentBiggestNumber = '0';

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] > currentBiggestNumber)
                    {
                        currentBiggestNumber = str[j];
                    }
                }

                toBeReturned[i] = int.Parse(currentBiggestNumber.ToString());
                str = str.Remove(str.IndexOf(currentBiggestNumber), 1);
            }

            return RearrangeDigits(toBeReturned);

        }

        /// <summary>
        /// Combines the elements of an integer array and converts the resulting string to an integer.
        /// </summary>
        /// <param name="toBeReturned">The array of integers to combine.</param>
        /// <returns>The integer represented by the concatenated array elements.</returns>
        /// 
        /// <example>
        /// <code>
        /// int result = Solution.RearrangeDigits(new int[] { 5, 4, 4, 2, 1 }); // 54421
        /// </code>
        /// </example>
        private static int RearrangeDigits(int[] toBeReturned)
        {
            string toBeConverted = string.Empty;

            for (int i = 0; i < toBeReturned.Length; i++)
            {
                toBeConverted = toBeConverted + toBeReturned[i].ToString();
            }

            int finalResult = int.Parse(toBeConverted);

            return finalResult;
        }
    }
}
