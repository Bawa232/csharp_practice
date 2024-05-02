//program that prints alphabets in lowercase then in uppercase
using System;

class Program
{	static void Main()
	{
		char lCase = 'a';                                 char uCase = 'A';

		while(lCase <= 'z')                               {
        		Console.WriteLine(lCase);
        		lCase++;
		}

		while(uCase <= 'Z')
		{
        		Console.WriteLine(uCase);
	        	uCase++;
		}
	}
}
