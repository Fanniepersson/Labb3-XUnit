using System;
using System.Collections.Generic;
using System.Text;

namespace My_Calculator
{
    public class Calculate
    {
        public List<Calculate> HistoryAddition = new List<Calculate>();
        public List<Calculate> HistorySubtraction = new List<Calculate>();
        public List<Calculate> HistoryMultiplication = new List<Calculate>();
        public List<Calculate> HistoryDivison = new List<Calculate>();

        public decimal Input1 { get; set; }
        public decimal Input2 { get; set; }
        public decimal Result { get; set; }

        public Calculate()
        {

        }

        public Calculate(decimal Input1, decimal Input2, decimal Result)
        {
            this.Input1 = Input1;
            this.Input2 = Input2;
            this.Result = Result;
        }

        public void Subtraction()
        {
            //UserInputs();
            Result = Input1 - Input2;

            HistorySubtraction.Add(new Calculate(Input1, Input2, Result));
            //ReturnResult();
        }

        public void Multiplication()
        {
        //    UserInputs();
            Result = Input1 * Input2;

            HistoryMultiplication.Add(new Calculate(Input1, Input2, Result));
            //ReturnResult();
        }

        public void Division()
        {
            //UserInputs();
            Result = Input1 / Input2;

            HistoryDivison.Add(new Calculate(Input1, Input2, Result));
            //ReturnResult();
        }
        public void Addition(decimal Input1, decimal Input2)
        {
            //Console.WriteLine("Enter the first number");
            //Input1 = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Enter the second number");
            //Input2 = Convert.ToDecimal(Console.ReadLine());

            Result = Input1 + Input2;

            HistoryAddition.Add(new Calculate(Input1, Input2, Result));
            //ReturnResult();
        }

        public void UserInputs()
        {
            Console.WriteLine("Enter the first number");
            Input1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            Input2 = Convert.ToDecimal(Console.ReadLine());
        }

        public void ReturnResult()
        {
            Console.WriteLine(Result);
            Console.ReadKey();
        }


    }
}
