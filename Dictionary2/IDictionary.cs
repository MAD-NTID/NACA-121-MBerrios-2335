public interface IDictionary<TKey, TValue>
{
    public int Count { get; }
    public double LoadFactor { get; }
    public void Clear();
    public bool ContainsKey(TKey key);
    public bool ContainValue(TValue value);
    public void Add(TKey key, TValue value);
    public bool Remove(TKey key);
    public int GetIndex(TKey key);
    public void EnsureCapacity();
    public int LinearProbing(TKey key, bool searchExistingKey = false);
    
    //  Returns the KVP itself
    public IKeyValuePair<TKey, TValue> Get(TKey key);
}