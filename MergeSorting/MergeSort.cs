public class MergeSort<T>
{
    private T[] elements;
    public T[] Elements
    {
        get { return elements; }
    }
    
    public MergeSort(T[] elements)
    {
        this.elements = elements;
    }

    public T[] Sort(T[] elements)
    {
        int size = elements.Length;

        //  We only have 1 element in the array, by definition, it's sorted
        if(size == 1)
            return elements;

        //  We need to split the array in half, let's find the midpoint
        int midpoint = size / 2;

        //  We use this midpoint to create two halves of the original array
        // T[] left = new T[midpoint];
        // T[] right = new T[size - midpoint];
        //  We can simplify the above since we already have the copy methods that create the array for us
        //  I commented it just to show you why we need a midpoint and size - midpoint
        T[] left = Copy(elements, 0, midpoint);
        T[] right = Copy(elements, midpoint, size);

        //  Now recursively continues to split the newly created array until the base is met for each array
        left = Sort(left);
        right = Sort(right);

        //  Finally, we invoke the Merge method that will merge each of the array in the callstack (remember that recursion creates a call stack and processess in LIFO style)
        
        //  Return the merged left and right arrays
        return this.elements = Merge(left, right);
    }

    public T[] Merge(T[] arrayA, T[] arrayB)
    {
        //  Create a sorted of generic type for the merge
        int size = arrayA.Length + arrayB.Length;
        T[] sorted = new T[size];

        //  We need to keep track of the indexes for the 3 arrays
        int indexA = 0, indexB = 0, indexSorted = 0;

        //  The first step is to Merge Array A and ArrayB
        //  If either array runs out of indexes to process, break the loop
        while(indexA < arrayA.Length && indexB < arrayB.Length)
        {
            if(Comparer<T>.Default.Compare(arrayA[indexA], arrayB[indexB]) <= 0)
            {
                //  When the above comparison returns 0 or -1
                sorted[indexSorted] = arrayA[indexA];
                //  Process the next value in the arrayA
                indexA++;
            }
            else
            {
                //  When the above comparison returns 1
                sorted[indexSorted] = arrayB[indexB];
                //  Process the next value in the arrayB
                indexB++;
            }

            //  Move to the next available index of the sorted array
            indexSorted++;
        }

        //  Copy over the remaining elements from arrayA
        while(indexA < arrayA.Length)
        {
            sorted[indexSorted] = arrayA[indexA];
            indexA++;
            indexSorted++;
        }

        //  Copy over the remaining elements from arrayA
        while(indexB < arrayB.Length)
        {
            sorted[indexSorted] = arrayB[indexB];
            indexB++;
            indexSorted++;
        }

        //  Overwrite elements by the newly sorted array
        elements = sorted;
        return elements;
    }

    //  We need a method that allows us to copy values from array to a new array by starting and index position
    //  This is going to be used in the last step of the MergeSort algorithm Sort()
    public T[] Copy(T[] elements, int start, int end)
    {
        //  Determine the size by subtracting end - start
        int size = end - start;

        T[] copy = new T[size];

        //  We need an outside index to keep track of the index position for the copy array
        //  You will see how we use this in Sort() when we get to the point of splitting
        //  The array by half. 
        int copyIndex = 0;
        for(int i = start; i < end; i++)
        {
            copy[copyIndex] = elements[i];
            copyIndex++;
        }

        return copy;
    }

    public void PrintElements(string msg="")
    {
        if(!string.IsNullOrEmpty(msg))
            Console.WriteLine($"{msg}: ");

        for(int i = 0; i < elements.Length; i++)
            Console.Write($"{elements[i]} ");

        Console.WriteLine();
    }
}