public class Printer
{
    private int[] jobs;
    private int front, size;

    public Printer(int capacity)
    {
        this.jobs = new int[capacity];
        this.front = size = 0;
    }

    public bool Add(int job)
    {
        if(this.size == this.jobs.Length)
            return false;
        
        this.jobs[this.size] = job;
        this.size++;

        return true;
    }

    public int Print()
    {
        if(this.size == 0)
            return 0;
        
        int document = this.jobs[front];
        this.front++;
        this.size--;

        return document;
    }

    public bool Cancel(int job)
    {
        //setting the job to 0 will cancel it
        for(int i = 0; i < jobs.Length; i++){
            if(this.jobs[i] == job)
            {
                this.jobs[i] = 0;
                return true;
            }
        }
        return false;
    }

}