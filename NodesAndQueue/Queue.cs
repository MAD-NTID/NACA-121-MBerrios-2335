using System.Collections;

public class Queue<T> : IQueue<T>, IEnumerable<T>
{
    public int Count 
    { 
        get; 
        private set;
    }

    private Node<T> front, back;
    
    public Queue()
    {
        front = null;
        back = null;
    }

    public void Clear()
    {
        front = null;
        back = null;
        Count = 0;
    }

    public bool Contains(T element)
    {
        //  Start from the front row
        Node<T> current = front;

        while(current is not null)
        {
            //  A match was found
            if(EqualityComparer<T>.Default.Equals(element, current.Data))
                return true;

            //  Keep going back to the line
            current = current.Next;
        }

        return false;
    }

    public void Enqueue(T element)
    {
        Node<T> node = new Node<T>(element);
        Count++;

        if(front is null)
        {
            //  Front element is both front and back because it's the only one
            front = node;
            back = node;
        }            
        else
        {
            back.Next = node;
            back = node;
        }        
    }

    public T Dequeue()
    {
        T data = front.Data;
        front = front.Next;
        Count--;

        if(front is null)
            back = null;

        return data;
    }

    public T Peek()
    {
        return front.Data;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> current = front;

        while(current is not null)
        {
            yield return current.Data;

            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public T[] ToArray()
    {
        T[] elements = new T[Count];

        Node<T> current = front;
        int i = 0;

        while(current is not null)
        {
            elements[i++] = current.Data;

            current = current.Next;
        }

        return elements;
    }

    public override string ToString()
    {
        if(front is null)
            return "null";

        return front.ToString();
    }
}