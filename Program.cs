using System;

namespace ToRoman
{
    class Program
    {


       /*given a postive int between 1-100 - return string that contains the roman numeral representation
       example:
       intput: int 50
       output: L
       
       
       Process:     
       Random number generator between 1-100
       Validate input - if statement - if number is not in range 1-100, throw exception  */


        public static string ToRoman(int value)
        {
            string[] romanNumeral = { "M", "DM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV" };
            int[] numeralValue = { 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            if (value < 1 || value > 100)
            {
                throw new InvalidOperationException();
            }


            string returnString = "";
            int i = 0;

            while (value > 0)
            {

                if (value >= numeralValue[i])
                {
                    returnString += romanNumeral[i];
                    value -= numeralValue[i];
                }
              else i++;
            }

            return returnString;

        }
        static void Main(string[] args)
        {
            Console.WriteLine($"{ToRoman(50)}");
        }
    }
}
