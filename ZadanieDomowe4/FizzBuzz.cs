using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe4
{
    class FizzBuzz
    {
        public int GetNumber()
        {    
            while (true)
            {
                var val = Console.ReadLine();
                if (val.ToUpper() == "T")
                    Environment.Exit(0); 
                
                if (!int.TryParse(val, out int number))
                {
                    Console.WriteLine("Wprowadziłeś złe dane. Wprowadź liczbę:");
                    continue;
                }
                return number;
            }
        }

        public string IsFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";
           
            return number.ToString();
        }
    }
}
