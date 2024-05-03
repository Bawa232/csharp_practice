//a function that prints n elements of an array of integers


using System;

class Program
{
	public static void print_array(int[] a, int n)
	{
		for(int i = 0; i < n; i++)
		{
			Console.WriteLine(a[i]);
		}
	}

	static void Main()
	{
		int[] arr = {23, 44, 7, 3, 7, 87, 76, 90, 100, 535}; 
		print_array(arr, 3);
	}

}
