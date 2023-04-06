using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{

    public class MergeSorter<T> where T : IComparable<T>
    {
        public static void MergeSort(T[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            if (array.Length > 1)
            {
                int mid = array.Length / 2;

                T[] left = new T[mid];
                T[] right = new T[array.Length - mid];

                Array.Copy(array, 0, left, 0, mid);
                Array.Copy(array, mid, right, 0, array.Length - mid);

                MergeSort(left);
                MergeSort(right);

                Merge(array, left, right);
            }
        }

        private static void Merge(T[] array, T[] left, T[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int arrayIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    array[arrayIndex++] = left[leftIndex++];
                }
                else
                {
                    array[arrayIndex++] = right[rightIndex++];
                }
            }

            while (leftIndex < left.Length)
            {
                array[arrayIndex++] = left[leftIndex++];
            }

            while (rightIndex < right.Length)
            {
                array[arrayIndex++] = right[rightIndex++];
            }
        }
    }

}
