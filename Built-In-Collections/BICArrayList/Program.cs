using System.Collections;

//  Declare and Initialize an ArrayList
ArrayList mixedValues = new();

//  You can add mixed of objects since .Add(object? value)
mixedValues.Add(5);
mixedValues.Add("Michael");
mixedValues.Add(2.5);

//  Limit the type to int
List<int> numbers = new();

numbers.Add(5);
//  This can't be added because, the collection is limited to <int>
// numbers.Add("Hello");
numbers.Add(21);
numbers.Add(18);

//  Get the sum of numbers
int sum = 0;
foreach(int number in numbers)
    sum += number;

Console.WriteLine($"The total sum is: {sum}");