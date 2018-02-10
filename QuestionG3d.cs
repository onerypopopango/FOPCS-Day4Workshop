using System;
using System.Threading;

namespace Day3Workshop
{
    class G3d
    {
        static void Main(string[] args)
        {
            string input;
            int stud, sub, num;
            int a, b, n;
            bool isNum = false;

            Console.Write("How many students are there: ");
            stud = Int32.Parse(Console.ReadLine());
            Console.Write("How many subjects are there: ");
            sub = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You'll now input the marks for the students' different sujects. Type \"Done\" when you are finished.");

            double[,] marks = new double[stud, sub];

            for (a = 0; a < stud; a++)
            {
                for (b = 0; b < sub; b++)
                {
                    do
                    {
                        Console.Write("For student {0}, subject {1} marks is= ", (a + 1), (b + 1));
                        input = Console.ReadLine();
                        isNum = int.TryParse(input, out n);

                        if (isNum == true)
                        {
                            num = Int32.Parse(input);
                            marks[a, b] = num;
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry, but that seems to be invalid. Please try again.");
                        }
                    }
                    while (isNum == false);
                }
            }

            Console.WriteLine();

            double total = 0, avg = 0, varience = 0, sum = 0, stdDev = 0;
            int i, j;

            string[] student = new string[12];
            string[] subject = new string[4];

            for (i = 0; i < stud; i++)
            {
                student[i] = "Student " + (i + 1);

                for (j = 0; j < sub; j++)
                {
                    total = total + marks[i, j];
                }

                avg = total / 4;
                Console.WriteLine("{0} has total marks of {1} and an average of {2}.", student[i], total, avg);
                total = 0; 
                avg = 0;
            }

            Console.WriteLine();

            for (j = 0; j < sub; j++)
            {
                subject[j] = "Subject " + (j + 1);

                for (i = 0; i < stud; i++)
                {
                    total = total + marks[i, j];
                }

                avg = total / 12;

                for (i = 0; i < stud; i++)
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

            for (i = 0; i < stud; i++)
            {
                for (j = 0; j < sub; j++)
                {
                    total = total + marks[i, j];
                }
            }
            avg = total / (stud * sub);
            Console.WriteLine("\nThe overall average of marks for the whole class is {0:#.#####}", avg);

        }
    }
}
