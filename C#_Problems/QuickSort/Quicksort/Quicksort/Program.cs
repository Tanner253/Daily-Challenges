using System;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        void quickSort(int[] arr, int left, int right)
        {
            int indx = partition(arr, left, right);
            if( left < indx - 1)
            {
                //sort the left half
                quickSort(arr, left, right);
            }
            if( indx < right)
            {
                //sort the right half
                quickSort(arr, indx, right);
            }
        }

        int partition (int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            while (left <= right)
            {
                while (arr[left] > pivot) left++;
                while (arr[left] < pivot) right++;
                if (left <= right)
                {
                    swap(arr, left, right);
                    left++;
                    right--;
                }
            }
            return left;

        }
    }
}
