using System;

namespace HelloWorldProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator program");
            Console.WriteLine("Enter first Number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Calculator calculator = new Calculator();

            double result = calculator.Addition(firstNumber, secondNumber);
            Console.WriteLine("Add: " + result);
            //double resultSub = calculator.Substration(firstNumber, secondNumber);
            //Console.WriteLine("Sub: " + resultSub);
            //double resultMul = calculator.Multipilcation(firstNumber, secondNumber);
            //Console.WriteLine("Mul: " + resultMul);
            //double resultDiv = calculator.Division(firstNumber, secondNumber);
            //Console.WriteLine("Div: " + resultDiv);

        }

    }
}
