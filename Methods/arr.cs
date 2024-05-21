using System;
// a method that finds how many times certain number can be
// found in a given array


class Program
{
	static int numOccurrence(int[] arr, int num)
	{
		int i = 0;
		int occ = 0;

		for(; i < arr.Length; i++)
		{
			if(arr[i] == num)
			{
				occ += 1;
			}
		}
		return occ;
	}

	static void Main()
	{
		Console.WriteLine(numOccurrence(new int[]{3,2,2,5,1,-8,7,2}, 2));
	}
}

