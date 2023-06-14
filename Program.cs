

using System;
using System.ComponentModel.Design;

namespace SimpleCal
{
    class Program
    {

        static long add_function()
        {
            Console.WriteLine("Enter the first digit :");
            long firstDigit = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Numbers adding: {0} + ", firstDigit);
            Console.WriteLine("Enter the second digit :");
            long secondDigit = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Numbers adding: {0} + {1} ", firstDigit, secondDigit);

            long answer = firstDigit + secondDigit;

            return answer;
        }

        static long sub_function()
        {
            Console.WriteLine("Enter the first digit :");
            long firstDigit = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Numbers adding: {0} - ", firstDigit);
            Console.WriteLine("Enter the second digit :");
            long secondDigit = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Numbers adding: {0} - {1} ", firstDigit, secondDigit);

            long answer = firstDigit - secondDigit;

            return answer;
        }

        static long mul_function()
        {
            Console.WriteLine("Enter the first digit :");
            long firstDigit = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Numbers adding: {0} *  ", firstDigit);
            Console.WriteLine("Enter the second digit :");
            long secondDigit = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Numbers adding: {0} * {1} ", firstDigit, secondDigit);

            long answer = firstDigit * secondDigit;

            return answer;
        }

        static long div_function()
        {
            Console.WriteLine("Enter the first digit :");
            long firstDigit = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Numbers adding: {0} /  ", firstDigit);
            Console.WriteLine("Enter the second digit :");
            long secondDigit = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Numbers adding: {0} / {1} ", firstDigit, secondDigit);

            long answer = firstDigit / secondDigit;

            return answer;
        }




        static int selection()
        {
            Console.WriteLine("--- Main menu ---");
            Console.WriteLine();
            Console.WriteLine(" 1 - Add");
            Console.WriteLine(" 2 - Subtract");
            Console.WriteLine(" 3 - Multiply");
            Console.WriteLine(" 4 - Divide");
            Console.WriteLine("Please enter your choice (1-4) :");
            int choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int x = selection();
                if (x == 1)
                {
                    long answer = add_function();
                    Console.WriteLine("Answer: {0}", answer);
                }
                else if (x == 2)
                {
                    long answer = sub_function();
                    Console.WriteLine("Answer: {0}", answer);
                }
                else if (x == 3)
                {
                    long answer = mul_function();
                    Console.WriteLine("Answer: {0}", answer);
                }
                else if (x == 4)
                {
                    long answer = div_function();
                    Console.WriteLine("Answer: {0}", answer);
                }
                else
                {
                    Console.WriteLine("ERROR: invalid choice entered");
                }
            }
        }
    }
}
