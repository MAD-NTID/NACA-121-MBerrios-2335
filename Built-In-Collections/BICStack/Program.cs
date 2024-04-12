Stack<string> pancakes = new();

for(int i = 0; i < 5; i++)
    pancakes.Push($"Layer {i + 1}");

// foreach(string pancake in pancakes)
//     Console.WriteLine($"Ate {pancake}");
//pancakes.Clear();

while(pancakes.Count > 0)
    Console.WriteLine($"Ate {pancakes.Pop()}");