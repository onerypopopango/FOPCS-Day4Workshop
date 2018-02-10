using System;
using System.Threading;

namespace Day3Workshop
{
    class G1
    {
        static void Main(string[] args)
        {
            int timer1 = 1000;
            int timer2 = 2000;
            int temp, a, b;
            double avg, sum = 0;
            int[] salesValue = new int[12];
            int[] salesCompare = new int[12];
            int[] month = new int[12] {1,2,3,4,5,6,7,8,9,10,11,12};
            int[] monthCompare = new int[12];
            string option, enter;
            bool exit = false;

            Console.WriteLine("Welcome to Company X.");
            Thread.Sleep(timer1);
            Console.WriteLine("Please enter the sales amounts for the past year.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            Thread.Sleep(timer1);

            salesValue = inputClass.InputValue();

            Console.Write("\nData inputed. One moment...");
            Console.WriteLine();
            Thread.Sleep(timer2);

            do
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("|\t\t\tMenu\t\t\t|");
                Console.WriteLine("-----------------------------------------------\n");

                Console.WriteLine("1. Month of Maximum Sales");
                Console.WriteLine("2. Month of Minimum Sales");
                Console.WriteLine("3. Find Average Monthly Sales");
                Console.WriteLine("4. Exit");

                Console.Write("\nOption: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Thread.Sleep(timer1);
                        salesCompare = salesValue;
                        monthCompare = month;
                        for (a = 0; a < salesCompare.Length; a++)
                        {
                            for (b = a + 1; b < salesCompare.Length; b++)
                            {
                                if (salesCompare[a] > salesCompare[b])
                                {
                                    temp = salesCompare[a];
                                    salesCompare[a] = salesCompare[b];
                                    salesCompare[b] = temp;
                                    temp = 0;

                                    temp = monthCompare[a];
                                    monthCompare[a] = monthCompare[b];
                                    monthCompare[b] = temp;
                                    temp = 0;
                                }
                            }
                        }
                        Console.WriteLine("\nThe {0} month has the maximum sales of {1}.", monthCompare[11], salesCompare[11]);
                        Console.Write("Press enter to continue");
                        enter = Console.ReadLine();
                        Console.WriteLine();
                        break;

                    case "2":
                        Thread.Sleep(timer1);
                        salesCompare = salesValue;
                        monthCompare = month;
                        for (a = 0; a < salesCompare.Length; a++)
                        {
                            for (b = a + 1; b < salesCompare.Length; b++)
                            {
                                if (salesCompare[a] < salesCompare[b])
                                {
                                    temp = salesCompare[a];
                                    salesCompare[a] = salesCompare[b];
                                    salesCompare[b] = temp;
                                    temp = 0;

                                    temp = monthCompare[a];
                                    monthCompare[a] = monthCompare[b];
                                    monthCompare[b] = temp;
                                    temp = 0;
                                }
                            }
                        }
                        Console.WriteLine("\nThe {0} month has the minimum sales of {1}.", monthCompare[11], salesCompare[11]);
                        Console.Write("Press enter to continue");
                        enter = Console.ReadLine();
                        Console.WriteLine();
                        break;

                    case "3":
                        Thread.Sleep(timer1);
                        for (a = 0; a < salesValue.Length; a++)
                        {
                            sum = sum + salesValue[a];
                        }
                        avg = (sum / 12);
                        Console.WriteLine("\nThe average monthly sales is {0:#.##}.", avg);
                        Console.Write("Press enter to continue");
                        enter = Console.ReadLine();
                        sum = 0;
                        Console.WriteLine();
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("\nThank you for using our services. Good day!");
                        break;

                    default:
                        Thread.Sleep(timer1);
                        Console.WriteLine("\nI'm sorry, I don't recognise that input. Bringing you back to main menu...\n");
                        Thread.Sleep(timer2);
                        break;
                }
            }
            while (exit == false);

        }
    }
}
