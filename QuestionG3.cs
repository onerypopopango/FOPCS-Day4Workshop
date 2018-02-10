using System;
using System.Threading;

namespace Day3Workshop
{
    class G3
    {
        static void Main(string[] args)
        {
            double[,] marks = new double[12, 4];
            marks[0, 0] = 56; marks[0, 1] = 84; marks[0, 2] = 68; marks[0, 3] = 29;
            marks[1, 0] = 94; marks[1, 1] = 73; marks[1, 2] = 31; marks[1, 3] = 96;
            marks[2, 0] = 41; marks[2, 1] = 63; marks[2, 2] = 36; marks[2, 3] = 90;
            marks[3, 0] = 99; marks[3, 1] = 9; marks[3, 2] = 18; marks[3, 3] = 17;
            marks[4, 0] = 62; marks[4, 1] = 3; marks[4, 2] = 65; marks[4, 3] = 75;
            marks[5, 0] = 40; marks[5, 1] = 96; marks[5, 2] = 53; marks[5, 3] = 23;
            marks[6, 0] = 81; marks[6, 1] = 15; marks[6, 2] = 27; marks[6, 3] = 30;
            marks[7, 0] = 21; marks[7, 1] = 70; marks[7, 2] = 100; marks[7, 3] = 22;
            marks[8, 0] = 88; marks[8, 1] = 50; marks[8, 2] = 13; marks[8, 3] = 12;
            marks[9, 0] = 48; marks[9, 1] = 54; marks[9, 2] = 52; marks[9, 3] = 78;
            marks[10, 0] = 64; marks[10, 1] = 71; marks[10, 2] = 67; marks[10, 3] = 25;
            marks[11, 0] = 16; marks[11, 1] = 93; marks[11, 2] = 46; marks[11, 3] = 72;

            double total = 0, avg = 0, varience = 0, sum = 0, stdDev = 0;
            int i, j;

            string[] student = new string[12];
            string[] subject = new string[4];

            for (i = 0; i < 12; i++)
            {
                student[i] = "Student " + (i + 1);

                for (j = 0; j < 4; j++)
                {
                    total = total + marks[i, j];
                }

                avg = total / 4;
                Console.WriteLine("{0} has total marks of {1} and an average of {2}.", student[i], total, avg);
                total = 0; 
                avg = 0;
            }

            Console.WriteLine();

            for (j = 0; j < 4; j++)
            {
                subject[j] = "Subject " + (j + 1);

                for (i = 0; i < 12; i++)
                {
                    total = total + marks[i, j];
                }

                avg = total / 12;

                for (i = 0; i < 12; i++)
                {
                    sum = sum + ((marks[i, j] - avg) * (marks[i, j] - avg));
                }

                varience = sum / 12;
                stdDev = Math.Sqrt(varience);
                Console.WriteLine("{0} has total a class average of {1:#.#####} with standard deviation of {2:#.#####}.", subject[j], avg, stdDev);
                total = 0;
                avg = 0;
                sum = 0;
                varience = 0;
                stdDev = 0; 
            }

            for (i = 0; i < 12; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    total = total + marks[i, j];
                }
            }
            avg = total / (12 * 4);
            Console.WriteLine("\nThe overall average of marks for the whole class is {0:#.#####}", avg);
        }
    }
}
