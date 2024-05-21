using System;

namespace Checking
{
	public class Arrays
	{
		public static bool GreaterThanNeighbor(int[] arr, int position)
		{
			if(arr.Length == 1)
			{
				return true;
			}

			if(position == arr.Length - 1)
			{
				return arr[position] > arr[position - 1];
			}

			if(arr.Length == 2 && position == 0)
			{
				return arr[0] > arr[1];
			}

			else if(arr.Length == 2 && position == 1)
			{
				return arr[1] > arr[0];
			}

			return arr[position] > arr[position + 1] && arr[position] > arr[position - 1];
		}
	}

	class Program
	{
		static void Main()
		{
			int[] arr1 = { 1, 3, 2 };
            		int[] arr2 = { 1 };
			Console.WriteLine(Arrays.GreaterThanNeighbor(arr1, 1));
			Console.WriteLine(Arrays.GreaterThanNeighbor(arr2, 0));
		}
	}
}
