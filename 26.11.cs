//1
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread t = new Thread(() => Console.WriteLine("Привет из потока"));
        t.Start();
        t.Join();
    }
}

//2
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread t1 = new Thread(() => Console.WriteLine("Поток 1"));
        Thread t2 = new Thread(() => Console.WriteLine("Поток 2"));

        t1.Start();
        t1.Join();
        t2.Start();
        t2.Join();
    }
}

//3
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}

//4
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread t1 = new Thread(() => { Thread.Sleep(1000); Console.WriteLine("Операция 1 завершена"); });
        Thread t2 = new Thread(() => { Thread.Sleep(2000); Console.WriteLine("Операция 2 завершена"); });
        Thread t3 = new Thread(() => { Thread.Sleep(3000); Console.WriteLine("Операция 3 завершена"); });

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
    }
}

//5
using System;
using System.Threading;

class Program
{
    static void Worker(object data)
    {
        Console.WriteLine($"Получено: {data}");
    }

    static void Main()
    {
        ParameterizedThreadStart ps = new ParameterizedThreadStart(Worker);
        Thread t = new Thread(ps);
        t.Start("Привет от параметра");
        t.Join();
    }
}

//6
using System;
using System.Threading;

class Program
{
    static void Work()
    {
        for (int i = 0; i < 5; i++)
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
    }

    static void Main()
    {
        Thread t1 = new Thread(Work);
        Thread t2 = new Thread(Work);

        t1.Priority = ThreadPriority.Highest;
        t2.Priority = ThreadPriority.Lowest;

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
    }
}

//7
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread t = new Thread(() =>
        {
            Console.WriteLine("Поток начал работу");
            Thread.Sleep(1000);
            Console.WriteLine("Поток проснулся и завершился");
        });
        t.Start();
        t.Join();
    }
}

//8
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread bg = new Thread(() => Console.WriteLine("Фоновый поток"));
        bg.IsBackground = true;
        bg.Start();

        Console.WriteLine("Главный поток завершился");
    }
}

//9
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine(Thread.CurrentThread.Name ?? "Имя не задано");
        Thread.CurrentThread.Name = "Главный";
        Console.WriteLine(Thread.CurrentThread.Name);
    }
}

//10
using System;
using System.Threading;

class Program
{
    static readonly object lockObj = new object();

    static void Print(string msg)
    {
        lock (lockObj)
        {
            Console.WriteLine(msg);
            Thread.Sleep(100);
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(() => Print("Поток 1"));
        Thread t2 = new Thread(() => Print("Поток 2"));
        Thread t3 = new Thread(() => Print("Поток 3"));

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
    }
}

//11
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task.Run(() => Console.WriteLine("Задача выполнена через Task.Run"));
    }
}

//12
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task t = Task.Run(() => Console.WriteLine("Работаем..."));
        t.Wait();
        Console.WriteLine("Задача завершена");
    }
}

//13
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task<int> task = Task.Run(() => 42);
        Console.WriteLine(task.Result);
    }
}

//14
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task t1 = Task.Run(() => Console.WriteLine("Task 1"));
        Task t2 = Task.Run(() => Console.WriteLine("Task 2"));
        Task t3 = Task.Run(() => Console.WriteLine("Task 3"));

        Task.WaitAll(t1, t2, t3);
        Console.WriteLine("Все задачи завершены");
    }
}

//15
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task t1 = Task.Delay(1000);
        Task t2 = Task.Delay(2000);
        Task t3 = Task.Delay(1500);

        await Task.WhenAll(t1, t2, t3);
        Console.WriteLine("Все задачи завершены асинхронно");
    }
}

//16
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task.Run(() => Console.WriteLine("Шаг 1"))
            .ContinueWith(t => Console.WriteLine("Шаг 2"))
            .ContinueWith(t => Console.WriteLine("Шаг 3"))
            .Wait();
    }
}

//17
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task t1 = Task.Delay(3000);
        Task t2 = Task.Delay(1000);
        Task t3 = Task.Delay(2000);

        int index = Task.WaitAny(t1, t2, t3);
        Console.WriteLine($"Сначала завершилась задача №{index + 1}");
    }
}

//18
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task<int> t1 = Task.Delay(3000).ContinueWith(_ => 1);
        Task<int> t2 = Task.Delay(1000).ContinueWith(_ => 2);
        Task<int> t3 = Task.Delay(2000).ContinueWith(_ => 3);

        Task<int> first = await Task.WhenAny(t1, t2, t3);
        Console.WriteLine($"Первым завершился с результатом: {first.Result}");
    }
}

//19
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task = Task.Run(() => throw new InvalidOperationException("Ошибка в задаче"));

        try
        {
            task.Wait();
        }
        catch (AggregateException ae)
        {
            Console.WriteLine(ae.InnerException.Message);
        }
    }
}

//20
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var scheduler = TaskScheduler.FromCurrentSynchronizationContext();

        Task.Factory.StartNew(() => Console.WriteLine("Выполняется в пуле потоков"))
            .ContinueWith(t => Console.WriteLine("Выполняется в главном потоке (UI)"),
                          CancellationToken.None,
                          TaskContinuationOptions.None,
                          scheduler);

        Console.ReadLine();
    }
}

