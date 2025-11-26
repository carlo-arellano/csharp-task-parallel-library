namespace csharp_task_parallel_library;

public class Counter
{
    private int count = 0;
    private readonly object locker = new();

    public void Increment()
    {
        lock (locker)
        {
            count++;
            Console.WriteLine($"Count: {count}");
        }
    }

}
