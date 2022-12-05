using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3. Сформировать массив из 15 целых чисел, выбранных случайным 
    образом из интервала [10, 90]. Поменять местами первый 
    и минимальный элементы. */

namespace Lab_4_1_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Random random = new Random();

            arr[0] = random.Next(10, 90);
            int index = 0;
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = random.Next(10, 90);
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }                    
            }
            Console.WriteLine($"index={index}, min={min}");

            foreach (var item in arr)            
                Console.Write(item + " ");

            Console.WriteLine();
            Console.WriteLine("Измененный массив:");
            (arr[0], arr[index]) = (arr[index], arr[0]);
            foreach (var item in arr)            
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
