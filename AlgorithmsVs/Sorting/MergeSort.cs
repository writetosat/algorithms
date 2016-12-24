using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsVs
{
	public class MergeSort {
		//o(nlog(n))
		//https://www.youtube.com/watch?v=EeQ8pwjQxTM
		//Basically step1: Split all the numbers in to individual list  now they are single element sorted lists
		//start merging two lists in to a sorted array.. repeat this till we have one list
		public int[] Evaluate(int[] numbers) {
			var arrays = Split(numbers).ToList();
			var result = Merge(arrays);
			return result;
		}

		private IEnumerable<int[]> Split(int[] numbers) {
			foreach (var num in numbers)
			{
				yield return new[] { num };
			}
		}

		private int[] Merge(List<int[]> pot) {
			//do a group of two sets from the list
			//combine the group to produce an array add it to the pot
			//finally pass the pot to Merge function again till the list count is one
			List<int[]> newPot = new List<int[]>();
			while (pot.Count > 0) {
				var firstItem = pot[0];
				int[] secondItem = new int[0];
				pot.RemoveAt(0);

				if (pot.Count > 0) {
					secondItem = pot[0];
					pot.RemoveAt(0);
				}
				newPot.Add(Merge(firstItem, secondItem).ToArray());
			}
			if (newPot.Count == 1) {
				return newPot[0];
			}

			return Merge(newPot);
		}

		private IEnumerable<int> Merge(int[] one, int[] two) {
			int oneIndex = 0;
			int twoIndex = 0;
			while (one.Length > 0 && oneIndex < one.Length && two.Length >0 && twoIndex < two.Length) {
				if (one[oneIndex] < two[twoIndex])
				{
					yield return one[oneIndex];
					oneIndex++;
				}
				else {
					yield return two[twoIndex];
					twoIndex++;
				}
			}

			while (one.Length > 0 && oneIndex < one.Length) {
				yield return one[oneIndex];
				oneIndex++;
			}

			while (two.Length > 0 && twoIndex < two.Length)
			{
				yield return two[twoIndex];
				twoIndex++;
			}
		}
	}
}