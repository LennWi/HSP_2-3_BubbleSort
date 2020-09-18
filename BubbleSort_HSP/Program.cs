using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_HSP
{
    class Program
    {
        static void Main()
        { 
            int[] intArray = new int[10] { 7, 6, 3, 2, 1, 6, 23, 1, 78, 4};

            Sortierer sort1 = new Sortierer(intArray);

            Console.ReadKey();
        }
    }

    class Sortierer
    {

        private bool istGetauscht;
        private int[] inArray;
        private int[] outArray;

        public Sortierer(int[] intArray)
        {
            inArray = intArray;
            outArray = BubbleSort(inArray);

            foreach(int iZahl in outArray)
            {
                Console.WriteLine(iZahl);
            }
        }

        public int[] BubbleSort(int[] intArray)
        {
            do
            {
                istGetauscht = false;

                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        int iTemp = intArray[i];
                        intArray[i] = intArray[i + 1];
                        intArray[i + 1] = iTemp;

                        istGetauscht = true;
                    }
                }
            } while (istGetauscht == true);

            return intArray;
        }
    }
}