//21
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await DoWorkAsync();
    }

    static async Task DoWorkAsync()
    {
        Console.WriteLine("Начало асинхронной работы");
        await Task.Delay(1000);
        Console.WriteLine("Конец асинхронной работы");
    }
}

//22
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Перед await");
        await Task.Delay(1000);
        Console.WriteLine("После await");
    }
}

//23
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        int result = await GetNumberAsync();
        Console.WriteLine($"Результат: {result}");
    }

    static async Task<int> GetNumberAsync()
    {
        await Task.Delay(500);
        return 100;
    }
}

//24
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Начало");
        await Task.Delay(2000);
        Console.WriteLine("Прошло 2 секунды асинхронно");
    }
}

//25
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        try
        {
            await FailingMethodAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static async Task FailingMethodAsync()
    {
        await Task.Delay(100);
        throw new InvalidOperationException("Что-то пошло не так");
    }
}

//26
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await LibraryMethodAsync().ConfigureAwait(false);
        Console.WriteLine("Продолжение без захвата контекста");
    }

    static async Task LibraryMethodAsync()
    {
        await Task.Delay(100).ConfigureAwait(false);
    }
}

//27
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Шаг 1");
        await Step1Async();
        Console.WriteLine("Шаг 2");
        await Step2Async();
        Console.WriteLine("Шаг 3");
        await Step3Async();
        Console.WriteLine("Готово");
    }

    static async Task Step1Async() => await Task.Delay(500);
    static async Task Step2Async() => await Task.Delay(300);
    static async Task Step3Async() => await Task.Delay(700);
}

//28
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var button = new { Click = (Action)(async () => await ButtonClickHandlerAsync()) };
        button.Click();
        Console.ReadLine();
    }

    static async void ButtonClickHandlerAsync()
    {
        await Task.Delay(1000);
        Console.WriteLine("Кнопка нажата асинхронно");
    }
}

//29
using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string text = await ReadFileAsync("data.txt");
        Console.WriteLine(text);
    }

    static async Task<string> ReadFileAsync(string path)
    {
        return await Task.Run(() => File.ReadAllText(path));
    }
}

//30
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        int cached = await GetCachedValueAsync();
        Console.WriteLine($"Кэшированное значение: {cached}");
    }

    static Task<int> GetCachedValueAsync()
    {
        return Task.FromResult(777);
    }
}

//31
using System;
using System.Threading;

class Program
{
    static object _lock = new object();
    static int counter = 0;

    static void Main()
    {
        Thread[] threads = new Thread[10];
        for (int i = 0; i < 10; i++)
            threads[i] = new Thread(Increment);
        foreach (var t in threads) t.Start();
        foreach (var t in threads) t.Join();
        Console.WriteLine(counter); 
    }

    static void Increment()
    {
        for (int i = 0; i < 100; i++)
        {
            lock (_lock)
                counter++;
        }
    }
}

//32
using System;
using System.Threading;

class Program
{
    static readonly object _lock = new();
    static int count = 0;

    static void Main()
    {
        Thread t1 = new Thread(() => { for (int i = 0; i < 100000; i++) { lock (_lock) count++; } });
        Thread t2 = new Thread(() => { for (int i = 0; i < 100000; i++) { lock (_lock) count--; } });
        t1.Start(); t2.Start(); t1.Join(); t2.Join();
        Console.WriteLine(count); 
    }
}

//33
using System;
using System.Threading;

class Program
{
    static object lock1 = new();
    static object lock2 = new();

    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            lock (lock1)
            {
                Thread.Sleep(100);
                lock (lock2) { Console.WriteLine("t1"); }
            }
        });

        Thread t2 = new Thread(() =>
        {
            lock (lock2)
            {
                Thread.Sleep(100);
                lock (lock1) { Console.WriteLine("t2"); }
            }
        });

        t1.Start(); t2.Start();
        t1.Join(); t2.Join();
        Console.WriteLine("Deadlock!");
    }
}

//34
using System;
using System.Threading;

class Program
{
    static object lock1 = new();
    static object lock2 = new();

    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            lock (lock1)
                lock (lock2)
                    Console.WriteLine("t1 захватил оба");
        });

        Thread t2 = new Thread(() =>
        {
            lock (lock1)
                lock (lock2)
                    Console.WriteLine("t2 захватил оба");
        });

        t1.Start(); t2.Start(); t1.Join(); t2.Join();
        Console.WriteLine("Deadlock избежали — одинаковый порядок");
    }
}

//35
using System;
using System.Threading;

class Program
{
    static object lockA = new();
    static object lockB = new();
    static int a = 0, b = 0;

    static void Main()
    {
        Thread[] threads = new Thread[8];
        for (int i = 0; i < 8; i++)
        {
            int n = i;
            threads[i] = new Thread(() =>
            {
                if (n % 2 == 0) { lock (lockA) a++; }
                else { lock (lockB) b++; }
            });
            threads[i].Start();
        }
        foreach (var t in threads) t.Join();
        Console.WriteLine($"a={a} b={b}");
    }
}

//36
using System;
using System.Threading;

class Counter
{
    private int _value;
    private readonly object _lock = new();

