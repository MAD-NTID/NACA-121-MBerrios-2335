int[] ints = [9, 3, 5, 1, 0, 3, 2];

QuickSort<int> quickSort = new();

Console.WriteLine("Unsorted");
quickSort.PrintElements(ints);

Console.WriteLine("\n\nSorting Now...\n");
quickSort.Sort(ints, 0, ints.Length - 1);

Console.WriteLine("Sorted");
quickSort.PrintElements(ints);