//// Create the nodes without a next reference
//Node<string> michael = new("michael", null);
//Node<string> erik = new("erik", null);
//Node<string> gus = new("gus", null);

////  Now let's hook the nodes with their next references
////  michael refers to erik
////  erik refers to gus
////  gus refers to ....
//michael.Next = erik;
//erik.Next = gus;
//// gus.Next = null; // <<< this is not needed since in line 4 is already null for Next

//// this will display from michael all the way to gus's next which is null
//Console.WriteLine(michael);

//// this will display from erik all the way to gus's next which is null, ignoring michael
//Console.WriteLine(erik);

//// this will display from gus all the way to gus's next which is null, ignoring michael, and erik
//Console.WriteLine(gus); 

Stack<int> intStack = new Stack<int>();

for(int i = 0; i < 10; i++)
{
    intStack.Push(i);

    Console.WriteLine($"{i} was pushed to the intStack");
}
Console.WriteLine();
Console.WriteLine("The stack with far Left being the Top");
Console.WriteLine(intStack);
Console.WriteLine();

//  Printing the stack elements starting from the top using ForEach (this is where IEnumerator in Stack.cs becomes helpful)
Console.WriteLine("Printing the element from the stack utilizing foreach (IEnumerator implementation is proven successful here)");
foreach (int element in intStack)
    Console.WriteLine($"Element {element} from stack");
Console.WriteLine();

Console.WriteLine("Retrieving the elements as array");
int[] elements = intStack.ToArray();
for(int i = 0; i < elements.Length;i++)
    Console.WriteLine($"Element {elements[i]} from stack using array elements[{i}]"); 
Console.WriteLine();

Console.WriteLine("Clearing the stack");
Console.WriteLine($"Size of the Stack before clear {intStack.Count}");
Console.WriteLine($"Content of the Stack before clear \n{intStack}");
intStack.Clear();
Console.WriteLine($"Size of the Stack after clearing {intStack.Count}");
Console.WriteLine($"Content of the Stack after clear\n{intStack}");