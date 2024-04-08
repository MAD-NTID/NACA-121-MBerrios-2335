public interface IDictionary<TKey, TValue>
{
    public int Count { get; }
    public void Clear();
    public bool ContainKey(TKey key);
    public bool ContainValue(TValue value);
    public void Add(TKey key, TValue value);
    public bool Remove(TKey key);
    public int GetIndex(TKey key);
    
    //  Returns the KVP itself
    public IKeyValuePair<TKey, TValue> Get(TKey key);
}