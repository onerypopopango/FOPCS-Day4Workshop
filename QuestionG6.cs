using System;
using System.Threading;

namespace Day3Workshop
{
    class G6
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int R = rnd.Next(5, 15);
            int[] numArray = new int[R];
            int num, a, b, temp = 0;

            for (int i = 0; i < R; i++)
            {
                num = rnd.Next(1, 20);
                numArray[i] = num;
                num = 0;
            }

            for (int j = 0; j < R; j++)
            {
                for (int k = j + 1; k < R; k++)
                {
                    a = numArray[j];
                    b = numArray[k];

                    if (a > b) 
                    {
                        temp = numArray[j];
                        numArray[j] = numArray[k];
                        numArray[k] = temp;
                        temp = 0;
                    }
                }
            }

            Console.WriteLine("There are {0} elements in the array generated:", R);
            Console.WriteLine(string.Join(", ", numArray));                 //to print content of an array without loops

            for (int j = 0; j < R; j++)
            {
                for (int k = j + 1; k < R; k++)
                {
                    a = numArray[j];
                    b = numArray[k];

                    if (a < b)
                    {
                        temp = numArray[j];
                        numArray[j] = numArray[k];
                        numArray[k] = temp;
                        temp = 0;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numArray)); 
        }
    }
}