    public void Increment() { lock (_lock) _value++; }
    public void Decrement() { lock (_lock) _value--; }
    public int Value => _value;
}

class Program
{
    static void Main()
    {
        var c = new Counter();
        Thread[] threads = new Thread[10];
        for (int i = 0; i < 10; i++)
            threads[i] = new Thread(() => { for (int j = 0; j < 1000; j++) c.Increment(); });
        foreach (var t in threads) t.Start();
        foreach (var t in threads) t.Join();
        Console.WriteLine(c.Value);
    }
}

//37
using System;
using System.Threading;

class Program
{
    static ReaderWriterLockSlim rw = new();
    static int value = 0;

    static void Main()
    {
        Thread writer = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                rw.EnterWriteLock();
                value++;
                Console.WriteLine($"Write: {value}");
                rw.ExitWriteLock();
                Thread.Sleep(100);
            }
        });

        Thread[] readers = new Thread[3];
        for (int i = 0; i < 3; i++)
        {
            readers[i] = new Thread(() =>
            {
                while (true)
                {
                    rw.EnterReadLock();
                    Console.WriteLine($"Read: {value}");
                    rw.ExitReadLock();
                    Thread.Sleep(50);
                }
            });
            readers[i].IsBackground = true;
            readers[i].Start();
        }

        writer.Start();
        Thread.Sleep(2000);
    }
}

//38
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static object lck = new();
    static int counter = 0;

    static void Main()
    {
        var sw = Stopwatch.StartNew();
        Thread[] threads = new Thread[10];
        for (int i = 0; i < 10; i++)
            threads[i] = new Thread(() => { for (int j = 0; j < 100000; j++) { lock (lck) counter++; } });
        foreach (var t in threads) t.Start();
        foreach (var t in threads) t.Join();
        sw.Stop();
        Console.WriteLine($"lock: {sw.ElapsedMilliseconds} мс");
    }
}

//39
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static List<int> list = new();
    static object _lock = new();

    static void Main()
    {
        Thread[] threads = new Thread[10];
        for (int i = 0; i < 10; i++)
        {
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 100; j++)
                {
                    lock (_lock)
                        list.Add(j);
                }
            });
            threads[i].Start();
        }
        foreach (var t in threads) t.Join();
        Console.WriteLine(list.Count); 
    }
}

//40
using System;
using System.Threading;

class ReadersWriters
{
    static int value = 0;
    static int readers = 0;
    static object lockReaders = new();
    static object lockResource = new();

    static void Reader()
    {
        while (true)
        {
            lock (lockReaders)
            {
                readers++;
                if (readers == 1) Monitor.Enter(lockResource);
            }
            Console.WriteLine($"Read: {value}");
            lock (lockReaders)
            {
                readers--;
                if (readers == 0) Monitor.Exit(lockResource);
            }
            Thread.Sleep(100);
        }
    }

    static void Writer()
    {
        while (true)
        {
            Monitor.Enter(lockResource);
            value++;
            Console.WriteLine($"Write: {value}");
            Monitor.Exit(lockResource);
            Thread.Sleep(1000);
        }
    }

    static void Main()
    {
        new Thread(Writer) { IsBackground = true }.Start();
        for (int i = 0; i < 5; i++)
            new Thread(Reader) { IsBackground = true }.Start();
        Thread.Sleep(5000);
    }
}

//41
using System;
using System.Threading;

class Program
{
    static Mutex mutex = new Mutex();

    static void Main()
    {
        for (int i = 0; i < 5; i++)
            new Thread(Work).Start();

        Console.ReadLine();
    }

    static void Work()
    {
        mutex.WaitOne();
        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} вошёл");
        Thread.Sleep(1000);
        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} вышел");
        mutex.ReleaseMutex();
    }
}

//42
using System;
using System.Threading;

class Program
{
    static Mutex mutex = new Mutex();

    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            if (mutex.WaitOne(500))
            {
                Console.WriteLine("Получил мьютекс");
                Thread.Sleep(2000);
                mutex.ReleaseMutex();
            }
            else Console.WriteLine("Таймаут");
        });
        t1.Start();
        t1.Join();
    }
}

//43
using System;
using System.Threading;

class Program
{
    static Semaphore sem = new Semaphore(3, 3);

    static void Main()
    {
        for (int i = 0; i < 10; i++)
            new Thread(AccessResource).Start();

        Console.ReadLine();
    }

    static void AccessResource()
    {
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} ждёт...");
        sem.WaitOne();
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} вошёл");
        Thread.Sleep(1000);
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} вышел");
        sem.Release();
    }
}

//44
using System;
using System.Threading;

class Program
{
    static Semaphore pool = new Semaphore(2, 2);

    static void UseResource(object id)
    {
        pool.WaitOne();
        Console.WriteLine($"Ресурс используется потоком {id}");
        Thread.Sleep(2000);
        Console.WriteLine($"Ресурс освобождён потоком {id}");
        pool.Release();
    }

    static void Main()
    {
        for (int i = 1; i <= 6; i++)
            new Thread(UseResource).Start(i);

        Console.ReadLine();
    }
}

