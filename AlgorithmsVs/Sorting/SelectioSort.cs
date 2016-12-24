namespace AlgorithmsVs
{
	public class SelectioSort {
		//https://www.youtube.com/watch?v=GUDLRan2DWM
		//have two arrays. find index of min number from left list and move to right list or sorted list
		//continue the same from remaining
		//the same can be achieved by having single array so that we can make it inplace editing.

		public void Evaluate(int[] numbers) {
			int currentIndex = 0;
			while (currentIndex < numbers.Length) { 
				int prevMin = int.MaxValue;
				int minIndex = -1;
				for (int i = currentIndex; i < numbers.Length; i++)
					{
						if (numbers[i] < prevMin)
						{
							minIndex = i;
							prevMin = numbers[i];
						}
					}
					var tmp = numbers[currentIndex];
					numbers[currentIndex] = numbers[minIndex];
					numbers[minIndex] = tmp;
					currentIndex++;
			}
		}
	}
}