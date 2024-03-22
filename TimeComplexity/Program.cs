//  How to start Stopwatch in order to calculate the time taken to complete a task
//  This is essential tool for testing time complexity
using System.Diagnostics;
//  System.Diagnostics includes a Stopwatch

Stopwatch stopwatch = new Stopwatch();

//  This dataset is before starting the timer
// int[] numbers = {1, 2, 3, 4, 5};
//int favoriteNumberIndex = 3; // is 4

//  We start the timer now
stopwatch.Start();
//  We do some intensive task here
//  0(1)
// Console.WriteLine($"My favorite number {numbers[favoriteNumberIndex]}");

int[,] twoDNumbers = new int[1000 * 5, 1000 * 5];

//  generate random numbers
for(int r = 0; r < twoDNumbers.GetLength(0); r++)
    for(int c = 0; c < twoDNumbers.GetLength(1); c++)
        twoDNumbers[r, c] = new Random().Next(200);

//  Let's find number 10
int findNumber = 10;

bool found = false;
for(int r = 0; r < twoDNumbers.GetLength(0); r++)
{
    for(int c = 0; c < twoDNumbers.GetLength(1); c++)
    {
        if(twoDNumbers[r, c] == findNumber)
        {
            Console.WriteLine($"Number {findNumber} was found");
            found = true;
            break;
        }
    }

    if(found)
        break;
}

if(!found)
    Console.WriteLine($"The number {findNumber} was not found");

//  We stop the timer
stopwatch.Stop();

//  Then show the results
Console.WriteLine($"The task took {stopwatch} milliseconds to complete");