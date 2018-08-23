using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace CSharp_base
{
    static class SortAlgorithms
    {
        public static void Test()
        {
            Random random = new Random();
            int[] numbers = new int[random.Next(1000090)];
            int[] numbers2 = new int[numbers.Length];


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(10000);
                //Thread.Sleep(100);
            }

            Array.Copy(numbers, numbers2, numbers.Length);
            //int[] numbers2 = numbers; //wskaznik

            //for (int i = 0; i < numbers.Length; i++)
            //    Console.Write(numbers[i] + " ");

            //Console.WriteLine();
            //for (int i = 0; i < numbers2.Length; i++)
            //    Console.Write(numbers2[i] + " ");

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Numbers: " + numbers.Length);
            
            Console.WriteLine();
            Console.WriteLine("Example Bubble Sort");

            stopwatch.Start();
            BubbleSort(numbers, numbers.Length);
            stopwatch.Stop();

            Console.WriteLine("Time taken : {0}", stopwatch.Elapsed);

            Console.WriteLine("Example Quick Sort");
            stopwatch.Reset();

            stopwatch.Start();
            QuickSort(numbers2, 0, numbers2.Length - 1);
            stopwatch.Stop();

            Console.WriteLine("Time taken : {0}", stopwatch.Elapsed);

            //for (int i = 0; i < numbers.Length; i++)
            //    Console.Write(numbers[i] + " ");

            //Console.WriteLine();
            //for (int i = 0; i < numbers2.Length; i++)
            //    Console.Write(numbers2[i] + " ");

        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1) QuickSort(arr, left, pivot - 1);

                if (pivot + 1 < right) QuickSort(arr, pivot + 1, right);
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while(true)
            {
                while (arr[left] < pivot)
                    left++;

                while (arr[right] > pivot)
                    right--;

                if (left < right)
                {
                    
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    if (arr[left] == arr[right]) left++; //return right;
                }
                else
                    return right;
            }
        }

        public static void BubbleSort(int[] arr, int length)
        {
            int tmp = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }

    }
}
