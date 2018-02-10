using System;
using System.Threading;

namespace Day3Workshop
{
    class F4
    {
        static void Main(string[] args)
        {
            int timing1 = 2000;         //for thread.sleep

            Console.WriteLine("Write down a sentence or phrase with no capital letters: ");
            string Str = Console.ReadLine();                //takes input and converts all into lower case
            string x, y, z;
            string Y, final = "";

            string[] s = Str.Split(' ');            //splits Str into an array (x, 1).

            //Console.WriteLine(s.Length);          //length of the array produced. For "Happy days are here again" s.length is 5

            for (int i = 0; i < s.Length; i++)      //it's (< s.length) because arrays start from 0...
            {
                Y = "";                             //resets the string Y so it adds fresh results to final
                z = s[i];

                for (int j = 0; j < z.Length; j++)
                {
                    x = z.Substring(j, 1);
                    y = "";

                    switch (j)
                    {
                        case 0:
                            y = x.ToUpper();
                            break;

                        default:
                            y = x;
                            break;
                    }

                    Y = Y + y;
                }

                final = final + Y + " ";
            }

            final.TrimEnd(' ');

            Console.WriteLine("\nCapitalising...\n");
            Thread.Sleep(timing1);

            string tildeU = "", tildeL = "";

            for (int k = 0; k < final.Length; k++)
            {
                tildeU = tildeU + "~";

            }

            Console.WriteLine(tildeU);
            Console.WriteLine(final);

            for (int l = 0; l < final.Length; l++)
            {
                tildeL = tildeL + "~";

            }

            Console.WriteLine(tildeL);
        }
    }
}
