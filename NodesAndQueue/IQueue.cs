public interface IQueue<T>
{
    public int Count { get; }
    public void Clear();
    public bool Contains(T element);
    public T Peek();
    public void Enqueue(T element);
    public T Dequeue();
    public T[] ToArray();
}