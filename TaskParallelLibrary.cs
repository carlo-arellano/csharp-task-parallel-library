namespace csharp_task_parallel_library;

public class TaskParallelLibrary
{
    public static void PrintNumbers()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void ReverseNumbers()
    {
        for (int i = 3; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}