//45
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static SemaphoreSlim sem = new SemaphoreSlim(3);

    static async Task AccessAsync()
    {
        await sem.WaitAsync();
        try
        {
            Console.WriteLine($"Вошёл {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(1000);
        }
        finally
        {
            sem.Release();
        }
    }

    static async Task Main()
    {
        var tasks = new Task[10];
        for (int i = 0; i < 10; i++)
            tasks[i] = AccessAsync();
        await Task.WhenAll(tasks);
    }
}

//46
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Mutex m = new Mutex();
        Thread t = new Thread(() =>
        {
            m.WaitOne();
        });
        t.Start();
        t.Join();

        try
        {
            m.WaitOne();
            Console.WriteLine("Получил мьютекс после abandoned");
            m.ReleaseMutex();
        }
        catch (AbandonedMutexException)
        {
            Console.WriteLine("Получен abandoned mutex");
            m.ReleaseMutex();
        }
    }
}

//47
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        bool createdNew;
        using var mutex = new Mutex(false, "Global\\MyAppMutex", out createdNew);

        if (!createdNew)
        {
            Console.WriteLine("Приложение уже запущено!");
            return;
        }

        Console.WriteLine("Приложение запущено (единственный экземпляр)");
        Console.ReadLine();
    }
}

//48
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static object _lock = new();
    static Mutex mutex = new Mutex();
    static int counter = 0;

    static void Main()
    {
        var sw = Stopwatch.StartNew();
        Thread[] threads = new Thread[10];

        for (int i = 0; i < 10; i++)
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 100000; j++)
                {
                    lock (_lock) counter++;
                }
            });
        foreach (var t in threads) t.Start();
        foreach (var t in threads) t.Join();
        sw.Stop();
        Console.WriteLine($"lock: {sw.ElapsedMilliseconds} мс");

        sw.Restart();
        counter = 0;
        for (int i = 0; i < 10; i++)
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 100000; j++)
                {
                    mutex.WaitOne();
                    counter++;
                    mutex.ReleaseMutex();
                }
            });
        foreach (var t in threads) t.Start();
        foreach (var t in threads) t.Join();
        Console.WriteLine($"Mutex: {sw.ElapsedMilliseconds} мс");
    }
}

//49
using System;
using System.Threading;

class Program
{
    static CountdownEvent cde = new CountdownEvent(5);

    static void Worker()
    {
        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} выполняет работу");
        Thread.Sleep(1000);
        cde.Signal();
    }

    static void Main()
    {
        for (int i = 0; i < 5; i++)
            new Thread(Worker).Start();

        Console.WriteLine("Ожидаю завершения всех...");
        cde.Wait();
        Console.WriteLine("Все потоки завершили работу");
    }
}

//50
using System;
using System.Threading;

class Program
{
    static ManualResetEvent mre = new ManualResetEvent(false);

    static void Worker()
    {
        Console.WriteLine("Поток ждёт сигнала...");
        mre.WaitOne();
        Console.WriteLine("Сигнал получен, продолжаем");
    }

    static void Main()
    {
        new Thread(Worker).Start();

        Thread.Sleep(2000);
        Console.WriteLine("Посылаю сигнал...");
        mre.Set();

        Console.ReadLine();
    }
}

//51
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        Thread thread = new Thread(() =>
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine("Работаю...");
                Thread.Sleep(500);
            }
            Console.WriteLine("Поток остановлен.");
        });

        thread.Start();
        Console.ReadLine(); // Ждём нажатия Enter
        cts.Cancel(); // Отменяем операцию
    }
}

//52
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        Task longRunningTask = Task.Run(async () =>
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine("Выполняю задачу...");
                await Task.Delay(500, token);
            }
            Console.WriteLine("Задача отменена.");
        }, token);

        Console.ReadLine(); // Ждём нажатия Enter
        cts.Cancel(); // Отменяем задачу
        await longRunningTask;
    }
}

//53
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        Task task = Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                token.ThrowIfCancellationRequested(); // Проверяем отмену
                Console.WriteLine($"Шаг {i}");
                Thread.Sleep(500);
            }
        });

        Console.ReadLine(); // Ждём нажатия Enter
        cts.Cancel(); // Отменяем задачу
        try
        {
            await task;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Задача отменена!");
        }
    }
}

//54
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(3)); // Тайм-аут 3 секунды
        var token = cts.Token;

        Task task = Task.Run(async () =>
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine("Работаю...");
                await Task.Delay(500, token);
            }
            Console.WriteLine("Задача отменена по тайм-ауту.");
        });

        try
        {
            await task;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Задача отменена!");
        }
    }
}

//55
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        Task task = Task.Run(() =>
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine("Работаю...");
                Thread.Sleep(500);
            }
            token.ThrowIfCancellationRequested();
        });

        Console.ReadLine(); // Ждём нажатия Enter
        cts.Cancel(); // Отменяем задачу

        try
        {
            await task;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Задача успешно отменена!");
        }
    }
}

//56
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        token.Register(() =>
        {
            Console.WriteLine("Отмена зарегистрирована! Выполняю очистку.");
        });

        Thread thread = new Thread(() =>
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine("Работаю...");
                Thread.Sleep(500);
            }
        });

        thread.Start();
        Console.ReadLine(); // Ждём нажатия Enter
        cts.Cancel(); // Отменяем операцию
    }
}

