Dictionary<string, int> dictionary = new Dictionary<string, int>(5);

dictionary.Add("Erik", 3);
dictionary.Add("Gusty", 3);

bool erik = dictionary.ContainsKey("Erik");
int erikIndex = dictionary.GetIndex("Erik");
Console.WriteLine($"Is Erik in the dictionary: {erik}, at index {erikIndex}\n");

bool gus = dictionary.ContainsKey("Gus");
int gusIndex = dictionary.GetIndex("gusIndex");
Console.WriteLine($"Is Gus in the dictionary: {gus}, at index {gusIndex}\n");

bool mike = dictionary.ContainsKey("Mike");
int mikeIndex = dictionary.GetIndex("mikeIndex");
Console.WriteLine($"Is Mike in the dictionary: {mike}, at index {mikeIndex}");

//  This will cause a collision due to hashing function of a key which may 
//  result in an index position already occupied in the array of the dictionary
// for(int i = 0; i < 5; i++)
//     dictionary.Add($"{i}", i);

//  Collision on purpose
// dictionary.Add("5", 5);
// dictionary.Add("5", 5);

// Console.WriteLine(dictionary.Get("5"));