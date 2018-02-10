using System;
using System.Threading;

namespace Day3Workshop
{
    class G2
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[10];
            Random rnd = new Random();
            int R = 0;

            int a, b, temp = 0;

            Console.WriteLine("Here is a list of numbers:");

            for (int i = 0; i < 10; i++)
            {
                R = rnd.Next(1, 1000);
                numArray[i] = R;
                R = 0;
                Console.Write(numArray[i] + " ");

            }

            Console.WriteLine("\nNow to arrange in descending order...\n");

            for (int j = 0; j < 10; j++)
            {
                for (int k = j + 1; k < 10; k++)
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

                for (int l = 0; l < 10; l++)
                {
                    Console.Write(numArray[l] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