//57
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        Task task = Task.Run(async () =>
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine("Работаю...");
                await Task.Delay(500, token); // Передаём токен в Task.Delay
            }
            Console.WriteLine("Задача отменена.");
        });

        Console.ReadLine(); // Ждём нажатия Enter
        cts.Cancel(); // Отменяем задачу
        await task;
    }
}

//58
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        Task appTask = Task.Run(async () =>
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine("Приложение работает...");
                await Task.Delay(500, token);
            }
            Console.WriteLine("Плавное завершение работы...");
            await Task.Delay(1000); // Имитация очистки ресурсов
            Console.WriteLine("Приложение завершено.");
        });

        Console.ReadLine(); // Ждём нажатия Enter
        cts.Cancel(); // Инициируем завершение
        await appTask;
    }
}

//59
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        ThreadPool.QueueUserWorkItem(WorkItem, "Привет из пула потоков!");

        Console.ReadLine(); // Ждём завершения работы
    }

    static void WorkItem(object state)
    {
        Console.WriteLine(state);
        Thread.Sleep(1000); // Имитация работы
        Console.WriteLine("Работа завершена.");
    }
}

//60
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        ThreadPool.GetAvailableThreads(out int workerThreads, out int completionPortThreads);
        ThreadPool.GetMaxThreads(out int maxWorkerThreads, out int maxCompletionPortThreads);
        ThreadPool.GetMinThreads(out int minWorkerThreads, out int minCompletionPortThreads);

        Console.WriteLine($"Доступные рабочие потоки: {workerThreads}");
        Console.WriteLine($"Доступные потоки завершения: {completionPortThreads}");
        Console.WriteLine($"Максимальные рабочие потоки: {maxWorkerThreads}");
        Console.WriteLine($"Минимальные рабочие потоки: {minWorkerThreads}");
    }
}

//61
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        ThreadPool.GetMinThreads(out int minWorkerThreads, out int minCompletionPortThreads);
        ThreadPool.GetMaxThreads(out int maxWorkerThreads, out int maxCompletionPortThreads);

        Console.WriteLine($"Текущие минимальные потоки: {minWorkerThreads}, {minCompletionPortThreads}");
        Console.WriteLine($"Текущие максимальные потоки: {maxWorkerThreads}, {maxCompletionPortThreads}");

        // Устанавливаем новые значения
        ThreadPool.SetMinThreads(4, 4);
        ThreadPool.SetMaxThreads(16, 16);

        ThreadPool.GetMinThreads(out minWorkerThreads, out minCompletionPortThreads);
        ThreadPool.GetMaxThreads(out maxWorkerThreads, out maxCompletionPortThreads);

        Console.WriteLine($"Новые минимальные потоки: {minWorkerThreads}, {minCompletionPortThreads}");
        Console.WriteLine($"Новые максимальные потоки: {maxWorkerThreads}, {maxCompletionPortThreads}");
    }
}

//62
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        using (var eventObj = new ManualResetEvent(false))
        {
            RegisteredWaitHandle handle = ThreadPool.RegisterWaitForSingleObject(
                eventObj,
                (state, timedOut) => Console.WriteLine("Событие произошло!"),
                null,
                Timeout.Infinite,
                true);

            ThreadPool.QueueUserWorkItem(_ =>
            {
                Thread.Sleep(2000);
                eventObj.Set(); // Сигнализируем событие
            });

            Console.ReadLine(); // Ждём завершения
            handle.Unregister(null); // Отменяем ожидание
        }
    }
}

//63
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Использование ThreadPool
        ThreadPool.QueueUserWorkItem(_ =>
        {
            Console.WriteLine("Работа в ThreadPool");
            Thread.Sleep(1000);
        });

        // Использование Task
        Task.Run(() =>
        {
            Console.WriteLine("Работа в Task");
            Thread.Sleep(1000);
        });

        Console.ReadLine(); // Ждём завершения
    }
}

//64
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        ThreadPool.GetAvailableThreads(out int workerThreads, out int completionPortThreads);
        Console.WriteLine($"Доступные рабочие потоки: {workerThreads}");
        Console.WriteLine($"Доступные потоки завершения: {completionPortThreads}");
    }
}

//65
using System;
using System.Collections.Concurrent;
using System.Threading;

class Program
{
    static void Main()
    {
        var taskQueue = new ConcurrentQueue<Action>();
        for (int i = 0; i < 10; i++)
        {
            int taskId = i;
            taskQueue.Enqueue(() =>
            {
                Console.WriteLine($"Выполняю задачу {taskId}");
                Thread.Sleep(500);
            });
        }

        while (taskQueue.TryDequeue(out var task))
        {
            ThreadPool.QueueUserWorkItem(_ => task());
        }

        Console.ReadLine(); // Ждём завершения
    }
}

//66
using System;
using System.Net.Sockets;
using System.Threading;

class Program
{
    static void Main()
    {
        var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Bind(new System.Net.IPEndPoint(System.Net.IPAddress.Any, 8080));
        socket.Listen(10);

        // Регистрируем сокет в IOCP
        ThreadPool.BindHandle(socket.SafeHandle);

        socket.BeginAccept(AcceptCallback, socket);

        Console.ReadLine(); // Ждём завершения
    }

