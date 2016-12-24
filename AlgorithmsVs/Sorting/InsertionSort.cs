using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsVs
{
	public class InsertionSort {
		//https://www.youtube.com/watch?v=DFG-XuyPYUQ
		//have two arrays one sorted and one unsorted
		//initially everything is unsorted and pick each element and place correctly in sorted portion
		//we can consider initial array to be unsorted

		public int[] Evaluate(int[] numbers) {
			var unsortedArray = numbers;
			var sortedArray = new int[] { };

			foreach (var num in numbers)
			{
				int placeHolder = -1;
				var nr = new int[sortedArray.Length + 1];

				for (int i = sortedArray.Length - 1; i >= 0; i--)
				{
					if (num >= sortedArray[i])
					{
						placeHolder = i;
						break;
					}
					else
					{
						nr[i + 1] = sortedArray[i];
					}
				}

				Array.Copy(sortedArray, 0, nr, 0, placeHolder + 1);
				nr[placeHolder + 1] = num;
				sortedArray = nr;
			}

			return sortedArray;
		}
	}
}