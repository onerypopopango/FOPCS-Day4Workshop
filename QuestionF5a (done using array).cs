using System;
using System.Threading;

namespace Day3Workshop
{
    class F5a
    {
        static void Main(string[] args)
        {
            //int timing1 = 2000;         //for thread.sleep

            string[] names = new string[5] {"John", "Venkat", "Mary", "Victor", "Betty"};
            int[] marks = new int[5] {63, 29, 75, 82, 55};
            string temp = "";
            int tempInt = 0;
            int one, two;

            Console.WriteLine("Name\tMarks");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~");

            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    one = marks[i];
                    two = marks[j];

                    if (one > two)
                    {
                        tempInt = marks[i];
                        marks[i] = marks[j];
                        marks[j] = tempInt;
                        tempInt = 0;

                        temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;
                        temp = "";
                    }
                }

                Console.WriteLine(names[i]+ "\t" + marks[i]);
            }
        }
    }
}
