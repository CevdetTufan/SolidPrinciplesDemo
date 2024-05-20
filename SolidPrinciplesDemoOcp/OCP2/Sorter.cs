namespace SolidPrinciplesDemoOcp.OCP2
{
	//Class to sort an array using a specific sorting algorithm
	public class Sorter
	{
		private readonly ISortAlgorithm _sortAlgorithm;

		public Sorter(ISortAlgorithm sortAlgorithm)
		{
			_sortAlgorithm = sortAlgorithm;
		}

		public void SortArray(int[] array)
		{
			_sortAlgorithm.Sort(array);
		}
	}
}
