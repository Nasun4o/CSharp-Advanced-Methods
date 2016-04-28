namespace NumberCalculation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Chose 1 for DOUBLE and 2 for DECIMAL ");
            int type = int.Parse(Console.ReadLine());

            List<double> doubleNum = new List<double>();
            List<decimal> decimalNum = new List<decimal>();

            Console.WriteLine("Chose Your Function.\n1 -> Find Max Number.\n2 -> Find Min number.\n3 -> Find Average.\n4 -> Find Sum.\n5 -> Product of numbers.");
           
            int command = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                Console.WriteLine("Please Select your numbers and split them by ' ', ',' or '.' ");
                doubleNum = Console.ReadLine().Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

                //command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1: DoubleMax(doubleNum); break;
                    case 2: DoubleMin(doubleNum); break;
                    case 3: DoubleAverage(doubleNum); break;
                    case 4: DoubleSum(doubleNum); break;
                    case 5: DoubleProduct(doubleNum); break;
                }
            }

            else
            {
                Console.WriteLine("Please Select your numbers and split them by ' ', ',' or '.' ");
                decimalNum = Console.ReadLine().Split(new [] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
                switch (command)
                {
                    case 1: DecimalMax(decimalNum); break;
                    case 2: DecimalMin(decimalNum); break;
                    case 3: DecimalAverage(decimalNum); break;
                    case 4: DecimalSum(decimalNum); break;
                    case 5: DecimalProduct(decimalNum); break;
                }
            }
        }

        public static void DoubleMax(List<double> result)
        {
            Console.WriteLine($"Max number: {result.Max()}");
        }

        public static void DoubleMin(List<double> result)
        {
            Console.WriteLine($"Min number: {result.Min()}");
        }

        public static void DoubleAverage(List<double> result)
        {
            Console.WriteLine($"Average number: {result.Average()}");
        }

        public static void DoubleSum(List<double> result)
        {
            Console.WriteLine($"Sum number: {result.Sum()}");
        }

        public static void DoubleProduct(List<double> result)
        {
            double product = result.Aggregate<double, double>(1, (current, num) => current * num);
            Console.WriteLine($"Product: {product}");
        }

        public static void DecimalMax(List<decimal> result)
        {
            Console.WriteLine($"Max number: {result.Max()}");
        }

        public static void DecimalMin(List<decimal> result)
        {
            Console.WriteLine($"Min number: {result.Min()}");
        }

        public static void DecimalAverage(List<decimal> result)
        {
            Console.WriteLine($"Average number: {result.Average()}");
        }

        public static void DecimalSum(List<decimal> result)
        {
            Console.WriteLine($"Sum number: {result.Sum()}");
        }

        public static void DecimalProduct(List<decimal> result)
        {
            decimal product = result.Aggregate<decimal, decimal>(1, (current, num) => current * num);
            Console.WriteLine($"Product: {product}");
        }

    }
}
