Queue<string> collegeGrindLine = new();

collegeGrindLine.Enqueue("Erik");
collegeGrindLine.Enqueue("Gus");
collegeGrindLine.Enqueue("Ghost");

//  Process the line
while(collegeGrindLine.Count > 0)
    Console.WriteLine($"{collegeGrindLine.Dequeue()} finished ordering");