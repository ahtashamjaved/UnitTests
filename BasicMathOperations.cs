using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class BasicMathOperations
    {
        // Add the numbers
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Subtract the numbers
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        // Multiply the numbers
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // Divide the numbers
        public float Divide(int num1, int num2)
        {
            return (float)num1 / num2;
        }
    }
}
