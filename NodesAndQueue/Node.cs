public class Node<T>
{
    private T data;
    public T Data
    {
        get { return data; }
        set { data = value; }
    }
    
    private Node<T> next;
    public Node<T> Next
    {
        get { return next; }
        set { next = value; }
    }
    
    public Node(T data, Node<T> next)
    {
        Data = data;
        Next = next;
    }

    public Node(T data) : this(data, null) {}

    // Returns String Information about Self Node, and the Next Node
    public override string ToString()
    {
        string nodeString = $"{Data.ToString()} ---> ";

        if(Next is null)
            nodeString += "null";
        else
            nodeString += Next.ToString();

        return nodeString;
    }
}