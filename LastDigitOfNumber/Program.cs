namespace LastDigitOfNumber
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine(ReturnDigitAsString(20));
            Console.WriteLine(ReturnDigitAsString(21));
            Console.WriteLine(ReturnDigitAsString(22));
            Console.WriteLine(ReturnDigitAsString(23));
            Console.WriteLine(ReturnDigitAsString(24));
            Console.WriteLine(ReturnDigitAsString(25));
            Console.WriteLine(ReturnDigitAsString(26));
            Console.WriteLine(ReturnDigitAsString(27));
            Console.WriteLine(ReturnDigitAsString(28));
            Console.WriteLine(ReturnDigitAsString(29));
        }

        public static string ReturnDigitAsString(int number)
        {
            switch (number % 10)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "fife";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
            }

            return String.Empty;
        }
    }
}
