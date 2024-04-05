public class QuickSort<T>
{
    public void Sort(T[] array, int lo, int hi, bool sortDescending = false, bool random = false)
    {
        if(lo >= hi || lo < 0)
            return;

        int p = Partition(array, lo, hi, sortDescending, random);

        Sort(array, lo, p - 1, sortDescending, random);
        Sort(array, p + 1, hi, sortDescending, random);
    }

    public int Partition(T[] array, int lo, int hi, bool sortDescending = false, bool random = false)
    {
        int pivotIndex = hi;

        if(random)
            pivotIndex = new Random().Next(lo, hi + 1) ;
        
        T pivot = array[pivotIndex];

        if(random)
            Swap(array, pivotIndex, hi);

        int i = lo - 1;

        for(int j = lo; j < hi; j++)
        {
            if(!sortDescending && Comparer<T>.Default.Compare(array[j], pivot) < 0)
            {
                i++;
                Swap(array, i, j);
            }

            if(sortDescending && Comparer<T>.Default.Compare(array[j], pivot) > 0)
            {
                i++;
                Swap(array, i, j);
            }
        }

        i++;
        Swap(array, i, hi);

        return i;
    }

    private void Swap(T[] array, int firstIndex, int secondIndex)
    {
        T temp = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = temp;
    }

    public void PrintElements(T[] elements)
    {
        foreach(T t in elements)
            Console.Write($"{t} ");
    }
}