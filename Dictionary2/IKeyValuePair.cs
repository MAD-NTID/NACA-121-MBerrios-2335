public interface IKeyValuePair<TKey, TValue>
{
    public TKey Key { get; }
    public TValue Value { get; }
}