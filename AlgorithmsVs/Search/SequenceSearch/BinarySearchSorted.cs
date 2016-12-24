using System;
namespace AlgorithmsVs
{

	public class BinarySearchSorted {
		public int Evaluate(int[] numbers, int numToFind)
		{
			return EvaluateImpl(numbers, numToFind, 0, numbers.Length-1);
		}

		private int EvaluateImpl(int[] numbers, int numToFind, int start, int end) {
			if (start > end) {
				return -1;
			}

			var middle = (int)Math.Floor((double)(start + end) /2);
			var val = numbers[middle];
			if (val > numToFind) return EvaluateImpl(numbers, numToFind, start, middle-1);
			if (val < numToFind) return EvaluateImpl(numbers, numToFind, middle + 1, end);
			return middle;
		}
	}
}
