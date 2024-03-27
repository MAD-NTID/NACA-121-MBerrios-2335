public interface IPlayListMedia<T>
{
    public int GetTotalMedia { get; }

    public void Add(T media);
    public T ShowNextMedia();
    public T Play();
}