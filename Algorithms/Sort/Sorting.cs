using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class Sorting
    {

        public static void BubbleSort(int[] array)
        {
            for(int wall = array.Length - 1; wall > 0; wall--)
            {
                for(int i = 0; i < wall; i++)
                {
                    int j = i + 1;
                    if (array[i] > array[j])
                    {
                        Swap(array,i,j);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {

        }

        public static void InsertSort(int[] array)
        {

        }

        public static void ShellSort(int[] array)
        {

        }

        public static void MergeSort(int[] array)
        {

        }

        public static void QuickSort(int[] array)
        {

        }




        private static void Swap(int[] array,int i,int j)
        {
            if(i==j) return;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }



    }
}
