public class PlayListMediaStack<T> : PlayListMedia<T>
{
    private Stack<T> stack;

    public int TotalMedia { get { return totalMedia; }}

    public PlayListMediaStack()
    {
        stack = new Stack<T>();
    }

    public override void Add(T media)
    {
        stack.Push(media);
        totalMedia++;
    }

    public override T Play()
    {
        totalMedia--;
        return stack.Pop();
    }

    public override T ShowNextMedia()
    {
        return stack.Peek();
    }

    public override string ToString()
    {
        return stack.ToString();
    }
}