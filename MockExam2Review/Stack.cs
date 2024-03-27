using System.Collections;

public class Stack<T> : IStack<T>, IEnumerable<T>
{
    private Node<T> top;
    public int Count { get; private set; }

    public Stack()
    {
        top = null;
        Count = 0;
    }

    public void Clear()
    {
        top = null;
        Count = 0;
    }

    public bool Contains(T element)
    {
        //  First Edge Case, if there are no Nodes, then, it doesn't exist
        if(top is null)
            return false;

        //  Get a reference to the current 'top' Node<T>
        //  We will start searching from the top down
        Node<T> currentTop = top;

        while(currentTop is not null)
        {
            if(EqualityComparer<T>.Default.Equals(element, currentTop.Data))
                return true;

            //  Replace the currentTop to the Next of the current top to continue checking the Next LL
            currentTop = currentTop.Next;
        }

        //  If you made it here, then it doesn't exist
        return false;
    }

    //  return the data of the top Node
    public T Peek()
    {
        return top.Data;
    }

    //  you can also return the Node<T> at the top instead
    // public Node<T> Peek()
    // {
    //     return top;
    // }

    public T Pop()
    {
        //  Get the 'top' T data to be returned
        T data = top.Data;

        // Set the Next Node<T> of the current 'top' as the new 'top'
        // Essentially, "removing" the current 'top'
        top = top.Next;

        //  Decrease the Counter by 1
        Count--;

        //  Return the 'top' T data
        return data;
    }

    public void Push(T element)
    {
        // Copy the temporary 'top' Node<T>
        Node<T> tempTop = top;
        
        //  Create a new Node<T> for the given T Element
        //  Add reference to the Previous 'top'
        Node<T> newNode = new Node<T>(element, tempTop);

        //  Reassign the 'top' with the newNode
        top = newNode;

        //  Increase the counter by 1
        Count++;
    }

    //  This code allows us to do a ForEach (Iteration) over the stack
    public IEnumerator<T> GetEnumerator()
    {
        Node<T> currentTop = top;

        while(currentTop is not null)
        {
            yield return currentTop.Data;

            currentTop = currentTop.Next;
        }
    }

    //  This tells C# to use our custom IEnumerator above rather than the stock one
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public T[] ToArray() 
    {
        //  Create an array to hold the elements with the length from 'Count'
        T[] elements = new T[Count];
        int i = 0;

        //  Create a copy of the 'top' Node<T>, iterate down through each Node<T>
        Node<T> currentTop = top;

        while (currentTop is not null)
        {
            elements[i++] = currentTop.Data;

            currentTop = currentTop.Next;
        }

        //foreach (T element in top)
        //{
        //    elements[i++] = element;
        //}

        return elements;
    }

    public override string ToString()
    {
        return top is not null ? top.ToString() : "null";
    }
}