    static void AcceptCallback(IAsyncResult ar)
    {
        var socket = (Socket)ar.AsyncState;
        var clientSocket = socket.EndAccept(ar);

        Console.WriteLine("Новое подключение!");
        clientSocket.Close();

        socket.BeginAccept(AcceptCallback, socket); // Продолжаем слушать
    }
}

//67
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Parallel.For(0, 10, i =>
        {
            Console.WriteLine($"Итерация {i} выполняется в потоке {Task.CurrentId}");
            // Имитация работы
            Task.Delay(100).Wait();
        });
    }
}

//68
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Parallel.ForEach(numbers, number =>
        {
            Console.WriteLine($"Обработка числа {number} в потоке {Task.CurrentId}");
            // Имитация работы
            Task.Delay(100).Wait();
        });
    }
}

//69
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Parallel.Invoke(
            () => Task1(),
            () => Task2(),
            () => Task3()
        );
    }

    static void Task1()
    {
        Console.WriteLine("Задача 1 выполняется в потоке " + Task.CurrentId);
        Task.Delay(1000).Wait();
    }

    static void Task2()
    {
        Console.WriteLine("Задача 2 выполняется в потоке " + Task.CurrentId);
        Task.Delay(500).Wait();
    }

    static void Task3()
    {
        Console.WriteLine("Задача 3 выполняется в потоке " + Task.CurrentId);
        Task.Delay(1500).Wait();
    }
}

//70
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var options = new ParallelOptions { MaxDegreeOfParallelism = 2 };

        Parallel.For(0, 10, options, i =>
        {
            Console.WriteLine($"Итерация {i} выполняется в потоке {Task.CurrentId}");
            Task.Delay(100).Wait();
        });
    }
}

//71
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        try
        {
            Parallel.For(0, 10, new ParallelOptions { CancellationToken = token }, (i, state) =>
            {
                if (token.IsCancellationRequested)
                    state.Stop();

                Console.WriteLine($"Итерация {i} выполняется в потоке {Task.CurrentId}");
                Task.Delay(100).Wait();
            });
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Операция отменена!");
        }

        cts.Cancel();
    }
}

//72
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var numbers = new int[1000];
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = i;

        var partitioner = Partitioner.Create(0, numbers.Length);

        Parallel.ForEach(partitions: partitioner, range =>
        {
            for (int i = range.Item1; i < range.Item2; i++)
            {
                Console.WriteLine($"Обработка числа {numbers[i]} в потоке {Task.CurrentId}");
                Task.Delay(1).Wait();
            }
        });
    }
}

//73
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        try
        {
            Parallel.For(0, 10, new ParallelOptions { CancellationToken = token }, (i, state) =>
            {
                if (token.IsCancellationRequested)
                    state.Stop();

                Console.WriteLine($"Итерация {i} выполняется в потоке {Task.CurrentId}");
                Task.Delay(100).Wait();
            });
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Операция успешно отменена!");
        }

        cts.Cancel();
    }
}

//74
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = SumArray(array, 0, array.Length - 1);
        Console.WriteLine($"Сумма элементов массива: {sum}");
    }

    static int SumArray(int[] array, int start, int end)
    {
        if (start == end)
            return array[start];

        int mid = (start + end) / 2;
        int leftSum = 0, rightSum = 0;

        Parallel.Invoke(
            () => leftSum = SumArray(array, start, mid),
            () => rightSum = SumArray(array, mid + 1, end)
        );

        return leftSum + rightSum;
    }
}

//75
using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] data = new int[1000000];
        for (int i = 0; i < data.Length; i++)
            data[i] = i;

        var stopwatch = Stopwatch.StartNew();
        long sumSequential = 0;
        for (int i = 0; i < data.Length; i++)
            sumSequential += data[i];
        stopwatch.Stop();
        Console.WriteLine($"Последовательный цикл: {stopwatch.ElapsedMilliseconds} мс");

        stopwatch.Restart();
        long sumParallel = 0;
        Parallel.For(0, data.Length, i =>
        {
            lock (data)
                sumParallel += data[i];
        });
        stopwatch.Stop();
        Console.WriteLine($"Параллельный цикл: {stopwatch.ElapsedMilliseconds} мс");
    }
}

//76
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var options = new ParallelOptions
        {
            MaxDegreeOfParallelism = 2,
            CancellationToken = new CancellationTokenSource().Token
        };

        try
        {
            Parallel.For(0, 10, options, (i, state) =>
            {
                Console.WriteLine($"Итерация {i} выполняется в потоке {Task.CurrentId}");
                Task.Delay(100).Wait();
            });
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Операция отменена!");
        }
    }
}

//77
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 1000);

        var result = numbers
            .AsParallel() // Преобразуем в параллельный запрос
            .Where(n => n % 2 == 0)
            .Select(n => n * 2)
            .ToList();

        Console.WriteLine($"Результатов: {result.Count}");
    }
}

//78
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 1000);

        var result = numbers
            .AsParallel()
            .WithDegreeOfParallelism(4) // Ограничиваем количество потоков
            .Where(n => n % 2 == 0)
            .Select(n => n * 2)
            .ToList();

        Console.WriteLine($"Результатов: {result.Count}");
    }
}

