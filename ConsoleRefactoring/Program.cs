using System;

namespace console_refactoring
{
    class Program
    {
        private static string userInput;
        private static int userNumber;
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Вас приветствует математическая программа.");
            Console.WriteLine("Пожалуйста введите число. Для выхода из программы введите q ");

            userInput = Console.ReadLine();

            if (userInput == "q") return;

            try
            {
                userNumber = int.Parse(userInput);
            }
            catch
            {
                throw new Exception("Input is not correct");
            }

            Console.WriteLine($"Факториал числа {userInput} равен {MathLib.ResearchFactorial(userNumber)}"); 
            Console.WriteLine($"Сумма чисел от 1 до N равна {MathLib.SummNumbers(userNumber)}");
            Console.WriteLine($"Максимальное четное число меньше N равно {MathLib.ResearchEvenLowerNumber(userNumber)}");
            Console.ReadLine();
        }

    }
}
