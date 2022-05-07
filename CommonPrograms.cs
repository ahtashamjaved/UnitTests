using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class CommonPrograms
    {
        public bool IsPrime(int number)
        {
            bool result = true; // return value

            // first condition that number should  positive
            if(number >= 0)
            {
                for(int i = 2; i <= number / 2; i++)
                {
                    if(number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            } 
            else
            {
                result = false; // if not positive number
            }

            return result;
        }

        public bool IsEvenNumber(int number)
        {
            bool result = true;

            if(number % 2 != 0)
            {
                result = false;
            }
            return result;
        }

        public bool IsOddNumber(int number)
        {
            bool result = true;

            if (number % 2 == 0)
            {
                result = false;
            }
            return result;
        }

        public int Smallest(int[] array)
        {
            int smallest = array[0];
            // logic to find smallest number in an array
            for(int index = 0; index < array.Length; index++)
            {
                if (array[index] < smallest)
                    smallest = array[index];
            }
            return smallest;
        }
    }
}