//79
using System;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        var numbers = Enumerable.Range(1, 1000000);

        try
        {
            var result = numbers
                .AsParallel()
                .WithCancellation(token) // Передаём токен отмены
                .Where(n => n % 2 == 0)
                .Select(n => n * 2)
                .ToList();

            Console.WriteLine($"Результатов: {result.Count}");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Запрос отменён!");
        }

        cts.Cancel(); // Отменяем запрос
    }
}

//80
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 1000);

        var result = numbers
            .AsParallel()
            .Where(n => n % 2 == 0)
            .Select(n => n * 2)
            .OrderBy(n => n) // Параллельная сортировка
            .ToList();

        Console.WriteLine($"Результатов: {result.Count}");
    }
}

//81
using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 1000000);

        var stopwatch = Stopwatch.StartNew();
        var linqResult = numbers
            .Where(n => n % 2 == 0)
            .Select(n => n * 2)
            .ToList();
        stopwatch.Stop();
        Console.WriteLine($"LINQ: {stopwatch.ElapsedMilliseconds} мс");

        stopwatch.Restart();
        var plinqResult = numbers
            .AsParallel()
            .Where(n => n % 2 == 0)
            .Select(n => n * 2)
            .ToList();
        stopwatch.Stop();
        Console.WriteLine($"PLINQ: {stopwatch.ElapsedMilliseconds} мс");
    }
}

//82
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 1000);

        var result = numbers
            .AsParallel()
            .Where(n => n % 2 == 0)
            .Select(n => n * 2)
            .ToList(); // Материализуем результаты

        Console.WriteLine($"Результатов: {result.Count}");
    }
}

//83
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var concurrentDict = new ConcurrentDictionary<int, string>();

        Parallel.For(0, 10, i =>
        {
            concurrentDict.TryAdd(i, $"Значение {i}");
        });

        foreach (var kvp in concurrentDict)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}

//84
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var queue = new ConcurrentQueue<int>();

        // Производитель
        Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
                Console.WriteLine($"Добавлено: {i}");
            }
        });

        // Потребитель
        Task.Run(() =>
        {
            while (queue.TryDequeue(out int item))
            {
                Console.WriteLine($"Обработано: {item}");
            }
        }).Wait();
    }
}

//85
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var bag = new ConcurrentBag<int>();

        Parallel.For(0, 10, i =>
        {
            bag.Add(i);
        });

        foreach (var item in bag)
            Console.WriteLine(item);
    }
}

//86
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var blockingCollection = new BlockingCollection<int>(boundedCapacity: 5);

        // Производитель
        Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                blockingCollection.Add(i);
                Console.WriteLine($"Добавлено: {i}");
            }
            blockingCollection.CompleteAdding();
        });

        // Потребитель
        Task.Run(() =>
        {
            foreach (var item in blockingCollection.GetConsumingEnumerable())
            {
                Console.WriteLine($"Обработано: {item}");
            }
        }).Wait();
    }
}

//87
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var blockingCollection = new BlockingCollection<int>(boundedCapacity: 5);
        var cts = new CancellationTokenSource();

        // Производитель
        Task producer = Task.Run(() =>
        {
            for (int i = 0; i < 20; i++)
            {
                blockingCollection.Add(i);
                Console.WriteLine($"Производитель добавил: {i}");
                Thread.Sleep(100);
            }
            blockingCollection.CompleteAdding();
        });

        // Потребитель
        Task consumer = Task.Run(() =>
        {
            foreach (var item in blockingCollection.GetConsumingEnumerable(cts.Token))
            {
                Console.WriteLine($"Потребитель обработал: {item}");
                Thread.Sleep(200);
            }
        });

        Task.WaitAll(producer, consumer);
    }
}

//88
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var stack = new ConcurrentStack<int>();

        Parallel.For(0, 10, i =>
        {
            stack.Push(i);
        });

        while (stack.TryPop(out int item))
            Console.WriteLine(item);
    }
}

//89
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var concurrentDict = new ConcurrentDictionary<int, int>();
        var concurrentQueue = new ConcurrentQueue<int>();
        var concurrentBag = new ConcurrentBag<int>();
        var blockingCollection = new BlockingCollection<int>();

        var sw = Stopwatch.StartNew();
        Parallel.For(0, 10000, i => concurrentDict.TryAdd(i, i));
        sw.Stop();
        Console.WriteLine($"ConcurrentDictionary: {sw.ElapsedMilliseconds} мс");

        sw.Restart();
        Parallel.For(0, 10000, i => concurrentQueue.Enqueue(i));
        sw.Stop();
        Console.WriteLine($"ConcurrentQueue: {sw.ElapsedMilliseconds} мс");

        sw.Restart();
        Parallel.For(0, 10000, i => concurrentBag.Add(i));
        sw.Stop();
        Console.WriteLine($"ConcurrentBag: {sw.ElapsedMilliseconds} мс");

        sw.Restart();
        Parallel.For(0, 10000, i => blockingCollection.Add(i));
        sw.Stop();
        Console.WriteLine($"BlockingCollection: {sw.ElapsedMilliseconds} мс");
    }
}

