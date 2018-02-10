using System;
using System.Threading;

namespace Day3Workshop
{
    class G5
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int R = rnd.Next(2, 10);
            int[] numArray = new int[R];    //need to randomize without duplicates, solve in own time
            int num, guess, posn = 0;
            bool isNum = false;
            string input;

            for (int i = 0; i < R; i++)
            {
                num = rnd.Next(1, 10);
                numArray[i] = num;
                num = 0;
            }

            Console.WriteLine(string.Join(" ", numArray));

            Console.WriteLine("Enter a number between 1 and 10:");

            do
            {
                input = Console.ReadLine();
                guess = Int32.Parse(input);

                for (int j = 0; j < R; j++)
                {
                    num = numArray[j];

                    if (guess == num)
                    {
                        isNum = true;
                        posn = j + 1;
                    }
                }

                if (isNum == false)
                {
                    Console.WriteLine("-1");
                    Console.Write("Try again: ");
                    isNum = false;
                    num = 0;
                }
            }
            while (isNum == false);

            if (isNum == true)
            {
                Console.WriteLine("Number {0} is found in the array at the element number {1}.)", guess, posn);
            }
        }
    }
}
