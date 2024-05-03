// function that prints the length of a string

using System;

class Program
{
	public static int _length(string str)
	{
		int i = 0;
		foreach(char c in str)
		{
			i++;
		}
		return i;
	}
}
