using System;

class Program
{
    static void Main()
    {
        // Create an integer array
        int[] numbers = { 7, 2, 9, 4, 5 };

        // Sort the array in ascending order
        Array.Sort(numbers);

        // Reverse the sorted array
        Array.Reverse(numbers);

        // Print each element using for loop
        Console.WriteLine("Array elements:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        
        using System;

class Program
{
    static void Main()
    {
        // Create an integer array
        int[] numbers = { 7, 2, 9, 4, 5 };

        // Sort the array in ascending order
        Array.Sort(numbers);

        // Reverse the sorted array
        Array.Reverse(numbers);

        // Print each element using for loop
        Console.WriteLine("Array elements:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Find the position of number 5
        int position = Array.IndexOf(numbers, 5);

        Console.WriteLine("Position of 5: " + position);
    }
} 
        // Find the position of number 5
        int position = Array.IndexOf(numbers, 5);

        Console.WriteLine("Position of 5: " + position);
    }
}