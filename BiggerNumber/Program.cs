namespace BiggerNumber
{
    using System;

    class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = BiggerNumber(firstNumber, secondNumber);
            Console.WriteLine($"Max number is {max}");
        }

        public static int BiggerNumber(int firstNum, int secondNum)
        {
            int maxNumb = Math.Max(firstNum, secondNum);
            return maxNumb;
        }
    }
}
