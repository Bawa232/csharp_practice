// function to print a string in reverse


using System;

class Program
{
	public static void rev(string str)
	{
		int i = str.Length - 1;
		for(; i >= 0; i--)
		{
			Console.Write(str[i]);
		}
	}

	static void Main()
	{
		rev("i am tired");
	}
}
