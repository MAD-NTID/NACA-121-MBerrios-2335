public class KeyValuePair<TKey, TValue> : IKeyValuePair<TKey, TValue>
{
    public TKey Key { get; private set; }

    public TValue Value { get; private set; }

    public KeyValuePair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }

    public override string ToString()
    {
        return $"{Key} : {Value}";
    }
}