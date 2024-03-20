Queue<int> intQueue = new Queue<int>();

for(int i = 1; i <= 10; i++)
{
    intQueue.Enqueue(i);

    Console.WriteLine($"Added Number {i} to the Queue");
}    

Console.WriteLine(intQueue);

Console.WriteLine("Now let's dequeue, should remove 1");
int removed = intQueue.Dequeue();

if(removed > 0)
    Console.WriteLine($"{removed} was removed from the queue");

Console.WriteLine("intQueue after Dequeue()");
Console.WriteLine(intQueue);

Console.WriteLine($"Who's in the front? {intQueue.Peek()}");

Console.WriteLine("Let's convert to array: ");
int[] intQueueNums = intQueue.ToArray();

for(int i = 0; i < intQueueNums.Length; i++)
    Console.WriteLine($"Array index {i} has {intQueueNums[i]}");

Console.WriteLine("Let's clear the Queue");
intQueue.Clear();

Console.WriteLine($"The queue after clearing\n---> {intQueue}");