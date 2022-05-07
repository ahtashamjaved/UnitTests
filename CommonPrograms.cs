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
    }
}
