public interface IKeyValuePair<TKey, TValue>
{
    TKey Key { get; }
    public TValue Value { get; }
}