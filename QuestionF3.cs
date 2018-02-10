using System;
using System.Threading;

namespace Day3Workshop
{
    class F3
    {
        static void Main(string[] args)
        {
            //int timing1 = 1000;         //for thread.sleep

            Console.WriteLine("Write down a word or sentence: ");
            string Str = Console.ReadLine();                //takes input and converts all into lower case
            string z, Z = "";

            for (int j = 0; j < Str.Length; j++)
            {
                z = Str.Substring(j, 1);

                switch (z)
                {
                    case " ":
                        Str.Trim();
                        break;

                    case ".":
                        Str.Trim('.');
                        break;

                    case ",":
                        Str.Trim('.');
                        break;

                    case "'":
                        Str.Trim('\'');
                        break;

                    case "?":
                        Str.Trim('?');
                        break;

                    case "!":
                        Str.Trim('!');
                        break;

                    case "-":
                        Str.Trim('-');
                        break;

                    case "\"":
                        Str.Trim('\"');
                        break;

                    case ";":
                        Str.Trim(';');
                        break;

                    case ":":
                        Str.Trim(':');
                        break;

                    case "&":
                        Str.Trim('&');
                        break;

                    default:
                        Z = Z + z;
                        break;
                }
            }

            string input = Z.ToLower();
            bool palindrome = false;

            string r, t, R = "", T = "";                    //R and T are new strings to be made for comparison

            if (input.Length % 2 == 0)
            {
                for (int i = 0; i < (input.Length / 2); i++)
                {
                    r = input.Substring(i, 1);
                    R = R + r;
                }

                for (int j = (input.Length - 1); j >= (input.Length / 2); j--)
                {
                    t = input.Substring(j, 1);
                    T = T + t;
                }

                if (R == T)
                {
                    palindrome = true;
                }

                else
                {
                    palindrome = false;
                }
            }

            else
            {
                for (int i = 0; i < (input.Length / 2); i++)
                {
                    r = input.Substring(i, 1);
                    R = R + r;
                }

                for (int j = (input.Length - 1); j > (input.Length / 2); j--)
                {
                    t = input.Substring(j, 1);
                    T = T + t;
                }

                if (R == T)
                {
                    palindrome = true;
                }

                else
                {
                    palindrome = false;
                }
            }

            if (palindrome == true)
            {
                Console.WriteLine("\"{0}\" is a palindrome!", Str);
            }

            else
            {
                Console.WriteLine("\"{0}\" isn't a palindrome...", Str);
            }
        }
    }
}
