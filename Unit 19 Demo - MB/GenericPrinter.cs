public class GenericPrinter<T>
{
    private T[] jobs;
    private int front, size;

    public GenericPrinter(int capacity)
    {
        jobs = new T[capacity];
    }

    public bool Add(T job)
    {
        if(size == jobs.Length)
            return false;

        jobs[size++] = job;

        return true;
    }

    public T Print()
    {
        if(size == 0)
            return default;

        T document = jobs[front++];

        return document;
    }

    public bool Cancel(T job)
    {
        for(int i = 0; i < jobs.Length; i++)
        {
            if(EqualityComparer<T>.Default.Equals(jobs[i], job))
            {
                jobs[i] = default;
                return true;
            }
        }

        return false;
    }
}