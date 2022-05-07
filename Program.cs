using System;

namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonPrograms commonPrograms = new CommonPrograms();
            BasicMathOperations basicMathOperations = new BasicMathOperations();

            Console.Write("Please Enter first number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter Second number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = basicMathOperations.Add(number1, number2);
            int multiply = basicMathOperations.Multiply(number1, number2);
            float divide = basicMathOperations.Divide(number1, number2);
            int subtract = basicMathOperations.Sub(number1, number2);

            bool isPrimeNum1 = commonPrograms.IsPrime(number1);
            bool isPrimeNum2 = commonPrograms.IsPrime(number2);

            Console.WriteLine("");

            Console.WriteLine($"Sum of {number1} and {number2} is : {sum}");
            Console.WriteLine($"Differece of {number1} and {number2} is : {subtract}");
            Console.WriteLine($"Multiplication of {number1} and {number2} is : {multiply}");
            Console.WriteLine($"Division of {number1} and {number2} is : {divide}");

            Console.WriteLine($"Is {number1} Prime : {isPrimeNum1}");
            Console.WriteLine($"Is {number2} Prime : {isPrimeNum2}");

        }
    }
}
