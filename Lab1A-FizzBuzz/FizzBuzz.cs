using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_FizzBuzz
{
    public static class FizzBuzz
    {
        public static string CaluclateFizzBuzz(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";                
            }
            else if (number % 3 == 0)
            {
                return "Fizz";               
            }
            else if (number % 5 == 0)
            {
                return "Buzz";              
            }
            else
            {
                return number.ToString();                
            }            
        }
    }
}
