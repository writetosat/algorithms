using System;
namespace AlgorithmsVs
{
	public class LinearSearchOnUnsorted
	{
		public int Evaluate(int[] numbers, int numToFind) {
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] == numToFind) {
					return i;
				}
			}

			return -1;
		}
	}
}