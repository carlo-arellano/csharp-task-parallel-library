namespace csharp_task_parallel_library;

public class MultiThreading
{

    public static void PrintNumber()
    {
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine($"Worker Thread: {i}");
            Thread.Sleep(500);
        }
    }

    public static void PrintMessage(object msg)
    {
        Console.WriteLine($"Message: {msg}");
    }

    public static void Print(object msg)
    {
        Console.WriteLine($"Thread: {msg}");
    }

    public static async Task FetchData()
    {
        await Task.Delay(2000);
        Console.WriteLine("Data fetched!");
    }

}