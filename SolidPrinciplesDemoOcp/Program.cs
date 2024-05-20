
using SolidPrinciplesDemoOcp.OCP2;

int[] array = { 5, 3, 8, 4, 2, 7, 1, 6 };

// Sorting using bubble sort
Sorter bubbleSorter = new Sorter(new BubbleSort());
bubbleSorter.SortArray(array);
Console.WriteLine("Sorted array using bubble sort:");
PrintArray(array);

// Sorting using quick sort
Sorter quickSorter = new Sorter(new QuickSort());
quickSorter.SortArray(array);
Console.WriteLine("\nSorted array using quick sort:");
PrintArray(array);

static void PrintArray(int[] array)
{
	foreach (var item in array)
	{
		Console.Write(item + " ");
	}
	Console.WriteLine();
}