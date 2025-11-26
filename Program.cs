using csharp_task_parallel_library;
using System.Collections.Concurrent;
using System.Data.SqlTypes;

//Console.WriteLine("Creating Threads");

//Console.WriteLine("1. Using Thread Class");
//Thread t1 = new(MultiThreading.PrintNumber);
//t1.Start();

//for (int i = 0; i <= 5; i++)
//{
//    Console.WriteLine($"Main Thread: {i}");
//    Thread.Sleep(500);
//}


//Console.WriteLine("2. Using ParametarizedThreadStart");
//Thread t1 = new(MultiThreading.PrintMessage);
//t1.Start("Hello from Thread");


//Console.WriteLine("3. Using Lambda Expression");
//Thread t = new(() =>
//{
//    for (int i = 1; i <= 3; i++)
//    {
//        Console.WriteLine($"Lambda Thread: {i}");
//    }
//});
//t.Start();


//Console.WriteLine("Foreground and Background Threads");
//Thread t = new(() =>
//{
//    Console.WriteLine("Background thread running");
//});
//t.IsBackground = true;
//t.Start();


//Console.WriteLine("Thread Synchronization");
//Counter counter = new();
//Thread t1 = new(counter.Increment);
//Thread t2 = new(counter.Increment);
//t1.Start();
//t2.Start();


//Console.WriteLine("Thread Pooling");
//ThreadPool.QueueUserWorkItem(MultiThreading.Print, "Task 1");
//ThreadPool.QueueUserWorkItem(MultiThreading.Print, "Task 2");


//Console.WriteLine("Multithreading with Tasks");
//Task t1 = Task.Run(() =>
//{
//    for (int i = 1; i <= 5; i++)
//    {
//        Console.WriteLine($"Task 1: {i}");
//    }
//});
//Task t2 = Task.Run(() =>
//{
//    for (int i = 1; i <= 5; i++)
//    {
//        Console.WriteLine($"Task 2: {i}");
//    }
//});
//Task.WaitAll(t1, t2);


//Console.WriteLine("Async and Await (High-Level Multithreading)");
//Console.WriteLine("Fetching...");
//await MultiThreading.FetchData();
//Console.WriteLine("Done!");


//Console.WriteLine("Task Parallel Library");
//Task task1 = Task.Run(() => TaskParallelLibrary.PrintNumbers());
//Task task2 = Task.Run(() => TaskParallelLibrary.PrintNumbers());
//Task.WhenAll(task1, task2).Wait();


//Console.WriteLine("Task Class");
//Task task1 = Task.Run(() => TaskParallelLibrary.PrintNumbers());
//Task task2 = Task.Run(() => TaskParallelLibrary.ReverseNumbers());
//Task.WhenAll(task1, task2).Wait();


//Console.WriteLine("Task Cancellation");

//List<string> data = ["Apple", "Banana", "Grapes", "Orange", "Strawberry"];
//CancellationTokenSource cts = new();
//CancellationToken token = cts.Token;

//Task.Run(() =>
//{
//    try
//    {
//        Console.WriteLine("Task started.");
//        Parallel.ForEach(data, new ParallelOptions { CancellationToken = token }, item =>
//        {
//            token.ThrowIfCancellationRequested();
//            Console.WriteLine($"Data [{item}] on thread: {Environment.CurrentManagedThreadId}");
//        });
//        Console.WriteLine("Task completed.");
//    }
//    catch (OperationCanceledException)
//    {
//        Console.WriteLine("Task was canceled.");
//    }
//}, token).Wait();
//Task.Delay(200).Wait();

//cts.Cancel();
//cts.Dispose();
//Console.WriteLine("Main method completed.");


//Console.WriteLine("Parallel Class");

//Console.WriteLine("Parallel.For");
//List<string> data = ["Apple", "Banana", "Grapes", "Orange", "Strawberry"];
//Parallel.For(0, data.Count, ele =>
//{
//    Console.WriteLine($"Data => {ele} on thread: -{Thread.CurrentThread.ManagedThreadId}");
//});
//Console.WriteLine();

//Console.WriteLine("Parallel.ForEach");
//List<string> data1 = ["Apple", "Banana", "Grapes", "Orange", "Strawberry"];
//Parallel.ForEach(data1, ele =>
//{
//    Console.WriteLine($"Data => [{ele}] on thread: -{Thread.CurrentThread.ManagedThreadId}");
//});
//Console.WriteLine();

//Console.WriteLine("Parallel.Invoke");
//List<string> data2 = ["Apple", "Banana", "Grapes", "Orange", "Strawberry"];
//Parallel.Invoke(
//    () => Console.WriteLine($"Data => [{data2[0]}] on thread:-{Thread.CurrentThread.ManagedThreadId}"),
//    () => Console.WriteLine($"Data => [{data2[1]}] on thread:-{Thread.CurrentThread.ManagedThreadId}"),
//    () => Console.WriteLine($"Data => [{data2[2]}] on thread:-{Thread.CurrentThread.ManagedThreadId}"),
//    () => Console.WriteLine($"Data => [{data2[3]}] on thread:-{Thread.CurrentThread.ManagedThreadId}"),
//    () => Console.WriteLine($"Data => [{data2[4]}] on thread:-{Thread.CurrentThread.ManagedThreadId}")
//);
//Console.WriteLine();

//Console.WriteLine("Error Handling");
List<string> data = ["Apple", "Banana", "Grapes", "Orange", "Strawberry"];
Task task = Task.Run(() =>
{
    if (data.Contains("Banana"))
    {
        throw new InvalidOperationException("Error: data list contains the word \"Banana\"");
    }
});

try
{
    task.Wait();
}
catch (AggregateException ex)
{
    Console.WriteLine($"Handled exception: {ex.Message}");
}

Console.ReadLine();