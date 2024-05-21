using System;
// program that finds the square root of a given number


class Program
{
	static void Main()
	{
		Console.Write("Enter a positive integer: ");
		string input = Console.ReadLine();

		try
		{
			//parsing the input to an int because all inputs
			//from the console are strings
			int num = int.Parse(input);

			if(num < 0)
			{
				Console.WriteLine("Number must be positive");
			}
			else
			{
				double sqrtnum = Math.Sqrt(num);
				Console.WriteLine("the square root of {0} is {1}: ", num, sqrtnum);
			}
		}
		catch(FormatException)
		{
			Console.WriteLine("Invalid Number");
		}
		catch(OverflowException)
		{
			Console.WriteLine("Invalid Number");
		}
		finally
		{
			Console.WriteLine("Good Bye");
		}
	}
}
