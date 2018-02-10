using System;
using System.Threading;

namespace Day3Workshop
{
    class G8
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int R = rnd.Next(2, 5);
            int r = rnd.Next(2, 5);
            int[,] numArray = new int[R, r];
            int num, i, j, temp = 0;
            bool correctNum = false;

            for (i = 0; i < R; i++)
            {
                for (j = 0; j < r; j++)
                {
                    num = rnd.Next(1, 20);
                    numArray[i,j] = num;
                    num = 0;
                }
            }

            Console.WriteLine("Let's play a game. I've come up with a multi dimensional array.");
            Console.WriteLine("In it I've put some numbers.");
            Console.WriteLine("Try and guess a number. I will tell it's position if it's in my mind.");
            Console.WriteLine();

            while (correctNum == false)
            {
                Console.Write("Enter a number between 1 and 20: ");
                string input = Console.ReadLine();
                int n = Int32.Parse(input);

                for (i = 0; i < R; i++)
                {
                    for (j = 0; j < r; j++)
                    {
                        temp = numArray[i, j];

                        if (n == temp)
                        {
                            Console.WriteLine("Number {0} is found in the array at [{1},{2}]", n, i, j);
                            correctNum = true;
                        }
                    }
                }

                if (correctNum == false)
                {
                    Console.WriteLine("Number {0} is not found. Try again.\n", n);
                }
            }

            Console.WriteLine();

            for (i = 0; i < R; i++)
            {
                for (j = 0; j < r; j++)
                {
                    Console.Write(numArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
