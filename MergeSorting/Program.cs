//  Time to Test our MergeSort Algorithm
MergeSort<int> mergeSortInts = new([5, 2, 9, 1]);

//  Let's print the array before we merge
mergeSortInts.PrintElements("Unsorted");

//  Let's sort it
mergeSortInts.Sort(mergeSortInts.Elements);

//  Let's print the array before we merge
mergeSortInts.PrintElements("Sorted");

Console.WriteLine();
Console.WriteLine("===========================================================");

//  Time to Test our MergeSort Algorithm
MergeSort<string> mergeSortLetters = new(["x", "z", "b", "a"]);

//  Let's print the array before we merge
mergeSortLetters.PrintElements("Unsorted");

//  Let's sort it
mergeSortLetters.Sort(mergeSortLetters.Elements);

//  Let's print the array before we merge
mergeSortLetters.PrintElements("Sorted");

Console.WriteLine();
Console.WriteLine("===========================================================");

//  Time to Test our MergeSort Algorithm (for symbols, must use char not string)
MergeSort<char> mergeSortSymbols = new(['?', '>', '=', '<', ';', ':']);

//  Let's print the array before we merge
mergeSortSymbols.PrintElements("Unsorted");

//  Let's sort it
mergeSortSymbols.Sort(mergeSortSymbols.Elements);

//  Let's print the array before we merge
mergeSortSymbols.PrintElements("Sorted");