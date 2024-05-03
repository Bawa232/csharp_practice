using System;

class Program
{
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    static void Main()
    {
        Console.WriteLine("What day is your exam?");
        string input = Console.ReadLine();

        // Convert the input string to the corresponding enum value
        DaysOfWeek day;
        if (Enum.TryParse(input, out day))
        {
            // Use the enum value in the switch statement
            switch (day)
            {
                case DaysOfWeek.Sunday:
                    Console.WriteLine("Not possible. Sunday is the weekend.");
                    break;
                case DaysOfWeek.Monday:
                    Console.WriteLine("It's Monday! Best of luck!");
                    break;
                case DaysOfWeek.Tuesday:
                    Console.WriteLine("Oh Tuesday. Wish you the best.");
                    break;
                case DaysOfWeek.Wednesday:
                    Console.WriteLine("Oh Wednesday. Wish you the best.");
                    break;
                case DaysOfWeek.Thursday:
                    Console.WriteLine("Oh Thursday. Wish you the best.");
                    break;
                case DaysOfWeek.Friday:
                    Console.WriteLine("Oh Friday. Wish you the best.");
                    break;
                case DaysOfWeek.Saturday:
                    Console.WriteLine("Oh Saturday. Wish you the best.");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
