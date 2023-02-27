


using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare an array of numbers
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Calculate the sum of the numbers
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        // Calculate the arithmetic mean (average) of the numbers
        double mean = (double)sum / numbers.Length;

        // Print the result to the console
        Console.WriteLine("Arithmetic mean: " + mean);
    }
}

