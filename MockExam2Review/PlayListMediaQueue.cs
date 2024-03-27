public class PlayListMediaQueue<T> : PlayListMedia<T>
{
    private Queue<T> queue;

    public int TotalMedia { get { return totalMedia; }}

    public PlayListMediaQueue()
    {
        queue = new Queue<T>();
    }

    public override void Add(T media)
    {
        queue.Enqueue(media);
        totalMedia++;
    }

    public override T Play()
    {
        totalMedia--;
        return queue.Dequeue();
    }

    public override T ShowNextMedia()
    {
        return queue.Peek();
    }

    public override string ToString()
    {
        return queue.ToString();
    }
}