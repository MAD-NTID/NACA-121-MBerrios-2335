public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
{
    private int count;
    public int Count => count;
    
    private int capacity;
    private const int DEFAULT_CAPACITY = 5;

    //  This is the hash table
    public IKeyValuePair<TKey, TValue>[] hashTable;

    //  This is an OVERLOADED Constructor
    public Dictionary(int capacity)
    {
        hashTable = new IKeyValuePair<TKey, TValue>[capacity];
        count = 0; 
        this.capacity = capacity;
    }

    //  Default CAPACITY if the programmer does not specify capacity
    public Dictionary() : this(DEFAULT_CAPACITY) {}

    public void Add(TKey key, TValue value)
    {
        int location = GetIndex(key);

        //  Rule of Dictionary you can't have duplicates...literally
        if(ContainsKey(key))
            throw new ArgumentException("Duplication Key is not allowed");

        IKeyValuePair<TKey, TValue> kvp = new KeyValuePair<TKey, TValue>(key, value);

        hashTable[location] = kvp;
        count++;
    }

    public void Clear()
    {
        hashTable = new IKeyValuePair<TKey, TValue>[capacity];
        count = 0;
    }

    public bool ContainsKey(TKey key)
    {
        int index = GetIndex(key);

        IKeyValuePair<TKey, TValue> kvp = hashTable[index];

        return kvp is not null;
    }

    public bool ContainValue(TValue value)
    {
        //  Iterate the collection of KVP and compare for value, if match, return boolean
        //  O(N)
        foreach(IKeyValuePair<TKey, TValue> kvp in hashTable)
            if(kvp is not null && EqualityComparer<TValue>.Default.Equals(kvp.Value, value))
                return true;

        return false;
    }

    public IKeyValuePair<TKey, TValue> Get(TKey key)
    {
        int index = GetIndex(key);

        return hashTable[index];
    }

    public int GetIndex(TKey key)
    {
        int hash = key.GetHashCode();

        //  Convert to positive if negative
        // if(hash < 0)
        //     hash *= -1;

        //  ALTERNATIVELY
        //  Force any number to be positive
        hash = Math.Abs(hash);

        int index = hash % capacity;

        return index;
    }

    public bool Remove(TKey key)
    {
        if(!ContainsKey(key))
            return false;

        int index = GetIndex(key);

        hashTable[index] = null;
        count--;

        return true;
    }
}