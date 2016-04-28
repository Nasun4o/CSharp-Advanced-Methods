namespace ReverseNumber
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double reversed = ReversedInput(input);
            Console.WriteLine(reversed);
        }

        public static double ReversedInput(string input)
        {
            string output = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            double reversed = double.Parse(output);

            return reversed;
        }

    }
}
