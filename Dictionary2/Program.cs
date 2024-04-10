Dictionary<string, int> dictionary = new Dictionary<string, int>(5);

Console.WriteLine("Erik and Gus key values are destined to collide");
dictionary.Add("Erik", 3);
dictionary.Add("Gus", 3);

bool erik = dictionary.ContainsKey("Erik");
int erikAtIndex = dictionary.LinearProbing("Erik", true);
Console.WriteLine($"Is Erik in the dictionary: {erik}, at index {erikAtIndex}\n");

bool gus = dictionary.ContainsKey("Gus");
int gusAtIndex = dictionary.LinearProbing("Erik", true);
Console.WriteLine($"Is Gus in the dictionary: {gus}, at index {gusAtIndex}\n");

bool mike = dictionary.ContainsKey("Mike");
int mikeAtIndex = dictionary.LinearProbing("Erik", true);
Console.WriteLine($"Is Mike in the dictionary: {mike}, at index {mikeAtIndex}");

//  This will cause a collision due to hashing function of a key which may 
//  result in an index position already occupied in the array of the dictionary
// for(int i = 0; i < 5; i++)
//     dictionary.Add($"{i}", i);

// for(int i = 0; i < 5; i++)
//     Console.WriteLine(dictionary.Get($"{i}"));

//  Collision on purpose
// dictionary.Add("5", 5);
// dictionary.Add("5", 5);

// Console.WriteLine(dictionary.Get("5"));