using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{

    delegate int Compare(int a, int b);

    class MainApp
    {
        //Comparer대리자는 익명메소드인  delegate(int a, int b)를 받아온다.
        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending ...");
            
            BubbleSort(array, delegate(int a, int b)
                { 
                    if(a > b)
                    {
                        return 1;
                    }
                    else if(a == b)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            );

         
        }
    }


}
