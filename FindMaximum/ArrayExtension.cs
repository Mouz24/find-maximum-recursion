using System;

#pragma warning disable CA1062

namespace FindMaximumTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds the element of the array with the maximum value recursively.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int FindMaximum(int[] array)
        {
           if (array is null)
           {
                throw new ArgumentNullException(nameof(array));
           }

           if (array.Length == 0)
           {
                throw new ArgumentException($"{array.Length}");
           }

           return Find(array, 0, array.Length);
        }

        public static int Find(int[] array, int i, int length)
        {
            if (i == length - 1)
            {
                return array[i];
            }

            int middle = (i + length) / 2;
            int left_side = Find(array, i, middle);
            int right_side = Find(array, middle, length);
            if (left_side > right_side)
            {
                return left_side;
            }
            else
            {
                return right_side;
            }
        }
    }
}
