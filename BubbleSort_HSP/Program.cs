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
        static void Main()  //Hauptprogramm
        { 
            int[] intArray = new int[10] { 7, 6, 3, 2, 1, 6, 23, 1, 78, 4};    //erzeuge Array und befülle es

            Sortierer sort1 = new Sortierer(intArray);  //neues Objekt Sortierer, Array wird übergeben

            Console.ReadKey();  //Warte auf Tastendruck
        }
    }

    class Sortierer
    {

        private bool istGetauscht;
        private int[] inArray;          //eigehendes Array (unsortiert)
        private int[] outArray;         //ausgehendes Array (sortiert)

        public Sortierer(int[] intArray)
        {
            inArray = intArray;
            outArray = BubbleSort(inArray);

            foreach(int iZahl in outArray)  //Ausgabe des sortierten Arrays
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
                        // Zahlen werden vertauscht
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
