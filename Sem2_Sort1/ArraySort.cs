using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Sort1
{
    public static class ArraySort
    {
        public static int[] RandomArray(int length)
        {
            int[] a = new int[length];
            Random r = new Random();
            for (int i = 0; i < length; i++)
                a[i] = r.Next(10, 99);
            return a;
        }

        public static void BubbleSort(int[] arr, out int compareCount, out int changeCount)
        {
            compareCount = changeCount = 0;
            for (int i = 1; i < arr.Length; i++)
                for (int j = arr.Length - 1; j >= i; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                        changeCount++;
                    }
                    compareCount++;
                }
        }

        public static void ShakerSort(int[] arr, out  int compareCount, out int changeCount)
        {
            compareCount = changeCount = 0;
            int left = 1, right = arr.Length - 1, last = right;
            do
            {
                for (int j = right; j >= left; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int t = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = t;
                        last = j;
                        changeCount++;
                    }
                    compareCount++;
                }
                left = last;
                for (int j = left; j <= right; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int t = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = t;
                        last = j;
                        changeCount++;
                    }
                    compareCount++;
                }
                right = last - 1;
            }
            while (left < right);
        }
    }
}
