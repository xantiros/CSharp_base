using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp_base
{
    static class SortAlgorithms
    {
        public static void Test()
        {
            Random random = new Random();
            int[] numbers = new int[random.Next(100000)];
            int[] numbers2 = new int[numbers.Length];


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100000);
                //Thread.Sleep(100);
            }

            Array.Copy(numbers, numbers2, numbers.Length);
            //int[] numbers2 = numbers; //wskaznik

            Console.WriteLine("Example Bubble Sort");

            DateTime time_start = DateTime.Now;
            Console.WriteLine("Start: " + time_start);

            BubbleSort(numbers, numbers.Length);

            DateTime time_end = DateTime.Now;
            Console.WriteLine("End: " + time_start);
            Console.WriteLine(time_end - time_start);

            //for (int i = 0; i < numbers.Length; i++)
            //    Console.Write(numbers[i] + " ");

            //Console.WriteLine();
            //for (int i = 0; i < numbers2.Length; i++)
            //    Console.Write(numbers2[i] + " ");

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
