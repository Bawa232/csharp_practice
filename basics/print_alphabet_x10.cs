// Program that prints alphabet 10 times

using System;

class Program 
{
	static void Main()
	{
		print_alphabet_x10();
	}
	public static void print_alphabet_x10()
	{
		for(int i = 0; i < 10; i++)
		{
			for(var a = 'a'; a <= 'z'; a++)
			{
				Console.Write(a);
			}
			Console.WriteLine();
		}

	}

}
