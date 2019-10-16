using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        void MergeSort(int[] arr)
        {
            int[] helper = new int[arr.Length];
            MergeSort(arr, helper, 0, arr.Length - 1)
        };
        void MergeSort(int[] arr, int[] helper, int low, int high)
        {
            int middle = (low + high) / 2;
            if(low < high)
            {
                MergeSort(arr, helper, low, middle);
                MergeSort(arr, helper, middle + 1, high);
                MergeSort(arr, helper, low, middle, high);
            }
        }
        void MergeSort(int[] arr, int[] helper, int low, int middle, int high)
        {
           for(int i = low; i <= high; i++)
            {
                helper[i] = arr[i];
            }
            int helperLeft = low;
            int helperRight = middle + 1;
            int current = low;

            while (helperLeft <= middle && helperRight <= high)
            {
                if (helper[helperLeft] < helper[helperRight])
                {
                    arr[current] = helper[helperLeft];
                    helperLeft++;
                }else
                {
                    arr[current] = helper[helperRight];
                    helperRight++;

                }
                current++;
            }
            for( int i = 0; i <= arr.Length; i++)
            {
                arr[current + i] = helper[helperLeft + i];
            }
        }
       
    }
}
