using System;
using System.Threading;

namespace Day3Workshop
{
    class G7
    {
        static void Main(string[] args)
        {
            string a, b, temp;
            char A, B;
            int num = 0;
            string[] name = new string[] { "Bob", "Dennis", "Alice", "Gina", "Eli", "Frank", "Charlie" };
            int[] score = new int[] { 90, 80, 100, 88, 76, 66, 120 };

            Console.WriteLine("Name\t\tScore");

            for (int i = 0; i < name.Length; i++)
            {
                for (int j = i + 1; j < name.Length; j++)
                {
                    a = name[i].Substring(0, 1);
                    b = name[j].Substring(0, 1);
                    A = Convert.ToChar(a);
                    B = Convert.ToChar(b);

                    if (A > B)
                    {
                        temp = name[i];
                        name[i] = name[j];
                        name[j] = temp;
                        temp = "";

                        num = score[i];
                        score[i] = score[j];
                        score[j] = num;
                        num = 0;

                    }
                }

                Console.WriteLine("{0}\t\t{1}", name[i], score[i]);
            }
                
        }
    }
}
