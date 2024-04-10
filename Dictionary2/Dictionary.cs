using System.Reflection.PortableExecutable;

public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
{
    private int count;
    public int Count => count;

    private const double LOAD_FACTOR = .70;
    public double LoadFactor => LOAD_FACTOR;

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
        EnsureCapacity();

        //  Rule of Dictionary you can't have duplicates...literally
        if(ContainsKey(key))
            throw new ArgumentException("Duplication Key is not allowed");

        int location = LinearProbing(key);

        if(location == -1)
            throw new ArgumentException("No available location!");

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
        int index = LinearProbing(key, true);

        return index >= 0;
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
        if(!ContainsKey(key))
            throw new ArgumentException("$Key: {key} doesn't exist!");

        return hashTable[LinearProbing(key, true)];
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

        int index = LinearProbing(key, true);

        hashTable[index] = null;
        count--;

        return true;
    }

    public void EnsureCapacity()
    {
        //  Check the factor of the current arrays
        double loadFactor = count / capacity;

        if(loadFactor >= LoadFactor)
        {
            //  Then we grow the array by double (hashTable)
            capacity *= 2;

            //  Create a temp hashTable with the new doubled capacity
            IKeyValuePair<TKey, TValue>[] tempHashTable = new KeyValuePair<TKey, TValue>[capacity];

            //  Copy over the old values to the temp hasTable
            for(int i = 0; i < hashTable.Length; i++)
                tempHashTable[i] = hashTable[i];

            //  Overwrite the old hashTable with the new tempHashTable
            hashTable = tempHashTable;
        }
    }

    public int LinearProbing(TKey key, bool searchExistingKey = false)
    {
        int startIndex = GetIndex(key);

        //  Initialize the index to start probing without touching "startIndex"
        int index = startIndex;

        do
        {
            IKeyValuePair<TKey, TValue> kvp = hashTable[index];

            //  We are in search for exisitng index probing
            if(searchExistingKey && kvp is not null && EqualityComparer<TKey>.Default.Equals(key, kvp.Key))
            {
                return index;   
            }

            //  We are probing for an available spot
            else if(!searchExistingKey && kvp is null)
            {
                return index;
            }

            //  Move to the next index, wrapping around if necessary
            index = (index + 1) % capacity;
        } while(index != startIndex);

        //  Probed the entire array and unsuccessfully found an available spot :(
        return -1;
    }
}