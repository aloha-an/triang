using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] triang = new int[15][];
            triang[0] = new int[] {75};
            triang[1] = new int[] { 95, 64 };
            triang[2] = new int[] { 17, 47, 82 };
            triang[3] = new int[] { 18, 35, 87, 10};
            triang[4] = new int[] { 20, 04, 82, 47, 65 };
            triang[5] = new int[] { 19, 01, 23, 75, 03, 34 };
            triang[6] = new int[] { 88, 02, 77, 73, 07, 63, 67 };
            triang[7] = new int[] { 99, 65, 04, 28, 06, 16, 70, 92 };
            triang[8] = new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 };
            triang[9] = new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 };
            triang[10] = new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 };
            triang[11] = new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 };
            triang[12] = new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 };
            triang[13] = new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 };
            triang[14] = new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 };
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < triang[i].Length; j++)
                {
                    Console.Write("{0,2} ", triang[i][j]);
                }
                Console.Write("\n");
            }
            int sum = triang[0][0];
            int index = 0;
            int ind = 0;
            int num = 200;
            int max = 0;
            Console.Write("\nSum= {0,2}", triang[0][0]);
            for (int i = 1; i < 15; i++)
            {
                index = ind;
                if (index > 0 && index < triang[i].Length - 1)
                {
                    max = triang[i][index];
                    for (int j = index - 1; j < index + 2; j++)
                        if (max < triang[i][j])
                        {
                            max = triang[i][j];
                            ind = j;
                        }
                }
                else
                {
                    if (index == (triang[i].Length - 1))
                    {
                        //if (triang[i][index] > triang[i][index - 1])
                        //    ind=index;
                        if (triang[i][index] < triang[i][index - 1])
                            ind = index - 1;
                        else
                            ind = index;
                    }

                    if (index == 0)
                    {
                        if (triang[i][index] < triang[i][index + 1])
                            ind = index+1;
                        else
                            ind = index;
                    }
                    if (index > triang[i].Length - 1)
                        ind = triang[i].Length - 1;
                }
                sum += triang[i][ind];
                Console.Write("+{0,2}",triang[i][ind]);
            }
            Console.Write("\n\n\nSum= {0}\n",sum);
        }
    }
}
