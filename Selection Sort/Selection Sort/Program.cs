using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void SelectionSort(int[] selection)
        {
            for (int i = 0; i < selection.Length; i++)
            {
                int smallestNumber = int.MaxValue;
                int smallestIndex = -1;

                for (int j = i; j < selection.Length; j++)
                {
                    if (smallestNumber > selection[j])
                    {
                        smallestNumber = selection[j];
                        smallestIndex = j;
                    }                    
                }

                if (i != smallestIndex)
                {
                    int numberSwap = selection[smallestIndex];
                    selection[smallestIndex] = selection[i];
                    selection[i] = numberSwap;
                }
            }
        }
        static void Main(string[] args)
        {
            
            Random gen = new Random();
            int[] tempArray = new int[10];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = gen.Next(1, 11);
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                Console.Write($"{tempArray[i]} ");
            }

            Console.WriteLine();

            SelectionSort(tempArray);

            for (int i = 0; i < tempArray.Length; i++)
            {
                Console.Write($"{tempArray[i]} ");
            }
            Console.ReadKey();
        }
    }
}