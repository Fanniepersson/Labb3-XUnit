using System;
using System.Collections.Generic;
using System.Text;

namespace My_Calculator
{
    public class CalculatorMeny : Calculate
    {
        public void ChoiceMenu()
        {
            bool startOver = false;
            while (startOver == false)
            {
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Divided");
                Console.WriteLine("5.View calculate history");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: Addition(Input1, Input2);
                        break;

                    case 2:
                        Subtraction();
                        break;

                    case 3:
                        Multiplication();
                        break;

                    case 4:
                        Division();
                        break;

                    case 5:
                        ViewCalculateHistory();
                        break;

                    default:
                        Console.WriteLine("Invalid input, try again");
                        break;

                }
            }
        }

        public void ViewCalculateHistory()
        {
            for (int i = 0; i < HistoryAddition.Count; i++)
            {
                Console.WriteLine($" Calculation: {HistoryAddition[i].Input1} + {HistoryAddition[i].Input2}");
                Console.WriteLine($" Result: {HistoryAddition[i].Result}");
            }

            for (int i = 0; i < HistorySubtraction.Count; i++)
            {
                Console.WriteLine($" Calculation: {HistorySubtraction[i].Input1} - {HistorySubtraction[i].Input2}");
                Console.WriteLine($" Result: {HistorySubtraction[i].Result}");
            }

            for (int i = 0; i < HistoryMultiplication.Count; i++)
            {
                Console.WriteLine($" Calculation: {HistoryMultiplication[i].Input1} * {HistoryMultiplication[i].Input2}");
                Console.WriteLine($" Result: {HistoryMultiplication[i].Result}");
            }

            for (int i = 0; i < HistoryDivison.Count; i++)
            {
                Console.WriteLine($" Calculation: {HistoryDivison[i].Input1} / {HistoryDivison[i].Input2}");
                Console.WriteLine($" Result: {HistoryDivison[i].Result}");
            }
            Console.WriteLine();
        }
    }
}
