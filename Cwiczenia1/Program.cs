// See https://aka.ms/new-console-template for more information

namespace Cwiczenia1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Średnia: " + CalculateAverage(numbers));
            
        }

        public static double CalculateAverage(int[] numbers)
        {
            return numbers.Average();
        }
        
        public static int FindMax(int[] numbers)
        {
            return numbers.Max();
        }

    }
}

