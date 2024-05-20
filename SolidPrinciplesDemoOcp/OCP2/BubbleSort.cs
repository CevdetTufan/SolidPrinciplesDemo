namespace SolidPrinciplesDemoOcp.OCP2
{
	// Bubble sort implementation
	public class BubbleSort : ISortAlgorithm
	{
		public void Sort(int[] array)
		{
			int n = array.Length;

			for (int i = 0; i < n-1; i++)
			{
				for (int j = 0; j < n-i; j++)
				{
					if (array[j] > array[j + 1])
					{
						int temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
		}
	}
}
