using System;

class Program
{
    static void Main()
    {
        // Create birthdate
        DateTime birthDate = new DateTime(2005, 5, 15);

        // Get current date and time
        DateTime currentDate = DateTime.Now;

        // Calculate difference
        TimeSpan difference = currentDate - birthDate;

        // Calculate age in years
        int age = (int)(difference.TotalDays / 365.25);

        // Print birthdate
        Console.WriteLine("Birthdate: " + birthDate);

        // Print current date and time
        Console.WriteLine("Current Date and Time: " + currentDate);

        // Print age
        Console.WriteLine("Age: " + age + " years");

        // Add 10 days to birthdate
        DateTime newDate = birthDate.AddDays(10);

        // Print new date
        Console.WriteLine("Birthdate after 10 days: " + newDate);
    }
}