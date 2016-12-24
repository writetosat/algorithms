using System;

namespace AlgorithmsVs
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Executing");
			var numbers = new[] { 11, 16, 2, 8, 1, 9, 4, 7 };

			new HeapSort().Evaluate(numbers);
			Console.ReadLine();
		}

		private static void BinarySearch(int[] numbers, int numToFind) {
			var binarySearch = new BinarySearchSorted();
			var index =  binarySearch.Evaluate(numbers, numToFind);
			Console.WriteLine(index);
		}

		private static void SelectionSort(int[] numbers) {
			var selectionSort = new SelectioSort();
			selectionSort.Evaluate(numbers);
			Console.WriteLine(string.Join(",", numbers));
		}

		private static void InsertionSort(int[] numbers) {
			var insertionSort = new InsertionSort();
			var result = insertionSort.Evaluate(numbers);
			Console.WriteLine(string.Join(",", result));
		}

		private static void ExecuteMergeSort(int[] numbers) {
			var mergeSort = new MergeSort();
			var result = mergeSort.Evaluate(numbers);
			Console.WriteLine(string.Join(",", result));
		}

		private static void ExecuteBubbleSort(int[] numbers) { 
			var bubbleSort = new BubbleSort();
			bubbleSort.Evaluate(numbers, numbers.Length);
			Console.WriteLine(string.Join(",", numbers));
		}

		private  static void ExecuteQuickSort(int[] numbers) { 
			var quickSort = new QuickSort();
			quickSort.Evaluate(numbers, 0, numbers.Length);
			Console.WriteLine(string.Join(",", numbers));
		}
	}
}