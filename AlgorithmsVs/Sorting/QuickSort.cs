using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsVs
{
	
	public class QuickSort
	{
		//The idea is we take a pivot (usually the right most) and make sure that the arragnment is such that lower numbers to that pivot and higher numbers towards right
		//Look at the video
		public void Evaluate(int[] numbers, int start, int length)
		{
			int pivot = numbers[length - 1];
			int currentIndex = start;
			int i = start;
			bool nothingToMove = true;
			while (currentIndex <= length -1)
			{
				if (numbers[currentIndex] <= pivot)
				{
					var tmp = numbers[i];
					numbers[i] = numbers[currentIndex];
					numbers[currentIndex] = tmp;
					currentIndex++;
					i++;
					nothingToMove = false;
				}
				else
				{
					currentIndex++;
				}
			}
			if (!nothingToMove && i -  start - 2 > 1) { 
				Evaluate(numbers, start, i - 2);
			}
			if (!nothingToMove && length - i > 1) { 
				Evaluate(numbers, i, length);
			}
		}
	}
}