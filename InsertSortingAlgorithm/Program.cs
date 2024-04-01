//  Create a small set of unsorted integers
int[] numbers = {8, 2, 9, 0, 1};

//  Instantiate Sort
Sort<int> sortIntegers = new(numbers);

//  Print the unsorted numbers before sorting
Console.WriteLine(sortIntegers);

//  Now Sort, and display returned sorted numbers
sortIntegers.Ascending();

//  Print the "sorted" numbers after sorting
Console.WriteLine(sortIntegers);
Console.WriteLine("=============================");
string[] letters = {"z", "y", "x", "a"};

Sort<string> sortLetters = new(letters);

Console.WriteLine(sortLetters);

sortLetters.Ascending();

Console.WriteLine(sortLetters);