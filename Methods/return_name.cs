using System;
//method that returns the english name
//of the last digit of a given number


class Program
{
	static string returnName(int digits)
	{
		int num = digits % 10;

		switch (num)
		{
			case 0:
				return "Zero";
			case 1:
				return "One";
			case 2:
				return "two";
			case 3:
				return "three";
			case 4:
				return "Four";
			case 5:
				return "Five";
			case 6:
				return "Six";
			case 7:
				return "Seven";
			case 8:
				return "Eight";
			case 9:
				return "Nine";
			default:
				return "Not a valid integer";
		}
	}

	static void Main()
	{
		int num = int.Parse(Console.ReadLine());

		Console.WriteLine("The last digit of the number is " + returnName(num));
	}
}