//90
using System;
using System.Collections.Concurrent;

class Program
{
    static void Main()
    {
        var dict = new ConcurrentDictionary<int, string>();

        // Добавление
        bool added = dict.TryAdd(1, "Первый");
        Console.WriteLine($"Добавлено: {added}");

        // Удаление
        bool removed = dict.TryRemove(1, out string value);
        Console.WriteLine($"Удалено: {removed}, значение: {value}");
    }
}

//91
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private static int _counter = 0;

    static void Main()
    {
        Parallel.For(0, 100, _ =>
        {
            Interlocked.Increment(ref _counter);
        });

        Console.WriteLine($"Значение счётчика: {_counter}");
    }
}

//92
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private static int _value = 0;

    static void Main()
    {
        Parallel.For(0, 10, _ =>
        {
            int expected = 0;
            int newValue = 1;
            Interlocked.CompareExchange(ref _value, newValue, expected);
        });

        Console.WriteLine($"Значение: {_value}");
    }
}

//93
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private static int _counterInterlocked = 0;
    private static int _counterLock = 0;
    private static readonly object _lock = new object();

    static void Main()
    {
        var sw = Stopwatch.StartNew();
        Parallel.For(0, 1000000, _ => Interlocked.Increment(ref _counterInterlocked));
        sw.Stop();
        Console.WriteLine($"Interlocked: {sw.ElapsedMilliseconds} мс");

        sw.Restart();
        Parallel.For(0, 1000000, _ =>
        {
            lock (_lock)
            {
                _counterLock++;
            }
        });
        sw.Stop();
        Console.WriteLine($"Lock: {sw.ElapsedMilliseconds} мс");
    }
}

//94
using System;
using System.Threading;
using System.Threading.Tasks;

class SpinLock
{
    private int _locked = 0;

    public void Enter()
    {
        while (Interlocked.CompareExchange(ref _locked, 1, 0) != 0)
        {
            // Ожидание
        }
    }

    public void Exit()
    {
        Interlocked.Exchange(ref _locked, 0);
    }
}

class Program
{
    static void Main()
    {
        var spinLock = new SpinLock();
        int counter = 0;

        Parallel.For(0, 10000, _ =>
        {
            spinLock.Enter();
            counter++;
            spinLock.Exit();
        });

        Console.WriteLine($"Значение счётчика: {counter}");
    }
}

//95
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private static int _value = 0;

    static void Main()
    {
        Parallel.For(0, 10, _ =>
        {
            int currentValue = Interlocked.Read(ref _value);
            Console.WriteLine($"Текущее значение: {currentValue}");
        });
    }
}

//96
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private static int _value = 0;

    static void Main()
    {
        Parallel.For(0, 10, _ =>
        {
            int newValue = 1;
            int oldValue = Interlocked.Exchange(ref _value, newValue);
            Console.WriteLine($"Старое значение: {oldValue}, новое значение: {_value}");
        });
    }
}

//97
using System;
using System.Threading;

class Program
{
    private static AutoResetEvent _autoResetEvent = new AutoResetEvent(false);

    static void Main()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("Поток ожидает сигнал...");
            _autoResetEvent.WaitOne();
            Console.WriteLine("Поток получил сигнал!");
        });

        thread.Start();
        Thread.Sleep(1000);
        _autoResetEvent.Set(); // Сигнализируем потоку
    }
}

//98
using System;
using System.Threading;

class Program
{
    private static ManualResetEvent _manualResetEvent = new ManualResetEvent(false);

    static void Main()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("Поток ожидает сигнал...");
            _manualResetEvent.WaitOne();
            Console.WriteLine("Поток получил сигнал!");
        });

        thread.Start();
        Thread.Sleep(1000);
        _manualResetEvent.Set(); // Сигнализируем потоку
    }
}

//99
using System;
using System.Threading;

class Program
{
    private static AutoResetEvent _event1 = new AutoResetEvent(false);
    private static AutoResetEvent _event2 = new AutoResetEvent(false);

    static void Main()
    {
        Thread thread1 = new Thread(() =>
        {
            Thread.Sleep(1000);
            _event1.Set();
            Console.WriteLine("Событие 1 сигнализировано.");
        });

        Thread thread2 = new Thread(() =>
        {
            Thread.Sleep(2000);
            _event2.Set();
            Console.WriteLine("Событие 2 сигнализировано.");
        });

        thread1.Start();
        thread2.Start();

        WaitHandle.WaitAll(new WaitHandle[] { _event1, _event2 });
        Console.WriteLine("Оба события получены!");
    }
}

//100
using System;
using System.Threading;

class Program
{
    private static AutoResetEvent _readyEvent = new AutoResetEvent(false);
    private static int _item = 0;

    static void Main()
    {
        Thread producer = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                _item = i;
                Console.WriteLine($"Производитель создал элемент: {_item}");
                _readyEvent.Set();
                Thread.Sleep(500);
            }
        });

        Thread consumer = new Thread(() =>
        {
            while (true)
            {
                _readyEvent.WaitOne();
                Console.WriteLine($"Потребитель обработал элемент: {_item}");
            }
        });

        producer.Start();
        consumer.Start();
    }
}
