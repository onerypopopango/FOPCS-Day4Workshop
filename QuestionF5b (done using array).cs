using System;
using System.Threading;

namespace Day3Workshop
{
    class F5b
    {
        static void Main(string[] args)
        {
            //int timing1 = 2000;         //for thread.sleep

            string[] names = new string[5] {"John", "Venkat", "Mary", "Victor", "Betty"};
            int[] marks = new int[5] {63, 29, 75, 82, 55};
            string charac1, charac2, temp = "";
            int tempInt = 0;
            char chr1, chr2, chr12, chr22;

            Console.WriteLine("Name\tMarks");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~");

            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    charac1 = names[i].Substring(0, 1);
                    chr1 = Convert.ToChar(charac1);
                    charac2 = names[j].Substring(0, 1);
                    chr2 = Convert.ToChar(charac2);

                    if (chr1 > chr2)
                    {
                        temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;
                        temp = "";

                        tempInt = marks[i];
                        marks[i] = marks[j];
                        marks[j] = tempInt;
                        tempInt = 0;
                    }

                    else if ((chr1 == chr2) && (i != j))
                    {
                        charac1 = names[i].Substring(1, 1);
                        chr12 = Convert.ToChar(charac1);
                        charac2 = names[j].Substring(1, 1);
                        chr22 = Convert.ToChar(charac2);

                        if (chr12 > chr22)
                        {
                            temp = names[i];
                            names[i] = names[j];
                            names[j] = temp;
                            temp = "";

                            tempInt = marks[i];
                            marks[i] = marks[j];
                            marks[j] = tempInt;
                            tempInt = 0;
                        }
                    }
                }

                Console.WriteLine(names[i]+ "\t" + marks[i]);
            }
        }
    }
}
