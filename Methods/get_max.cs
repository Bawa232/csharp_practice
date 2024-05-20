using System;
// A method that checks which integer is greater


class Program
{
	static int GetMax(int a, int b)
	{
		return (a > b)? a : b;
	}

	static void Main()
	{
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int num3 = int.Parse(Console.ReadLine());

		int max = GetMax(GetMax(num1, num2), num3);
		Console.WriteLine("the maximum number is " + max);
	}
}
