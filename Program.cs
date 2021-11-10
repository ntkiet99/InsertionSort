using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] arr = new int[n];
            string input;
            Console.WriteLine("\t Thuat Toan Insertion Sort");
            Console.WriteLine("Nhap du kieu: ");
            for (int l = 0; l < n; l++)
            {
                Console.Write("Nhap lan {0}: ", l+ 1);
                input = Console.ReadLine();
                arr[l] = int.Parse(input);
            }
            Console.WriteLine("Thuat toan:");
            Console.WriteLine("Lan: {0}", 1);
            PrintArray(arr);
            int i, key, j;
            for (i = 1; i < n; i++)
            {
                key = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                Console.WriteLine("Lan: {0}", i + 1);
                PrintArray(arr);
            }
            Console.Write("\nKet qua cuoi: ");
            PrintArray(arr);
            Console.ReadKey();
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
