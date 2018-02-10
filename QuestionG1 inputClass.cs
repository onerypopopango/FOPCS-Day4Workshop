using System;
using System.Threading;

namespace Day3Workshop
{
    class inputClass
    {
        public static int[] InputValue()
        {
            int[] sales = new int[12];
            int n;
            string input;
            bool isNum = true;

            do
            {
                Console.Write("Sales for January: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[0] = Int32.Parse(input); 
                }
            }
            while (isNum== false);

            do
            {
                Console.Write("Sales for February: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[1] = Int32.Parse(input);
                }
            }
            while (isNum == false);

            do
            {
                Console.Write("Sales for March: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[2] = Int32.Parse(input);
                }
            }
            while (isNum == false);

            do
            {
                Console.Write("Sales for April: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[3] = Int32.Parse(input);
                }
            }
            while (isNum == false);

            do
            {
                Console.Write("Sales for May: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[4] = Int32.Parse(input);
                }
            }
            while (isNum == false);

            do
            {
                Console.Write("Sales for June: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[5] = Int32.Parse(input);
                }
            }
            while (isNum == false);

            do
            {
                Console.Write("Sales for July: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[6] = Int32.Parse(input);
                }
            }
            while (isNum == false);

            do
            {
                Console.Write("Sales for August: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[7] = Int32.Parse(input);
                }
            }
            while (isNum == false);

            do
            {
                Console.Write("Sales for September: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[8] = Int32.Parse(input);
                }
            }
            while (isNum == false);

            do
            {
                Console.Write("Sales for October: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[9] = Int32.Parse(input);
                }
            }
            while (isNum == false);

            do
            {
                Console.Write("Sales for November: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[10] = Int32.Parse(input);
                }
            }
            while (isNum == false);

            do
            {
                Console.Write("Sales for December: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out n);

                if (isNum == false)
                {
                    Console.WriteLine("Invalid input detected. Please try again.");
                }

                else
                {
                    sales[11] = Int32.Parse(input);
                }
            }
            while (isNum == false);

            return sales;
        }
    }
}
