using System;

namespace AlgorithmsVs
{
	public class BubbleSort {
		//https://www.youtube.com/watch?v=Jdtq5uKz-w4
		//basically we compare one element with next element and the first element is greater then we swap and move to next index and so on
		//we call each iteration as pass and once we reach at the end the last element is always sorted;
		//o(n ** 2)
		public void Evaluate(int[] numbers, int length) {

			for (int i = 0; i < length - 1; i++)
			{
				if (numbers[i] > numbers[i + 1]){
					var tmp = numbers[i];
					numbers[i] = numbers[i + 1];
					numbers[i + 1] = tmp;
				}
			}
			if (length - 1 > 1) { 
				Evaluate(numbers, length - 1);
			}
		}
	}
	
}