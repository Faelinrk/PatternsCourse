using System;
using System.Collections.Generic;
using System.Text;

namespace console_refactoring
{
    public class MathLib
    {
        public static int ResearchFactorial(int number)
        {
            if (number == 1)
                return number;
            return ResearchFactorial(number - 1) * number;
        }
        public static int SummNumbers(int number)
        {
            if (number == 1)
                return number;
            return SummNumbers(number - 1) + number;
        }
        public static int ResearchEvenLowerNumber(int number)
        {
            if ((number - 1) % 2 == 0)
                return number - 1;
            return ResearchEvenLowerNumber(number - 1);
        }
    }
}
