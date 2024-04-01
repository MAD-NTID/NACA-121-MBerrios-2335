public class Sort<T>
{
    private T[] numbers;

    public Sort(T[] numbers)
    {
        this.numbers = numbers;
    }

    public T[] Ascending()
    {
        //  InsertSort Algorithm Here
        //  First Loop moves forward >>>>>>>>>>>>>
        for(int i = 1; i < numbers.Length; i++)
        {
            //  First, Retain the starting value
            T currentValue = numbers[i];

            //  Second, we need to keep the position of where the last comparison happened, so, let's declare j outside of the loop
            int j;

            //  <<<<<<<<<< Second Loop moves backwards
            for(j = i; j > 0 && IsGreater(numbers[j - 1], currentValue); j--)
            {
                numbers[j] = numbers[j - 1];
            }

            //  Finally, we have the last location where the sorted value is going to be "inserted", hence the name, InsertionSort
            numbers[j] = currentValue;
        }

        return numbers;
    }

    public bool IsGreater(T element1, T element2)
    {
        //  Our goal is that element1 be greater than element2, so that we swap them
        return Comparer<T>.Default.Compare(element1, element2) > 0;
    }

    public override string ToString()
    {
        string numbersSorted = string.Empty;

        for(int i = 0; i < numbers.Length; i++)
            numbersSorted += $"{numbers[i]} ";

        return numbersSorted;
    }
}