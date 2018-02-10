using System;
using System.Threading;

namespace Day3Workshop
{
    class F6
    {
        static void Main(string[] args)
        {
            int timing1 = 1000;         //for thread.sleep
            string input, matri, last;
            int checksum;
            int a, b, c, d, e, n, r;
            bool isNumeric;
            bool lastLetterCheck = true;
            bool validation = false;

            do
            {
                Console.Write("Type in your matriculation number please:");
                input = Console.ReadLine();
                matri = input.ToUpper();

                if ((matri.Length != 7) || (matri.Substring(0,1) != "A"))
                {
                    Console.WriteLine("I'm sorry, but that number seems to be invalid.\n");
                    Thread.Sleep(timing1);
                }

            }
            while ((input.Length != 7) || (matri.Substring(0,1) != "A") || (isNumeric = false));

            do
            {
                isNumeric = int.TryParse(matri.Substring(1, 5), out n);
                if (isNumeric == false)
                {
                    Console.WriteLine("I'm sorry, but that number seems to be invalid.\n");
                    Thread.Sleep(timing1);
                    Console.Write("Type in your matriculation number please:");
                    input = Console.ReadLine();
                    matri = input.ToUpper();
                }

                else
                {
                    a = Int32.Parse(matri.Substring(1, 1));
                    b = Int32.Parse(matri.Substring(2, 1));
                    c = Int32.Parse(matri.Substring(3, 1));
                    d = Int32.Parse(matri.Substring(4, 1));
                    e = Int32.Parse(matri.Substring(5, 1));

                    checksum = (a * 6) + (b * 5) + (c * 4) + (d * 3) + (e * 2);
                    r = checksum % 5;

                    switch (r)
                    {
                        case 0:
                            last = matri.Substring(6, 1);
                            if (last != "O")
                            {
                                lastLetterCheck = false;
                            }
                            else
                            {
                                lastLetterCheck = true;
                            }
                            break;

                        case 1:
                            last = matri.Substring(6, 1);
                            if (last != "P")
                            {
                                lastLetterCheck = false;
                            }
                            else
                            {
                                lastLetterCheck = true;
                            }
                            break;

                        case 2:
                            last = matri.Substring(6, 1);
                            if (last != "Q")
                            {
                                lastLetterCheck = false;
                            }
                            else
                            {
                                lastLetterCheck = true;
                            }
                            break;

                        case 3:
                            last = matri.Substring(6, 1);
                            if (last != "R")
                            {
                                lastLetterCheck = false;
                            }
                            else
                            {
                                lastLetterCheck = true;
                            }
                            break;

                        case 4:
                            last = matri.Substring(6, 1);
                            if (last != "S")
                            {
                                lastLetterCheck = false;
                            }
                            else
                            {
                                lastLetterCheck = true;
                            }
                            break;

                        default:
                            lastLetterCheck = false;
                            break;
                    }

                    if (lastLetterCheck == true)
                    {
                        validation = true;
                    }

                    else
                    {
                        do
                        {
                            Console.WriteLine("I'm sorry, but that number seems to be invalid.\n");
                            Console.Write("Type in your matriculation number please:");
                            input = Console.ReadLine();
                            matri = input.ToUpper();

                            if ((matri.Length != 7) || (matri.Substring(0, 1) != "A"))
                            {
                                Console.WriteLine("I'm sorry, but that number seems to be invalid.\n");
                                Thread.Sleep(timing1);
                            }

                        }
                        while ((input.Length != 7) || (matri.Substring(0, 1) != "A") || (isNumeric = false));
                    }
                }
            }
            while (lastLetterCheck == false);

            if (validation == true)
            {
                Console.WriteLine("Matriculation number is valid. Welcome!");
            }
        }
    }
}
