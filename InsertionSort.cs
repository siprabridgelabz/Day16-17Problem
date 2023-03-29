using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDemo
{
    public  class InsertionSort
    {
        public void Insertionsort()
        {
            int[] arr = new int[5] { 23, 5, 7, 32, 1 };
            int n = 5, i, j, val, flag;
            Console.WriteLine("Insertion Sort");

            Console.WriteLine("Initial array ");
            for (i = 1; i < n; i++)
            {
                val = arr[1];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }

            Console.WriteLine("Sorted Array ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
    }
}
