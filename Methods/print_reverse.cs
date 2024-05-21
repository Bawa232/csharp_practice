using System;
// method that prints digits in reverse


class Program
{
	static int print_reverse(int num)
	{
		string strNum = num.ToString();
		int i = strNum.Length - 1;
		string rev = "";

		for(; i >= 0; i--)
		{
			rev += strNum[i];
		}

		return int.Parse(rev);
	}

	static void Main()
	{
		Console.WriteLine(print_reverse(234));
	}
}

