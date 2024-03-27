public abstract class PlayListMedia<T> : IPlayListMedia<T>
{
    protected int totalMedia;
    public int GetTotalMedia
    {
        get { return totalMedia; }
    }

    public abstract void Add(T media);

    public abstract T Play();

    public abstract T ShowNextMedia();
}