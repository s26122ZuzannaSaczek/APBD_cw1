// See https://aka.ms/new-console-template for more information

namespace Cwiczenia1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Średnia: " + CalculateAverage(numbers));
            Console.WriteLine("Maksymalna: " + FindMax(numbers));
        }

        public static double CalculateAverage(int[] numbers)
        {
            double numSum = 0;
            foreach (var number in numbers)
            {
                numSum += number; // Zmieniono nazwę zmiennej na `sum`
            }
            return numSum / numbers.Length;
        }
        
        public static int FindMax(int[] numbers)
        {
            return numbers.Max();
        }

    }
}

