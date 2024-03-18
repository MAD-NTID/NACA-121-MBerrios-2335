public interface IStack<T>
{
    public int Count { get; }
    public void Clear();
    public bool Contains(T element);
    public T Peek();
    public T Pop();
    public void Push(T element);
    public T[] ToArray();
}