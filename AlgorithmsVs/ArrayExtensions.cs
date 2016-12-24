using System;
namespace AlgorithmsVs
{
	public static class ArrayExtensions
	{
		public static void Swap(this int[] numbers, int xIndex, int yIndex) { 
			int temp = numbers[xIndex];
			numbers[xIndex] = numbers[yIndex];
			numbers[yIndex] = temp;
		}
	}
}