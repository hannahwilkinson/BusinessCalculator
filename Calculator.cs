using System;
namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Business Calculator");
            Console.WriteLine();
        }

        public void DisplayCalculations()
        {
            Console.WriteLine("Please enter your sales followed by your sales price");
            Console.WriteLine("Sales:");
            int Sales = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sales Price:");
            int SalesPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expenses: ");
            int Expenses = Convert.ToInt32(Console.ReadLine());

            //Revenue Calculation
            int Revenue = Sales * SalesPrice;

            //NetIncome Calculation
            int NetIncome = Revenue - Expenses;

            Console.WriteLine();
            Console.WriteLine($"Revenue: {Revenue:c}");
            Console.WriteLine($"NetIncome: {NetIncome:c}");
            Console.WriteLine($"Expenses: {Expenses:c}");
        }
    }
}
