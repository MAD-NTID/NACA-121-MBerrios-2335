Dictionary<string, int> dictionary = new Dictionary<string, int>();

for(int i = 0; i < 5; i++)
    dictionary.Add($"{i}", i);

//  Collision on purpose
// dictionary.Add("5", 5);
// dictionary.Add("5", 5);

Console.WriteLine(dictionary.Get("5"));