using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataFizzBuzz
{
    public class GameFizzBuzz
    {
        /// <summary>
        /// Denominador para Fizz.
        /// </summary>
        public const int DEN_FIZZ = 3;
        /// <summary>
        /// Denominador para Buzz.
        /// </summary>
        public const int DEN_BUZZ = 5;

        public const string FIZZ = "Fizz";
        public const string BUZZ = "Buzz";

        public static bool IsDivisible(int number, int denominator)
        {
            return (number % denominator == 0);
        }

        /// <summary>
        /// REQUISITO 1: Obtener si es divisible entre DEN_FIZZ y/o DEN_BUZZ.
        /// </summary>
        public static object GetValueFizzBuzz(int number)
        {
            object result;

            if ((IsDivisible(number, DEN_FIZZ)) && (IsDivisible(number, DEN_BUZZ)))
                result = FIZZ + BUZZ;
            else if (IsDivisible(number, DEN_BUZZ))
                result = BUZZ;
            else if (IsDivisible(number, DEN_FIZZ))
                result = FIZZ;
            else
                result = number;

            return result;
        }

        public static bool ContainsDenominator(int number, int denominator)
        {
            return number.ToString().Contains(denominator.ToString());
        }

        private static bool IsDivisibleAndContains(int number, int denominator)
        {
            return (IsDivisible(number, denominator)) || (ContainsDenominator(number, denominator));
        }

        public static object GetValueFizzBuzz2(int number)
        {
            object result;

            if ((IsDivisibleAndContains(number, DEN_FIZZ)) && (IsDivisibleAndContains(number, DEN_BUZZ)))
                result = FIZZ + BUZZ;
            else if (IsDivisibleAndContains(number, DEN_BUZZ))
                result = BUZZ;
            else if (IsDivisibleAndContains(number, DEN_FIZZ))
                result = FIZZ;
            else
                result = number;

            return result;
        }
    }
}