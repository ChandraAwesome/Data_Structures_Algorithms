using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms
{
    public class Merge_Sort
    {
        public static void mergeSort(int[] arr)
        {
            if (arr.Length > 1)
            {
                int mid = arr.Length / 2;
                int[] left = new int[mid];
                int[] right = new int[arr.Length - mid];

                for (int i = 0; i < mid; i++)
                {
                    left[i] = arr[i];
                }
                for (int i = mid; i < arr.Length; i++)
                {
                    right[i - mid] = arr[i];
                }

                mergeSort(left);
                mergeSort(right);
                merge(arr, left, right);
            }
        }

        public static void merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }


    }
}

