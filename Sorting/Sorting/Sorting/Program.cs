using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unSortedArray = { 4, 9, 7, 5, 8, 9, 3 };
            int[] sortedArray = { 4, 9, 7, 5, 8, 9, 3 };
            Array.Sort(sortedArray);

            PrintingSwap(unSortedArray, sortedArray, unSortedArray.Length);
        }

        public static void PrintingSwap(int[] unSortedArray, int[] sortedArray, int n)
        {
            int temp;
            int swaps = 0;
            bool isLoop = false;
            List<string> results = new List<string>();

            while (!isLoop)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (unSortedArray[i] > unSortedArray[i + 1])
                    {
                        int left = unSortedArray[i + 1];
                        int right = unSortedArray[i];

                        temp = unSortedArray[i + 1];
                        unSortedArray[i + 1] = unSortedArray[i];
                        unSortedArray[i] = temp;
                        swaps++;

                        string arrString = string.Empty;

                        foreach (int num in unSortedArray)
                        {
                            arrString += num + " ";
                        }

                        string rowString = "[" + left + "," + right + "] -> " + arrString;
                        results.Add(rowString);
                        break;
                    }
                    
                }

                isLoop = _Comparation(unSortedArray, sortedArray, n); //false

            }

            int no = 1;
            foreach(string str in results)
            {
                Console.WriteLine(no + ". " + str);
                no++;
            }

            Console.WriteLine();
            Console.WriteLine("Jumlah swap: " + swaps);
            Console.ReadKey();
           
        }

        private static bool _Comparation(int[] unSortedArray, int[] sortedArray, int n)
        {
            bool result = true;
            for(int i = 0; i < n; i++)
            {
                if(unSortedArray[i] != sortedArray[i])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
