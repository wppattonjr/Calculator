using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables and set them to 0
            int number1 = 0; int number2 = 0; int number3 = 0;

            //Ask user for the initial number
            Console.WriteLine("Please type a number and then press Enter");
            number1 = Convert.ToInt32(Console.ReadLine());

            //Ask user for second number
            Console.WriteLine("Please type another number and then press Enter");
            number2 = Convert.ToInt32(Console.ReadLine());

            //Ask user for third number
            Console.WriteLine("Please type a third number and then press Enter");
            number3 = Convert.ToInt32(Console.ReadLine());


            //Ask user to choose their oporator
            Console.WriteLine("Please chose an operator from the following list:");
            Console.WriteLine("* - Multiply");
            Console.WriteLine("^ - Square");
            Console.WriteLine("+ - Add");
            Console.WriteLine("avg - Average");
            Console.Write("You selected: ");

            //Using switch case to do the math.
            switch (Console.ReadLine())
            {
                case "*":
                    Console.WriteLine($"Here is your result: {number1} * {number2} * {number3} = " + (number1 * number2 * number3));
                    break;
                case "^":
                    Console.WriteLine($"Here is your result: {number1}, {number2}, {number3} = " + ((number1 * number1), (number2 * number2), (number3 * number3)));
                    break;
                case "+":
                    Console.WriteLine($"Here is your result: {number1} + {number2} + {number3} = " + (number1 + number2 + number3));
                    break;
                case "avg":
                    Console.WriteLine($"Here is your result: ({number1} + {number2} + {number3})/3 = " + (number1 + number2 + number3) / 3);
                    break;

            }

        }
    }
}