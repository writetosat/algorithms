namespace AlgorithmsVs
{
	public class HeapSort
	{
		//https://www.youtube.com/watch?v=XivWm2nEOy0&index=35&list=PLsFNQxKNzefJNztGGoQC-59UhSwIaiIW3
		/// <summary>
		/// Good videos
		/// </summary>

		public void Evaluate(int[] numbers) {
			BuildHeapEx(numbers, numbers.Length - 1); // generate the heap first for all the numbers
			int sortedIndex = numbers.Length; //outside of boundary.. if there are three numbers then this will be 3
			while (sortedIndex > 0) {
				//exchange the top parent with last value
				sortedIndex--; // if 3 then now 2.. exchange the value and freeze. that means now the 2nd index is freezed.. so we need to build up to 1 index
				numbers.Swap(sortedIndex, 0);
				BuildHeapEx(numbers, sortedIndex - 1); // as now the numbers are swapped we need to generate heap for rest of the numbers
			}
		}

		private void BuildHeapEx(int[] numbers, int maxIndex) {
			for (int i = maxIndex; i > 0; i--)
			{
				//get parent
				//compare
				//swap
				var parent = (int)((i - 1) / 2);
				if (numbers[parent] < numbers[i]) {
					numbers.Swap(parent, i);
				}
			}
		}
	}
}