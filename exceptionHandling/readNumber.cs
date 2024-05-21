using System;
//a method that reads an integer from the console in the range [start…end]


class Program
{
	static int ReadNumber(int start, int end)
	{
		int number = int.Parse(Console.ReadLine());

		try
		{
			if(number < start || number > end)
			{
				throw new ArgumentOutOfRangeException("Number not in range");
			}
			return number;
		}
		catch(FormatException)
		{
			Console.WriteLine("Invalid input must be a number");
		}
	}

	static void Main()
	{
		Console.WriteLine(ReadNumber(10, 80));
	}
}
