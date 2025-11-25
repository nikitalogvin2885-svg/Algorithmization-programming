//1
using System;
using System.ComponentModel;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Button button = new Button();
        button.Click += Button_Click;
        button.OnClick(); // Имитация клика
    }

    static void Button_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Кнопка нажата!");
    }
}

class Button
{
    public event EventHandler Click;

    public void OnClick()
    {
        Click?.Invoke(this, EventArgs.Empty);
    }
}

//2
using System;

class DataProvider
{
    public event EventHandler<DataReadyEventArgs> DataReady;

    public void FetchData()
    {
        // Имитация получения данных
        Console.WriteLine("Получение данных...");
        OnDataReady(new DataReadyEventArgs { Data = "Новые данные" });
    }

    protected virtual void OnDataReady(DataReadyEventArgs e)
    {
        DataReady?.Invoke(this, e);
    }
}

class DataReadyEventArgs : EventArgs
{
    public string Data { get; set; }
}

class Program
{
    static void Main()
    {
        DataProvider provider = new DataProvider();
        provider.DataReady += Provider_DataReady;
        provider.FetchData();
    }

    static void Provider_DataReady(object sender, DataReadyEventArgs e)
    {
        Console.WriteLine($"Данные получены: {e.Data}");
    }
}

//3
using System;

class Program
{
    public delegate void CustomEventHandler(string message);

    static void Main()
    {
        EventPublisher publisher = new EventPublisher();
        publisher.CustomEvent += message => Console.WriteLine($"Сообщение: {message}");
        publisher.RaiseEvent("Привет, мир!");
    }
}

class EventPublisher
{
    public event Program.CustomEventHandler CustomEvent;

    public void RaiseEvent(string message)
    {
        CustomEvent?.Invoke(message);
    }
}

//4
using System;

class Program
{
    static void Main()
    {
        Button button = new Button();
        EventHandler handler = (sender, e) => Console.WriteLine("Кнопка нажата!");
        button.Click += handler;
        button.OnClick();
        button.Click -= handler;
        button.OnClick(); // Событие не сработает
    }
}

class Button
{
    public event EventHandler Click;

    public void OnClick()
    {
        Click?.Invoke(this, EventArgs.Empty);
    }
}

//5
using System;
using System.ComponentModel;

class Observable : INotifyPropertyChanged
{
    private string _name;

    public event PropertyChangedEventHandler PropertyChanged;

    public string Name
    {
        get => _name;
        set
        {
            if (_name != value)
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

class Program
{
    static void Main()
    {
        Observable observable = new Observable();
        observable.PropertyChanged += (sender, e) =>
            Console.WriteLine($"Свойство {e.PropertyName} изменено!");
        observable.Name = "Новое имя";
    }
}

//6
using System;

class DataEventArgs : EventArgs
{
    public string Data { get; set; }
}

class DataSender
{
    public event EventHandler<DataEventArgs> DataSent;

    public void SendData(string data)
    {
        OnDataSent(new DataEventArgs { Data = data });
    }

    protected virtual void OnDataSent(DataEventArgs e)
    {
        DataSent?.Invoke(this, e);
    }
}

class Program
{
    static void Main()
    {
        DataSender sender = new DataSender();
        sender.DataSent += (s, e) => Console.WriteLine($"Получены данные: {e.Data}");
        sender.SendData("Привет!");
    }
}

//7
using System;

class EventSystem
{
    public event EventHandler<EventArgs> EventTriggered;

    public void TriggerEvent()
    {
        EventTriggered?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        EventSystem system = new EventSystem();
        system.EventTriggered += (sender, e) => Console.WriteLine("Событие сработало!");
        system.TriggerEvent();
    }
}

//8
using System;

class Button
{
    public event EventHandler<ClickEventArgs> Click;

    public void OnClick(int x, int y)
    {
        Click?.Invoke(this, new ClickEventArgs { X = x, Y = y });
    }
}

class ClickEventArgs : EventArgs
{
    public int X { get; set; }
    public int Y { get; set; }
}

class Program
{
    static void Main()
    {
        Button button = new Button();
        button.Click += (sender, e) => Console.WriteLine($"Клик по координатам: ({e.X}, {e.Y})");
        button.OnClick(10, 20);
    }
}

//9
using System;

class EmailService
{
    public event EventHandler<EmailEventArgs> EmailSent;

    public void SendEmail(string to, string subject)
    {
        Console.WriteLine($"Отправка письма на {to} с темой {subject}...");
        OnEmailSent(new EmailEventArgs { To = to, Subject = subject });
    }

    protected virtual void OnEmailSent(EmailEventArgs e)
    {
        EmailSent?.Invoke(this, e);
    }
}

class EmailEventArgs : EventArgs
{
    public string To { get; set; }
    public string Subject { get; set; }
}

class Program
{
    static void Main()
    {
        EmailService emailService = new EmailService();
        emailService.EmailSent += (sender, e) =>
            Console.WriteLine($"Письмо отправлено на {e.To} с темой {e.Subject}");
        emailService.SendEmail("user@example.com", "Привет!");
    }
}

//10
using System;

class EventChain
{
    public event EventHandler FirstEvent;
    public event EventHandler SecondEvent;

    public void TriggerFirst()
    {
        FirstEvent?.Invoke(this, EventArgs.Empty);
    }

    public void TriggerSecond()
    {
        SecondEvent?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        EventChain chain = new EventChain();
        chain.FirstEvent += (sender, e) =>
        {
            Console.WriteLine("Первое событие сработало!");
            (sender as EventChain)?.TriggerSecond();
        };
        chain.SecondEvent += (sender, e) => Console.WriteLine("Второе событие сработало!");
        chain.TriggerFirst();
    }
}

//11
using System;
using System.Collections.Generic;

class Logger
{
    private List<string> _logs = new List<string>();

    public event EventHandler<string> LogAdded;

    public void AddLog(string message)
    {
        _logs.Add(message);
        OnLogAdded(message);
    }

    protected virtual void OnLogAdded(string message)
    {
        LogAdded?.Invoke(this, message);
    }
}

class Program
{
    static void Main()
    {
        Logger logger = new Logger();
        logger.LogAdded += (sender, message) => Console.WriteLine($"Лог: {message}");
        logger.AddLog("Операция выполнена");
    }
}

//12
using System;

class ExceptionHandler
{
    public event EventHandler<ExceptionEventArgs> ExceptionOccurred;

    public void DoRiskyOperation()
    {
        try
        {
            throw new InvalidOperationException("Ошибка!");
        }
        catch (Exception ex)
        {
            OnExceptionOccurred(new ExceptionEventArgs { Exception = ex });
        }
    }

    protected virtual void OnExceptionOccurred(ExceptionEventArgs e)
    {
        ExceptionOccurred?.Invoke(this, e);
    }
}

class ExceptionEventArgs : EventArgs
{
    public Exception Exception { get; set; }
}

class Program
{
    static void Main()
    {
        ExceptionHandler handler = new ExceptionHandler();
        handler.ExceptionOccurred += (sender, e) =>
            Console.WriteLine($"Исключение: {e.Exception.Message}");
        handler.DoRiskyOperation();
    }
}

//13
using System;
using System.Timers;

class TimerExample
{
    private Timer _timer;

    public event EventHandler TimerElapsed;

    public TimerExample()
    {
        _timer = new Timer(1000);
        _timer.Elapsed += (sender, e) => OnTimerElapsed();
        _timer.Start();
    }

    protected virtual void OnTimerElapsed()
    {
        TimerElapsed?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        TimerExample timer = new TimerExample();
        timer.TimerElapsed += (sender, e) => Console.WriteLine("Таймер сработал!");
        Console.ReadLine();
    }
}

//14
using System;

class DataSynchronizer
{
    public event EventHandler<DataSyncEventArgs> DataSynced;

    public void SyncData(string data)
    {
        Console.WriteLine($"Синхронизация данных: {data}");
        OnDataSynced(new DataSyncEventArgs { Data = data });
    }

    protected virtual void OnDataSynced(DataSyncEventArgs e)
    {
        DataSynced?.Invoke(this, e);
    }
}

class DataSyncEventArgs : EventArgs
{
    public string Data { get; set; }
}

class Program
{
    static void Main()
    {
        DataSynchronizer synchronizer = new DataSynchronizer();
        synchronizer.DataSynced += (sender, e) =>
            Console.WriteLine($"Данные синхронизированы: {e.Data}");
        synchronizer.SyncData("Новые данные");
    }
}

//15
using System;

class ProcessManager
{
    public event EventHandler ProcessStarted;
    public event EventHandler ProcessCompleted;

    public void StartProcess()
    {
        OnProcessStarted();
        Console.WriteLine("Процесс выполняется...");
        OnProcessCompleted();
    }

    protected virtual void OnProcessStarted()
    {
        ProcessStarted?.Invoke(this, EventArgs.Empty);
    }

    protected virtual void OnProcessCompleted()
    {
        ProcessCompleted?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        ProcessManager manager = new ProcessManager();
        manager.ProcessStarted += (sender, e) => Console.WriteLine("Процесс начат!");
        manager.ProcessCompleted += (sender, e) => Console.WriteLine("Процесс завершён!");
        manager.StartProcess();
    }
}

//16
using System;

class AppStateManager
{
    public event EventHandler<AppStateChangedEventArgs> StateChanged;

    private string _currentState;

    public string CurrentState
    {
        get => _currentState;
        set
        {
            if (_currentState != value)
            {
                _currentState = value;
                StateChanged?.Invoke(this, new AppStateChangedEventArgs(_currentState));
            }
        }
    }
}

class AppStateChangedEventArgs : EventArgs
{
    public string NewState { get; }

    public AppStateChangedEventArgs(string newState)
    {
        NewState = newState;
    }
}

class Program
{
    static void Main()
    {
        var stateManager = new AppStateManager();
        stateManager.StateChanged += (sender, e) =>
            Console.WriteLine($"Состояние приложения изменилось на: {e.NewState}");

        stateManager.CurrentState = "Запущено";
        stateManager.CurrentState = "Остановлено";
    }
}

//17
using System;

class UIUpdater
{
    public event EventHandler<UIUpdateEventArgs> UIUpdateRequested;

    public void RequestUpdate(string elementName, string newValue)
    {
        UIUpdateRequested?.Invoke(this, new UIUpdateEventArgs(elementName, newValue));
    }
}

class UIUpdateEventArgs : EventArgs
{
    public string ElementName { get; }
    public string NewValue { get; }

    public UIUpdateEventArgs(string elementName, string newValue)
    {
        ElementName = elementName;
        NewValue = newValue;
    }
}

class Program
{
    static void Main()
    {
        var updater = new UIUpdater();
        updater.UIUpdateRequested += (sender, e) =>
            Console.WriteLine($"Обновление UI: {e.ElementName} = {e.NewValue}");

        updater.RequestUpdate("Label1", "Новый текст");
    }
}

//18
using System;
using System.Collections.Generic;

class UniqueCollection<T>
{
    private readonly HashSet<T> _items = new HashSet<T>();

    public event EventHandler<CollectionChangedEventArgs<T>> CollectionChanged;

    public void Add(T item)
    {
        if (_items.Add(item))
        {
            CollectionChanged?.Invoke(this, new CollectionChangedEventArgs<T>(item, true));
        }
    }

    public void Remove(T item)
    {
        if (_items.Remove(item))
        {
            CollectionChanged?.Invoke(this, new CollectionChangedEventArgs<T>(item, false));
        }
    }
}

class CollectionChangedEventArgs<T> : EventArgs
{
    public T Item { get; }
    public bool IsAdded { get; }

    public CollectionChangedEventArgs(T item, bool isAdded)
    {
        Item = item;
        IsAdded = isAdded;
    }
}

class Program
{
    static void Main()
    {
        var collection = new UniqueCollection<int>();
        collection.CollectionChanged += (sender, e) =>
            Console.WriteLine($"{e.Item} {(e.IsAdded ? "добавлен" : "удален")}");

        collection.Add(1);
        collection.Add(2);
        collection.Remove(1);
    }
}

//19
using System;

class UserInputHandler
{
    public event EventHandler<UserInputEventArgs> UserInputReceived;

    public void ProcessInput(string input)
    {
        UserInputReceived?.Invoke(this, new UserInputEventArgs(input));
    }
}

class UserInputEventArgs : EventArgs
{
    public string Input { get; }

    public UserInputEventArgs(string input)
    {
        Input = input;
    }
}

class Program
{
    static void Main()
    {
        var inputHandler = new UserInputHandler();
        inputHandler.UserInputReceived += (sender, e) =>
            Console.WriteLine($"Пользовательский ввод: {e.Input}");

        inputHandler.ProcessInput("Привет!");
    }
}

//20
using System;

class DatabaseManager
{
    public event EventHandler<DatabaseOperationEventArgs> DatabaseOperationCompleted;

    public void ExecuteQuery(string query)
    {
        Console.WriteLine($"Выполнение запроса: {query}");
        DatabaseOperationCompleted?.Invoke(this, new DatabaseOperationEventArgs(query, true));
    }
}

class DatabaseOperationEventArgs : EventArgs
{
    public string Query { get; }
    public bool Success { get; }

    public DatabaseOperationEventArgs(string query, bool success)
    {
        Query = query;
        Success = success;
    }
}

class Program
{
    static void Main()
    {
        var dbManager = new DatabaseManager();
        dbManager.DatabaseOperationCompleted += (sender, e) =>
            Console.WriteLine($"Запрос '{e.Query}' выполнен {(e.Success ? "успешно" : "с ошибкой")}");

        dbManager.ExecuteQuery("SELECT * FROM Users");
    }
}

//21
using System;

class FileSystemWatcher
{
    public event EventHandler<FileSystemEventArgs> FileChanged;

    public void NotifyFileChange(string filePath, string changeType)
    {
        FileChanged?.Invoke(this, new FileSystemEventArgs(filePath, changeType));
    }
}

class FileSystemEventArgs : EventArgs
{
    public string FilePath { get; }
    public string ChangeType { get; }

    public FileSystemEventArgs(string filePath, string changeType)
    {
        FilePath = filePath;
        ChangeType = changeType;
    }
}

class Program
{
    static void Main()
    {
        var watcher = new FileSystemWatcher();
        watcher.FileChanged += (sender, e) =>
            Console.WriteLine($"Файл {e.FilePath} изменен: {e.ChangeType}");

        watcher.NotifyFileChange("document.txt", "Изменен");
    }
}

//22
using System;

class ErrorHandler
{
    public event EventHandler<ErrorEventArgs> ErrorOccurred;

    public void SimulateError(string errorMessage)
    {
        ErrorOccurred?.Invoke(this, new ErrorEventArgs(errorMessage));
    }
}

class ErrorEventArgs : EventArgs
{
    public string ErrorMessage { get; }

    public ErrorEventArgs(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }
}

class Program
{
    static void Main()
    {
        var errorHandler = new ErrorHandler();
        errorHandler.ErrorOccurred += (sender, e) =>
            Console.WriteLine($"Ошибка: {e.ErrorMessage}");

        errorHandler.SimulateError("Не удалось подключиться к базе данных");
    }
}

//23
using System;

class OperationProgress
{
    public event EventHandler<ProgressEventArgs> ProgressUpdated;

    public void UpdateProgress(int progress)
    {
        ProgressUpdated?.Invoke(this, new ProgressEventArgs(progress));
    }
}

class ProgressEventArgs : EventArgs
{
    public int Progress { get; }

    public ProgressEventArgs(int progress)
    {
        Progress = progress;
    }
}

class Program
{
    static void Main()
    {
        var progress = new OperationProgress();
        progress.ProgressUpdated += (sender, e) =>
            Console.WriteLine($"Прогресс: {e.Progress}%");

        progress.UpdateProgress(50);
        progress.UpdateProgress(100);
    }
}

//24
using System;
using System.Threading;

class ThreadSynchronizer
{
    public event EventHandler<ThreadEventArgs> ThreadSyncRequested;

    public void RequestSync(int threadId)
    {
        ThreadSyncRequested?.Invoke(this, new ThreadEventArgs(threadId));
    }
}

class ThreadEventArgs : EventArgs
{
    public int ThreadId { get; }

    public ThreadEventArgs(int threadId)
    {
        ThreadId = threadId;
    }
}

class Program
{
    static void Main()
    {
        var synchronizer = new ThreadSynchronizer();
        synchronizer.ThreadSyncRequested += (sender, e) =>
            Console.WriteLine($"Синхронизация потока {e.ThreadId}");

        synchronizer.RequestSync(Thread.CurrentThread.ManagedThreadId);
    }
}

//25
using System;

class NetworkOperation
{
    public event EventHandler<NetworkEventArgs> NetworkOperationCompleted;

    public void SimulateNetworkOperation(string operationName, bool success)
    {
        NetworkOperationCompleted?.Invoke(this, new NetworkEventArgs(operationName, success));
    }
}

class NetworkEventArgs : EventArgs
{
    public string OperationName { get; }
    public bool Success { get; }

    public NetworkEventArgs(string operationName, bool success)
    {
        OperationName = operationName;
        Success = success;
    }
}

class Program
{
    static void Main()
    {
        var networkOp = new NetworkOperation();
        networkOp.NetworkOperationCompleted += (sender, e) =>
            Console.WriteLine($"Операция {e.OperationName} завершена {(e.Success ? "успешно" : "с ошибкой")}");

        networkOp.SimulateNetworkOperation("Загрузка файла", true);
    }
}

//26
using System;

class CacheManager
{
    public event EventHandler<CacheEventArgs> CacheUpdated;

    public void UpdateCache(string key, string value)
    {
        Console.WriteLine($"Обновление кеша: {key} = {value}");
        CacheUpdated?.Invoke(this, new CacheEventArgs(key, value));
    }
}

class CacheEventArgs : EventArgs
{
    public string Key { get; }
    public string Value { get; }

    public CacheEventArgs(string key, string value)
    {
        Key = key;
        Value = value;
    }
}

class Program
{
    static void Main()
    {
        var cacheManager = new CacheManager();
        cacheManager.CacheUpdated += (sender, e) =>
            Console.WriteLine($"Кеш обновлен: {e.Key} = {e.Value}");

        cacheManager.UpdateCache("user:1", "Alice");
    }
}

//27
using System;

class ConfirmationManager
{
    public event EventHandler<ConfirmationEventArgs> ConfirmationRequested;

    public void RequestConfirmation(string action)
    {
        Console.WriteLine($"Запрос подтверждения для: {action}");
        ConfirmationRequested?.Invoke(this, new ConfirmationEventArgs(action));
    }
}

class ConfirmationEventArgs : EventArgs
{
    public string Action { get; }
    public bool IsConfirmed { get; set; }

    public ConfirmationEventArgs(string action)
    {
        Action = action;
    }
}

class Program
{
    static void Main()
    {
        var confirmationManager = new ConfirmationManager();
        confirmationManager.ConfirmationRequested += (sender, e) =>
        {
            Console.WriteLine($"Подтвердите действие: {e.Action} (Y/N)");
            e.IsConfirmed = Console.ReadLine()?.ToUpper() == "Y";
        };

        confirmationManager.RequestConfirmation("Удаление файла");
    }
}

//28
using System;

class SettingsManager
{
    public event EventHandler<SettingsChangedEventArgs> SettingsChanged;

    public void ChangeSetting(string settingName, string newValue)
    {
        Console.WriteLine($"Настройка изменена: {settingName} = {newValue}");
        SettingsChanged?.Invoke(this, new SettingsChangedEventArgs(settingName, newValue));
    }
}

class SettingsChangedEventArgs : EventArgs
{
    public string SettingName { get; }
    public string NewValue { get; }

    public SettingsChangedEventArgs(string settingName, string newValue)
    {
        SettingName = settingName;
        NewValue = newValue;
    }
}

class Program
{
    static void Main()
    {
        var settingsManager = new SettingsManager();
        settingsManager.SettingsChanged += (sender, e) =>
            Console.WriteLine($"Настройка {e.SettingName} изменена на {e.NewValue}");

        settingsManager.ChangeSetting("Theme", "Dark");
    }
}

//29
using System;

class PaymentProcessor
{
    public event EventHandler<PaymentEventArgs> PaymentProcessed;

    public void ProcessPayment(decimal amount, string currency)
    {
        Console.WriteLine($"Обработка платежа: {amount} {currency}");
        PaymentProcessed?.Invoke(this, new PaymentEventArgs(amount, currency));
    }
}

class PaymentEventArgs : EventArgs
{
    public decimal Amount { get; }
    public string Currency { get; }

    public PaymentEventArgs(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }
}

class Program
{
    static void Main()
    {
        var paymentProcessor = new PaymentProcessor();
        paymentProcessor.PaymentProcessed += (sender, e) =>
            Console.WriteLine($"Платеж на сумму {e.Amount} {e.Currency} обработан");

        paymentProcessor.ProcessPayment(100.50m, "USD");
    }
}

//30
using System;

class AuditLogger
{
    public event EventHandler<AuditEventArgs> OperationAudited;

    public void LogOperation(string operationName, string user)
    {
        Console.WriteLine($"Аудит операции: {operationName} (пользователь: {user})");
        OperationAudited?.Invoke(this, new AuditEventArgs(operationName, user));
    }
}

class AuditEventArgs : EventArgs
{
    public string OperationName { get; }
    public string User { get; }

    public AuditEventArgs(string operationName, string user)
    {
        OperationName = operationName;
        User = user;
    }
}

class Program
{
    static void Main()
    {
        var auditLogger = new AuditLogger();
        auditLogger.OperationAudited += (sender, e) =>
            Console.WriteLine($"Операция {e.OperationName} выполнена пользователем {e.User}");

        auditLogger.LogOperation("Удаление файла", "Alice");
    }
}

//31
using System;

class CustomButton
{
    public event EventHandler Clicked;

    public void SimulateClick()
    {
        Console.WriteLine("Кнопка нажата");
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        var button = new CustomButton();
        button.Clicked += (sender, e) =>
            Console.WriteLine("Событие OnClick обработано!");

        button.SimulateClick();
    }
}

//32
using System;

class KeyboardHandler
{
    public event EventHandler<KeyEventArgs> KeyPressed;

    public void SimulateKeyPress(char key)
    {
        Console.WriteLine($"Нажата клавиша: {key}");
        KeyPressed?.Invoke(this, new KeyEventArgs(key));
    }
}

class KeyEventArgs : EventArgs
{
    public char Key { get; }

    public KeyEventArgs(char key)
    {
        Key = key;
    }
}

class Program
{
    static void Main()
    {
        var keyboardHandler = new KeyboardHandler();
        keyboardHandler.KeyPressed += (sender, e) =>
            Console.WriteLine($"Обработка нажатия клавиши: {e.Key}");

        keyboardHandler.SimulateKeyPress('A');
    }
}

//33
using System;

class DataValidator
{
    public event EventHandler<DataValidationEventArgs> DataValidated;

    public void ValidateData(string data, bool isValid)
    {
        Console.WriteLine($"Проверка данных: {data}");
        DataValidated?.Invoke(this, new DataValidationEventArgs(data, isValid));
    }
}

class DataValidationEventArgs : EventArgs
{
    public string Data { get; }
    public bool IsValid { get; }

    public DataValidationEventArgs(string data, bool isValid)
    {
        Data = data;
        IsValid = isValid;
    }
}

class Program
{
    static void Main()
    {
        var validator = new DataValidator();
        validator.DataValidated += (sender, e) =>
            Console.WriteLine($"Данные '{e.Data}' {(e.IsValid ? "валидны" : "невалидны")}");

        validator.ValidateData("test@example.com", true);
    }
}

//34
using System;
using System.Diagnostics;

class PerformanceMonitor
{
    public event EventHandler<PerformanceEventArgs> PerformanceMeasured;

    public void MeasurePerformance(Action action)
    {
        var stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();

        PerformanceMeasured?.Invoke(this, new PerformanceEventArgs(stopwatch.ElapsedMilliseconds));
    }
}

class PerformanceEventArgs : EventArgs
{
    public long ElapsedMilliseconds { get; }

    public PerformanceEventArgs(long elapsedMilliseconds)
    {
        ElapsedMilliseconds = elapsedMilliseconds;
    }
}

class Program
{
    static void Main()
    {
        var monitor = new PerformanceMonitor();
        monitor.PerformanceMeasured += (sender, e) =>
            Console.WriteLine($"Операция выполнена за {e.ElapsedMilliseconds} мс");

        monitor.MeasurePerformance(() =>
        {
            // Симуляция работы
            System.Threading.Thread.Sleep(100);
        });
    }
}

//35
using System;

class ApiClient
{
    public event EventHandler<ApiResponseEventArgs> ApiRequestCompleted;

    public void SimulateApiRequest(string endpoint, bool success)
    {
        Console.WriteLine($"Запрос к API: {endpoint}");
        ApiRequestCompleted?.Invoke(this, new ApiResponseEventArgs(endpoint, success));
    }
}

class ApiResponseEventArgs : EventArgs
{
    public string Endpoint { get; }
    public bool Success { get; }

    public ApiResponseEventArgs(string endpoint, bool success)
    {
        Endpoint = endpoint;
        Success = success;
    }
}

class Program
{
    static void Main()
    {
        var apiClient = new ApiClient();
        apiClient.ApiRequestCompleted += (sender, e) =>
            Console.WriteLine($"Запрос к {e.Endpoint} завершен {(e.Success ? "успешно" : "с ошибкой")}");

        apiClient.SimulateApiRequest("/users", true);
    }
}

//36
using System;

class WeakElementManager
{
    public event EventHandler<WeakElementChangedEventArgs> WeakElementChanged;

    public void ChangeWeakElement(string elementName, int newValue)
    {
        Console.WriteLine($"Слабый элемент {elementName} изменен на {newValue}");
        WeakElementChanged?.Invoke(this, new WeakElementChangedEventArgs(elementName, newValue));
    }
}

class WeakElementChangedEventArgs : EventArgs
{
    public string ElementName { get; }
    public int NewValue { get; }

    public WeakElementChangedEventArgs(string elementName, int newValue)
    {
        ElementName = elementName;
        NewValue = newValue;
    }
}

class Program
{
    static void Main()
    {
        var manager = new WeakElementManager();
        manager.WeakElementChanged += (sender, e) =>
            Console.WriteLine($"Слабый элемент {e.ElementName} изменен на {e.NewValue}");

        manager.ChangeWeakElement("Element1", 42);
    }
}

//37
using System;

class AccessControlManager
{
    public event EventHandler<AccessRightsChangedEventArgs> AccessRightsChanged;

    public void UpdateAccessRights(string user, string newRights)
    {
        Console.WriteLine($"Права доступа пользователя {user} изменены на {newRights}");
        AccessRightsChanged?.Invoke(this, new AccessRightsChangedEventArgs(user, newRights));
    }
}

class AccessRightsChangedEventArgs : EventArgs
{
    public string User { get; }
    public string NewRights { get; }

    public AccessRightsChangedEventArgs(string user, string newRights)
    {
        User = user;
        NewRights = newRights;
    }
}

class Program
{
    static void Main()
    {
        var accessManager = new AccessControlManager();
        accessManager.AccessRightsChanged += (sender, e) =>
            Console.WriteLine($"Права доступа пользователя {e.User} изменены на {e.NewRights}");

        accessManager.UpdateAccessRights("Alice", "Admin");
    }
}

//38
using System;

class UserActivityTracker
{
    public event EventHandler<UserActivityEventArgs> UserActivityDetected;

    public void LogActivity(string user, string activity)
    {
        Console.WriteLine($"Активность пользователя {user}: {activity}");
        UserActivityDetected?.Invoke(this, new UserActivityEventArgs(user, activity));
    }
}

class UserActivityEventArgs : EventArgs
{
    public string User { get; }
    public string Activity { get; }

    public UserActivityEventArgs(string user, string activity)
    {
        User = user;
        Activity = activity;
    }
}

class Program
{
    static void Main()
    {
        var tracker = new UserActivityTracker();
        tracker.UserActivityDetected += (sender, e) =>
            Console.WriteLine($"Пользователь {e.User} выполнил действие: {e.Activity}");

        tracker.LogActivity("Alice", "Вход в систему");
    }
}

//39
using System;

class CacheManager
{
    public event EventHandler<CacheResultEventArgs> CacheResultUpdated;

    public void UpdateCacheResult(string key, string result)
    {
        Console.WriteLine($"Кэширование результата: {key} = {result}");
        CacheResultUpdated?.Invoke(this, new CacheResultEventArgs(key, result));
    }
}

class CacheResultEventArgs : EventArgs
{
    public string Key { get; }
    public string Result { get; }

    public CacheResultEventArgs(string key, string result)
    {
        Key = key;
        Result = result;
    }
}

class Program
{
    static void Main()
    {
        var cacheManager = new CacheManager();
        cacheManager.CacheResultUpdated += (sender, e) =>
            Console.WriteLine($"Результат для ключа {e.Key} кэширован: {e.Result}");

        cacheManager.UpdateCacheResult("query1", "Результат запроса");
    }
}

//40
using System;
using System.Threading.Tasks;

class AsyncOperationManager
{
    public event EventHandler<AsyncOperationCompletedEventArgs> AsyncOperationCompleted;

    public async Task StartAsyncOperation(string operationName)
    {
        Console.WriteLine($"Запуск асинхронной операции: {operationName}");
        await Task.Delay(1000); // Имитация асинхронной работы
        AsyncOperationCompleted?.Invoke(this, new AsyncOperationCompletedEventArgs(operationName, true));
    }
}

class AsyncOperationCompletedEventArgs : EventArgs
{
    public string OperationName { get; }
    public bool Success { get; }

    public AsyncOperationCompletedEventArgs(string operationName, bool success)
    {
        OperationName = operationName;
        Success = success;
    }
}

class Program
{
    static async Task Main()
    {
        var manager = new AsyncOperationManager();
        manager.AsyncOperationCompleted += (sender, e) =>
            Console.WriteLine($"Операция {e.OperationName} завершена {(e.Success ? "успешно" : "с ошибкой")}");

        await manager.StartAsyncOperation("Загрузка данных");
    }
}

//41
using System;
using System.Collections.Generic;

class DataProcessor
{
    public event EventHandler<DataProcessedEventArgs> DataProcessed;

    public void ProcessData(List<int> data, Func<int, bool> filter, Func<int, int, int> sort)
    {
        data.Sort((a, b) => sort(a, b));
        var filteredData = data.FindAll(filter);
        DataProcessed?.Invoke(this, new DataProcessedEventArgs(filteredData));
    }
}

class DataProcessedEventArgs : EventArgs
{
    public List<int> ProcessedData { get; }

    public DataProcessedEventArgs(List<int> processedData)
    {
        ProcessedData = processedData;
    }
}

class Program
{
    static void Main()
    {
        var processor = new DataProcessor();
        processor.DataProcessed += (sender, e) =>
            Console.WriteLine($"Обработанные данные: {string.Join(", ", e.ProcessedData)}");

        var data = new List<int> { 5, 2, 8, 1, 9 };
        processor.ProcessData(data, x => x > 3, (a, b) => a.CompareTo(b));
    }
}

//42
using System;

class SessionManager
{
    public event EventHandler<SessionEventArgs> SessionIdentified;

    public void IdentifySession(string sessionId, string user)
    {
        Console.WriteLine($"Сессия {sessionId} идентифицирована для пользователя {user}");
        SessionIdentified?.Invoke(this, new SessionEventArgs(sessionId, user));
    }
}

class SessionEventArgs : EventArgs
{
    public string SessionId { get; }
    public string User { get; }

    public SessionEventArgs(string sessionId, string user)
    {
        SessionId = sessionId;
        User = user;
    }
}

class Program
{
    static void Main()
    {
        var sessionManager = new SessionManager();
        sessionManager.SessionIdentified += (sender, e) =>
            Console.WriteLine($"Сессия {e.SessionId} для пользователя {e.User} идентифицирована");

        sessionManager.IdentifySession("session123", "Alice");
    }
}

//43
using System;

class RealTimeNotifier
{
    public event EventHandler<RealTimeNotificationEventArgs> NotificationReceived;

    public void SendNotification(string message, string sender)
    {
        Console.WriteLine($"Уведомление от {sender}: {message}");
        NotificationReceived?.Invoke(this, new RealTimeNotificationEventArgs(message, sender));
    }
}

class RealTimeNotificationEventArgs : EventArgs
{
    public string Message { get; }
    public string Sender { get; }

    public RealTimeNotificationEventArgs(string message, string sender)
    {
        Message = message;
        Sender = sender;
    }
}

class Program
{
    static void Main()
    {
        var notifier = new RealTimeNotifier();
        notifier.NotificationReceived += (sender, e) =>
            Console.WriteLine($"Уведомление от {e.Sender}: {e.Message}");

        notifier.SendNotification("Новое сообщение!", "Система");
    }
}

//44
using System;

class ConfigurationManager
{
    public event EventHandler<ConfigurationChangedEventArgs> ConfigurationChanged;

    public void UpdateConfiguration(string key, string newValue)
    {
        Console.WriteLine($"Конфигурация {key} обновлена на {newValue}");
        ConfigurationChanged?.Invoke(this, new ConfigurationChangedEventArgs(key, newValue));
    }
}

class ConfigurationChangedEventArgs : EventArgs
{
    public string Key { get; }
    public string NewValue { get; }

    public ConfigurationChangedEventArgs(string key, string newValue)
    {
        Key = key;
        NewValue = newValue;
    }
}

class Program
{
    static void Main()
    {
        var configManager = new ConfigurationManager();
        configManager.ConfigurationChanged += (sender, e) =>
            Console.WriteLine($"Конфигурация {e.Key} изменена на {e.NewValue}");

        configManager.UpdateConfiguration("Timeout", "30");
    }
}

//45
using System;

class OperationManager
{
    public event EventHandler<OperationEventArgs> OperationPerformed;

    public void PerformOperation(string operationName, bool success)
    {
        Console.WriteLine($"Операция {operationName} выполнена {(success ? "успешно" : "с ошибкой")}");
        OperationPerformed?.Invoke(this, new OperationEventArgs(operationName, success));
    }
}

class OperationEventArgs : EventArgs
{
    public string OperationName { get; }
    public bool Success { get; }

    public OperationEventArgs(string operationName, bool success)
    {
        OperationName = operationName;
        Success = success;
    }
}

class Program
{
    static void Main()
    {
        var operationManager = new OperationManager();
        operationManager.OperationPerformed += (sender, e) =>
            Console.WriteLine($"Операция {e.OperationName} завершена {(e.Success ? "успешно" : "с ошибкой")}");

        operationManager.PerformOperation("Сохранение файла", true);
    }
}

//46
using System;

class AnalyticsCollector
{
    public event EventHandler<AnalyticsEventArgs> AnalyticsDataCollected;

    public void CollectData(string eventName, string userId, string data)
    {
        Console.WriteLine($"Сбор аналитических данных: {eventName} для пользователя {userId}");
        AnalyticsDataCollected?.Invoke(this, new AnalyticsEventArgs(eventName, userId, data));
    }
}

class AnalyticsEventArgs : EventArgs
{
    public string EventName { get; }
    public string UserId { get; }
    public string Data { get; }

    public AnalyticsEventArgs(string eventName, string userId, string data)
    {
        EventName = eventName;
        UserId = userId;
        Data = data;
    }
}

class Program
{
    static void Main()
    {
        var collector = new AnalyticsCollector();
        collector.AnalyticsDataCollected += (sender, e) =>
            Console.WriteLine($"Событие: {e.EventName}, Пользователь: {e.UserId}, Данные: {e.Data}");

        collector.CollectData("ButtonClick", "user123", "MainPage");
    }
}

//47
using System;

class DocumentTemplateManager
{
    public event EventHandler<TemplateEventArgs> TemplateApplied;

    public void ApplyTemplate(string templateName, string documentId)
    {
        Console.WriteLine($"Шаблон {templateName} применен к документу {documentId}");
        TemplateApplied?.Invoke(this, new TemplateEventArgs(templateName, documentId));
    }
}

class TemplateEventArgs : EventArgs
{
    public string TemplateName { get; }
    public string DocumentId { get; }

    public TemplateEventArgs(string templateName, string documentId)
    {
        TemplateName = templateName;
        DocumentId = documentId;
    }
}

class Program
{
    static void Main()
    {
        var templateManager = new DocumentTemplateManager();
        templateManager.TemplateApplied += (sender, e) =>
            Console.WriteLine($"Шаблон {e.TemplateName} применен к документу {e.DocumentId}");

        templateManager.ApplyTemplate("StandardReport", "doc123");
    }
}

//48
using System;

class ConnectionManager
{
    public event EventHandler<ConnectionStateEventArgs> ConnectionStateChanged;

    public void UpdateConnectionState(string connectionId, bool isConnected)
    {
        Console.WriteLine($"Состояние подключения {connectionId}: {(isConnected ? "Подключено" : "Отключено")}");
        ConnectionStateChanged?.Invoke(this, new ConnectionStateEventArgs(connectionId, isConnected));
    }
}

class ConnectionStateEventArgs : EventArgs
{
    public string ConnectionId { get; }
    public bool IsConnected { get; }

    public ConnectionStateEventArgs(string connectionId, bool isConnected)
    {
        ConnectionId = connectionId;
        IsConnected = isConnected;
    }
}

class Program
{
    static void Main()
    {
        var connectionManager = new ConnectionManager();
        connectionManager.ConnectionStateChanged += (sender, e) =>
            Console.WriteLine($"Подключение {e.ConnectionId}: {(e.IsConnected ? "установлено" : "разорвано")}");

        connectionManager.UpdateConnectionState("conn1", true);
        connectionManager.UpdateConnectionState("conn1", false);
    }
}

//49
using System;

class IntegrationService
{
    public event EventHandler<IntegrationEventArgs> IntegrationPerformed;

    public void PerformIntegration(string serviceName, string data)
    {
        Console.WriteLine($"Интеграция с сервисом {serviceName}: {data}");
        IntegrationPerformed?.Invoke(this, new IntegrationEventArgs(serviceName, data));
    }
}

class IntegrationEventArgs : EventArgs
{
    public string ServiceName { get; }
    public string Data { get; }

    public IntegrationEventArgs(string serviceName, string data)
    {
        ServiceName = serviceName;
        Data = data;
    }
}

class Program
{
    static void Main()
    {
        var integrationService = new IntegrationService();
        integrationService.IntegrationPerformed += (sender, e) =>
            Console.WriteLine($"Интеграция с {e.ServiceName}: данные {e.Data}");

        integrationService.PerformIntegration("PaymentGateway", "Transaction123");
    }
}

//50using System;

class ApplicationLifecycleManager
{
    public event EventHandler<LifecycleEventArgs> LifecyclePhaseChanged;

    public void ChangePhase(string phaseName)
    {
        Console.WriteLine($"Фаза жизненного цикла: {phaseName}");
        LifecyclePhaseChanged?.Invoke(this, new LifecycleEventArgs(phaseName));
    }
}

class LifecycleEventArgs : EventArgs
{
    public string PhaseName { get; }

    public LifecycleEventArgs(string phaseName)
    {
        PhaseName = phaseName;
    }
}

class Program
{
    static void Main()
    {
        var lifecycleManager = new ApplicationLifecycleManager();
        lifecycleManager.LifecyclePhaseChanged += (sender, e) =>
            Console.WriteLine($"Фаза жизненного цикла: {e.PhaseName}");

        lifecycleManager.ChangePhase("Инициализация");
        lifecycleManager.ChangePhase("Работа");
        lifecycleManager.ChangePhase("Завершение");
    }
}

//51
using System;

// Model
public class BasicModel
{
    public string Data { get; set; }
}

// View Interface
public interface IBasicView
{
    string GetUserInput();
    void DisplayData(string data);
}

// View Implementation
public class BasicConsoleView : IBasicView
{
    public string GetUserInput()
    {
        Console.WriteLine("Введите данные:");
        return Console.ReadLine();
    }

    public void DisplayData(string data)
    {
        Console.WriteLine($"Отображаемые данные: {data}");
    }
}

// Presenter
public class BasicPresenter
{
    private readonly IBasicView _view;
    private readonly BasicModel _model;

    public BasicPresenter(IBasicView view, BasicModel model)
    {
        _view = view;
        _model = model;
    }

    public void UpdateData()
    {
        _model.Data = _view.GetUserInput();
        _view.DisplayData(_model.Data);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new BasicModel();
        var view = new BasicConsoleView();
        var presenter = new BasicPresenter(view, model);

        presenter.UpdateData();
    }
}


//52
using System;

// Model
public class UserModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

// View Interface
public interface IUserView
{
    string FirstName { get; set; }
    string LastName { get; set; }
    void ShowUser(string fullName);
}

// View Implementation
public class UserConsoleView : IUserView
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void ShowUser(string fullName)
    {
        Console.WriteLine($"Пользователь: {fullName}");
    }
}

// Presenter
public class UserPresenter
{
    private readonly IUserView _view;
    private readonly UserModel _model;

    public UserPresenter(IUserView view, UserModel model)
    {
        _view = view;
        _model = model;
    }

    public void SaveUser()
    {
        _model.FirstName = _view.FirstName;
        _model.LastName = _view.LastName;
    }

    public void LoadUser()
    {
        _view.FirstName = _model.FirstName;
        _view.LastName = _model.LastName;
        _view.ShowUser($"{_model.FirstName} {_model.LastName}");
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new UserModel();
        var view = new UserConsoleView { FirstName = "Иван", LastName = "Иванов" };
        var presenter = new UserPresenter(view, model);

        presenter.SaveUser();
        presenter.LoadUser();
    }
}


//53
using System;
using System.Collections.Generic;

// Model
public class TaskModel
{
    public List<string> Tasks { get; } = new List<string>();
}

// View Interface
public interface ITaskView
{
    void UpdateTaskList(List<string> tasks);
}

// View Implementation
public class TaskConsoleView : ITaskView
{
    public void UpdateTaskList(List<string> tasks)
    {
        Console.WriteLine("Список задач:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"- {task}");
        }
    }
}

// Presenter
public class TaskPresenter
{
    private readonly ITaskView _view;
    private readonly TaskModel _model;

    public TaskPresenter(ITaskView view, TaskModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddTask(string taskName)
    {
        _model.Tasks.Add(taskName);
        _view.UpdateTaskList(_model.Tasks);
    }

    public void RemoveTask(int index)
    {
        if (index >= 0 && index < _model.Tasks.Count)
        {
            _model.Tasks.RemoveAt(index);
            _view.UpdateTaskList(_model.Tasks);
        }
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new TaskModel();
        var view = new TaskConsoleView();
        var presenter = new TaskPresenter(view, model);

        presenter.AddTask("Купить продукты");
        presenter.AddTask("Сделать домашнее задание");
        presenter.RemoveTask(0);
    }
}


//54
using System;
using System.Collections.Generic;

// Model
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class ProductModel
{
    public List<Product> Products { get; } = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void RemoveProduct(int productId)
    {
        Products.RemoveAll(p => p.Id == productId);
    }
}


//55
using System;

// Model
public class CalculatorModel
{
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }

    public double Add() => FirstNumber + SecondNumber;
    public double Subtract() => FirstNumber - SecondNumber;
    public double Multiply() => FirstNumber * SecondNumber;
    public double Divide()
    {
        if (SecondNumber == 0)
            throw new DivideByZeroException("Деление на ноль невозможно.");
        return FirstNumber / SecondNumber;
    }
}

// View Interface
public interface ICalculatorView
{
    double GetFirstNumber();
    double GetSecondNumber();
    string GetOperation();
    void ShowResult(double result);
    void ShowError(string error);
}

// View Implementation
public class CalculatorConsoleView : ICalculatorView
{
    public double GetFirstNumber()
    {
        Console.Write("Введите первое число: ");
        return double.Parse(Console.ReadLine());
    }

    public double GetSecondNumber()
    {
        Console.Write("Введите второе число: ");
        return double.Parse(Console.ReadLine());
    }

    public string GetOperation()
    {
        Console.Write("Введите операцию (+, -, *, /): ");
        return Console.ReadLine();
    }

    public void ShowResult(double result)
    {
        Console.WriteLine($"Результат: {result}");
    }

    public void ShowError(string error)
    {
        Console.WriteLine($"Ошибка: {error}");
    }
}

// Presenter
public class CalculatorPresenter
{
    private readonly ICalculatorView _view;
    private readonly CalculatorModel _model;

    public CalculatorPresenter(ICalculatorView view, CalculatorModel model)
    {
        _view = view;
        _model = model;
    }

    public void Calculate()
    {
        try
        {
            _model.FirstNumber = _view.GetFirstNumber();
            _model.SecondNumber = _view.GetSecondNumber();
            string operation = _view.GetOperation();

            double result = operation switch
            {
                "+" => _model.Add(),
                "-" => _model.Subtract(),
                "*" => _model.Multiply(),
                "/" => _model.Divide(),
                _ => throw new InvalidOperationException("Неверная операция.")
            };

            _view.ShowResult(result);
        }
        catch (Exception ex)
        {
            _view.ShowError(ex.Message);
        }
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new CalculatorModel();
        var view = new CalculatorConsoleView();
        var presenter = new CalculatorPresenter(view, model);

        presenter.Calculate();
    }
}


//56
using System;
using System.Collections.Generic;

// Model
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class UserModel
{
    public List<User> Users { get; } = new List<User>();

    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public void RemoveUser(int userId)
    {
        Users.RemoveAll(u => u.Id == userId);
    }
}

// View Interface
public interface IUserListView
{
    void DisplayUsers(List<User> users);
    User GetUserDetails();
    int GetUserIdToRemove();
}

// View Implementation
public class UserListConsoleView : IUserListView
{
    public void DisplayUsers(List<User> users)
    {
        Console.WriteLine("Список пользователей:");
        foreach (var user in users)
        {
            Console.WriteLine($"{user.Id}: {user.Name} ({user.Email})");
        }
    }

    public User GetUserDetails()
    {
        Console.Write("Введите ID пользователя: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Введите имя пользователя: ");
        string name = Console.ReadLine();
        Console.Write("Введите email пользователя: ");
        string email = Console.ReadLine();

        return new User { Id = id, Name = name, Email = email };
    }

    public int GetUserIdToRemove()
    {
        Console.Write("Введите ID пользователя для удаления: ");
        return int.Parse(Console.ReadLine());
    }
}

// Presenter
public class UserListPresenter
{
    private readonly IUserListView _view;
    private readonly UserModel _model;

    public UserListPresenter(IUserListView view, UserModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddUser()
    {
        var user = _view.GetUserDetails();
        _model.AddUser(user);
        _view.DisplayUsers(_model.Users);
    }

    public void RemoveUser()
    {
        int userId = _view.GetUserIdToRemove();
        _model.RemoveUser(userId);
        _view.DisplayUsers(_model.Users);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new UserModel();
        var view = new UserListConsoleView();
        var presenter = new UserListPresenter(view, model);

        presenter.AddUser();
        presenter.RemoveUser();
    }
}


//57
using System;

// Model
public class TwoWayBindingModel
{
    private string _data;

    public string Data
    {
        get => _data;
        set
        {
            _data = value;
            OnDataChanged?.Invoke(this, _data);
        }
    }

    public event Action<object, string> OnDataChanged;
}

// View Interface
public interface ITwoWayBindingView
{
    string GetData();
    void DisplayData(string data);
    event Action<string> OnDataEntered;
}

// View Implementation
public class TwoWayBindingConsoleView : ITwoWayBindingView
{
    public event Action<string> OnDataEntered;

    public string GetData()
    {
        Console.WriteLine("Введите данные:");
        return Console.ReadLine();
    }

    public void DisplayData(string data)
    {
        Console.WriteLine($"Данные изменены: {data}");
    }
}

// Presenter
public class TwoWayBindingPresenter
{
    private readonly ITwoWayBindingView _view;
    private readonly TwoWayBindingModel _model;

    public TwoWayBindingPresenter(ITwoWayBindingView view, TwoWayBindingModel model)
    {
        _view = view;
        _model = model;

        _view.OnDataEntered += data => _model.Data = data;
        _model.OnDataChanged += (sender, data) => _view.DisplayData(data);
    }

    public void UpdateData()
    {
        _model.Data = _view.GetData();
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new TwoWayBindingModel();
        var view = new TwoWayBindingConsoleView();
        var presenter = new TwoWayBindingPresenter(view, model);

        presenter.UpdateData();
    }
}


//58
using System;

// Model
public class RegistrationModel
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}

// View Interface
public interface IRegistrationView
{
    string Username { get; set; }
    string Password { get; set; }
    string Email { get; set; }
    void ShowSuccess(string message);
    void ShowError(string message);
}

// View Implementation
public class RegistrationConsoleView : IRegistrationView
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    public void ShowSuccess(string message)
    {
        Console.WriteLine($"Успех: {message}");
    }

    public void ShowError(string message)
    {
        Console.WriteLine($"Ошибка: {message}");
    }
}

// Presenter
public class RegistrationPresenter
{
    private readonly IRegistrationView _view;
    private readonly RegistrationModel _model;

    public RegistrationPresenter(IRegistrationView view, RegistrationModel model)
    {
        _view = view;
        _model = model;
    }

    public void RegisterUser()
    {
        if (string.IsNullOrEmpty(_view.Username) || string.IsNullOrEmpty(_view.Password) || string.IsNullOrEmpty(_view.Email))
        {
            _view.ShowError("Все поля должны быть заполнены.");
            return;
        }

        _model.Username = _view.Username;
        _model.Password = _view.Password;
        _model.Email = _view.Email;

        _view.ShowSuccess("Регистрация прошла успешно!");
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new RegistrationModel();
        var view = new RegistrationConsoleView { Username = "user1", Password = "password123", Email = "user1@example.com" };
        var presenter = new RegistrationPresenter(view, model);

        presenter.RegisterUser();
    }
}


//59
using System;
using System.Collections.Generic;

// Model
public class TableModel
{
    public List<List<string>> Data { get; } = new List<List<string>>();

    public void AddRow(List<string> row)
    {
        Data.Add(row);
    }
}

// View Interface
public interface ITableView
{
    void DisplayTable(List<List<string>> data);
    List<string> GetRowData();
}

// View Implementation
public class TableConsoleView : ITableView
{
    public void DisplayTable(List<List<string>> data)
    {
        foreach (var row in data)
        {
            Console.WriteLine(string.Join("\t", row));
        }
    }

    public List<string> GetRowData()
    {
        Console.WriteLine("Введите данные для строки (через запятую):");
        string input = Console.ReadLine();
        return new List<string>(input.Split(','));
    }
}

// Presenter
public class TablePresenter
{
    private readonly ITableView _view;
    private readonly TableModel _model;

    public TablePresenter(ITableView view, TableModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddRow()
    {
        var row = _view.GetRowData();
        _model.AddRow(row);
        _view.DisplayTable(_model.Data);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new TableModel();
        var view = new TableConsoleView();
        var presenter = new TablePresenter(view, model);

        presenter.AddRow();
    }
}


//60
using System;
using System.Collections.Generic;

// Model
public class ShoppingItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}

public class ShoppingListModel
{
    public List<ShoppingItem> Items { get; } = new List<ShoppingItem>();

    public void AddItem(ShoppingItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(string itemName)
    {
        Items.RemoveAll(i => i.Name == itemName);
    }
}

// View Interface
public interface IShoppingListView
{
    void DisplayItems(List<ShoppingItem> items);
    ShoppingItem GetItemDetails();
    string GetItemNameToRemove();
}

// View Implementation
public class ShoppingListConsoleView : IShoppingListView
{
    public void DisplayItems(List<ShoppingItem> items)
    {
        Console.WriteLine("Список покупок:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name} - {item.Quantity}");
        }
    }

    public ShoppingItem GetItemDetails()
    {
        Console.Write("Введите название товара: ");
        string name = Console.ReadLine();
        Console.Write("Введите количество: ");
        int quantity = int.Parse(Console.ReadLine());

        return new ShoppingItem { Name = name, Quantity = quantity };
    }

    public string GetItemNameToRemove()
    {
        Console.Write("Введите название товара для удаления: ");
        return Console.ReadLine();
    }
}

// Presenter
public class ShoppingListPresenter
{
    private readonly IShoppingListView _view;
    private readonly ShoppingListModel _model;

    public ShoppingListPresenter(IShoppingListView view, ShoppingListModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddItem()
    {
        var item = _view.GetItemDetails();
        _model.AddItem(item);
        _view.DisplayItems(_model.Items);
    }

    public void RemoveItem()
    {
        string itemName = _view.GetItemNameToRemove();
        _model.RemoveItem(itemName);
        _view.DisplayItems(_model.Items);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new ShoppingListModel();
        var view = new ShoppingListConsoleView();
        var presenter = new ShoppingListPresenter(view, model);

        presenter.AddItem();
        presenter.RemoveItem();
    }
}


//61
using System;
using System.Collections.Generic;

// Model
public class Note
{
    public string Title { get; set; }
    public string Content { get; set; }
}

public class NotesModel
{
    public List<Note> Notes { get; } = new List<Note>();

    public void AddNote(Note note)
    {
        Notes.Add(note);
    }

    public void RemoveNote(string title)
    {
        Notes.RemoveAll(n => n.Title == title);
    }
}

// View Interface
public interface INotesView
{
    void DisplayNotes(List<Note> notes);
    Note GetNoteDetails();
    string GetNoteTitleToRemove();
}

// View Implementation
public class NotesConsoleView : INotesView
{
    public void DisplayNotes(List<Note> notes)
    {
        Console.WriteLine("Список заметок:");
        foreach (var note in notes)
        {
            Console.WriteLine($"{note.Title}: {note.Content}");
        }
    }

    public Note GetNoteDetails()
    {
        Console.Write("Введите заголовок заметки: ");
        string title = Console.ReadLine();
        Console.Write("Введите содержимое заметки: ");
        string content = Console.ReadLine();

        return new Note { Title = title, Content = content };
    }

    public string GetNoteTitleToRemove()
    {
        Console.Write("Введите заголовок заметки для удаления: ");
        return Console.ReadLine();
    }
}

// Presenter
public class NotesPresenter
{
    private readonly INotesView _view;
    private readonly NotesModel _model;

    public NotesPresenter(INotesView view, NotesModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddNote()
    {
        var note = _view.GetNoteDetails();
        _model.AddNote(note);
        _view.DisplayNotes(_model.Notes);
    }

    public void RemoveNote()
    {
        string title = _view.GetNoteTitleToRemove();
        _model.RemoveNote(title);
        _view.DisplayNotes(_model.Notes);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new NotesModel();
        var view = new NotesConsoleView();
        var presenter = new NotesPresenter(view, model);

        presenter.AddNote();
        presenter.RemoveNote();
    }
}


//62
using System;
using System.Collections.Generic;
using System.Linq;

// Model
public class Item
{
    public string Name { get; set; }
    public int Value { get; set; }
}

public class FilterSortModel
{
    public List<Item> Items { get; } = new List<Item>();

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public List<Item> FilterItems(Func<Item, bool> filter)
    {
        return Items.Where(filter).ToList();
    }

    public List<Item> SortItems(Func<Item, IComparable> keySelector, bool ascending)
    {
        return ascending ? Items.OrderBy(keySelector).ToList() : Items.OrderByDescending(keySelector).ToList();
    }
}

// View Interface
public interface IFilterSortView
{
    void DisplayItems(List<Item> items);
    Item GetItemDetails();
    Func<Item, bool> GetFilterCriteria();
    Func<Item, IComparable> GetSortKey();
    bool GetSortOrder();
}

// View Implementation
public class FilterSortConsoleView : IFilterSortView
{
    public void DisplayItems(List<Item> items)
    {
        Console.WriteLine("Список элементов:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name} - {item.Value}");
        }
    }

    public Item GetItemDetails()
    {
        Console.Write("Введите название элемента: ");
        string name = Console.ReadLine();
        Console.Write("Введите значение элемента: ");
        int value = int.Parse(Console.ReadLine());

        return new Item { Name = name, Value = value };
    }

    public Func<Item, bool> GetFilterCriteria()
    {
        Console.Write("Введите минимальное значение для фильтрации: ");
        int minValue = int.Parse(Console.ReadLine());
        return item => item.Value >= minValue;
    }

    public Func<Item, IComparable> GetSortKey()
    {
        Console.Write("Сортировать по (name/value): ");
        string key = Console.ReadLine();
        return key == "name" ? (Func<Item, IComparable>)(item => item.Name) : item => item.Value;
    }

    public bool GetSortOrder()
    {
        Console.Write("Сортировать по возрастанию? (y/n): ");
        return Console.ReadLine() == "y";
    }
}

// Presenter
public class FilterSortPresenter
{
    private readonly IFilterSortView _view;
    private readonly FilterSortModel _model;

    public FilterSortPresenter(IFilterSortView view, FilterSortModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddItem()
    {
        var item = _view.GetItemDetails();
        _model.AddItem(item);
        _view.DisplayItems(_model.Items);
    }

    public void FilterItems()
    {
        var filter = _view.GetFilterCriteria();
        var filteredItems = _model.FilterItems(filter);
        _view.DisplayItems(filteredItems);
    }

    public void SortItems()
    {
        var keySelector = _view.GetSortKey();
        bool ascending = _view.GetSortOrder();
        var sortedItems = _model.SortItems(keySelector, ascending);
        _view.DisplayItems(sortedItems);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new FilterSortModel();
        var view = new FilterSortConsoleView();
        var presenter = new FilterSortPresenter(view, model);

        presenter.AddItem();
        presenter.FilterItems();
        presenter.SortItems();
    }
}


//63
using System;
using System.Collections.Generic;

// Model
public class Contact
{
    public string Name { get; set; }
    public string Phone { get; set; }
}

public class ContactsModel
{
    public List<Contact> Contacts { get; } = new List<Contact>();

    public void AddContact(Contact contact)
    {
        Contacts.Add(contact);
    }

    public void RemoveContact(string name)
    {
        Contacts.RemoveAll(c => c.Name == name);
    }
}

// View Interface
public interface IContactsView
{
    void DisplayContacts(List<Contact> contacts);
    Contact GetContactDetails();
    string GetContactNameToRemove();
}

// View Implementation
public class ContactsConsoleView : IContactsView
{
    public void DisplayContacts(List<Contact> contacts)
    {
        Console.WriteLine("Список контактов:");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Name} - {contact.Phone}");
        }
    }

    public Contact GetContactDetails()
    {
        Console.Write("Введите имя контакта: ");
        string name = Console.ReadLine();
        Console.Write("Введите телефон контакта: ");
        string phone = Console.ReadLine();

        return new Contact { Name = name, Phone = phone };
    }

    public string GetContactNameToRemove()
    {
        Console.Write("Введите имя контакта для удаления: ");
        return Console.ReadLine();
    }
}

// Presenter
public class ContactsPresenter
{
    private readonly IContactsView _view;
    private readonly ContactsModel _model;

    public ContactsPresenter(IContactsView view, ContactsModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddContact()
    {
        var contact = _view.GetContactDetails();
        _model.AddContact(contact);
        _view.DisplayContacts(_model.Contacts);
    }

    public void RemoveContact()
    {
        string name = _view.GetContactNameToRemove();
        _model.RemoveContact(name);
        _view.DisplayContacts(_model.Contacts);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new ContactsModel();
        var view = new ContactsConsoleView();
        var presenter = new ContactsPresenter(view, model);

        presenter.AddContact();
        presenter.RemoveContact();
    }
}


//64
using System;
using System.Collections.Generic;

// Model
public class EventModel
{
    public event Action<string> OnDataChanged;

    private string _data;

    public string Data
    {
        get => _data;
        set
        {
            _data = value;
            OnDataChanged?.Invoke(_data);
        }
    }
}

// View Interface
public interface IEventView
{
    event Action<string> OnDataEntered;
    void DisplayData(string data);
}

// View Implementation
public class EventConsoleView : IEventView
{
    public event Action<string> OnDataEntered;

    public void DisplayData(string data)
    {
        Console.WriteLine($"Данные изменены: {data}");
    }

    public void EnterData()
    {
        Console.WriteLine("Введите данные:");
        string data = Console.ReadLine();
        OnDataEntered?.Invoke(data);
    }
}

// Presenter
public class EventPresenter
{
    private readonly IEventView _view;
    private readonly EventModel _model;

    public EventPresenter(IEventView view, EventModel model)
    {
        _view = view;
        _model = model;

        _view.OnDataEntered += data => _model.Data = data;
        _model.OnDataChanged += data => _view.DisplayData(data);
    }

    public void UpdateData()
    {
        _view.EnterData();
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new EventModel();
        var view = new EventConsoleView();
        var presenter = new EventPresenter(view, model);

        presenter.UpdateData();
    }
}

//65
using System;

// Model
public class UserProfileModel
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }
}

// View Interface
public interface IUserProfileView
{
    string Username { get; set; }
    string Email { get; set; }
    string Bio { get; set; }
    void ShowProfile(string username, string email, string bio);
    void ShowSuccess(string message);
    void ShowError(string message);
}

// View Implementation
public class UserProfileConsoleView : IUserProfileView
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }

    public void ShowProfile(string username, string email, string bio)
    {
        Console.WriteLine($"Профиль пользователя: {username}, {email}, {bio}");
    }

    public void ShowSuccess(string message)
    {
        Console.WriteLine($"Успех: {message}");
    }

    public void ShowError(string message)
    {
        Console.WriteLine($"Ошибка: {message}");
    }
}

// Presenter
public class UserProfilePresenter
{
    private readonly IUserProfileView _view;
    private readonly UserProfileModel _model;

    public UserProfilePresenter(IUserProfileView view, UserProfileModel model)
    {
        _view = view;
        _model = model;
    }

    public void LoadProfile()
    {
        _view.Username = _model.Username;
        _view.Email = _model.Email;
        _view.Bio = _model.Bio;
        _view.ShowProfile(_model.Username, _model.Email, _model.Bio);
    }

    public void SaveProfile()
    {
        if (string.IsNullOrEmpty(_view.Username) || string.IsNullOrEmpty(_view.Email))
        {
            _view.ShowError("Имя пользователя и email обязательны для заполнения.");
            return;
        }

        _model.Username = _view.Username;
        _model.Email = _view.Email;
        _model.Bio = _view.Bio;

        _view.ShowSuccess("Профиль успешно сохранен!");
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new UserProfileModel { Username = "user1", Email = "user1@example.com", Bio = "Hello, world!" };
        var view = new UserProfileConsoleView();
        var presenter = new UserProfilePresenter(view, model);

        presenter.LoadProfile();
        view.Username = "newuser";
        view.Bio = "Updated bio";
        presenter.SaveProfile();
    }
}

//66
using System;
using System.Collections.Generic;

// Model
public class AppSettingsModel
{
    public Dictionary<string, string> Settings { get; } = new Dictionary<string, string>();

    public void UpdateSetting(string key, string value)
    {
        Settings[key] = value;
    }

    public string GetSetting(string key)
    {
        return Settings.TryGetValue(key, out var value) ? value : null;
    }
}

// View Interface
public interface IAppSettingsView
{
    void DisplaySettings(Dictionary<string, string> settings);
    (string Key, string Value) GetSettingDetails();
    string GetSettingKeyToUpdate();
    string GetNewSettingValue();
}

// View Implementation
public class AppSettingsConsoleView : IAppSettingsView
{
    public void DisplaySettings(Dictionary<string, string> settings)
    {
        Console.WriteLine("Настройки приложения:");
        foreach (var setting in settings)
        {
            Console.WriteLine($"{setting.Key}: {setting.Value}");
        }
    }

    public (string Key, string Value) GetSettingDetails()
    {
        Console.Write("Введите ключ настройки: ");
        string key = Console.ReadLine();
        Console.Write("Введите значение настройки: ");
        string value = Console.ReadLine();

        return (key, value);
    }

    public string GetSettingKeyToUpdate()
    {
        Console.Write("Введите ключ настройки для обновления: ");
        return Console.ReadLine();
    }

    public string GetNewSettingValue()
    {
        Console.Write("Введите новое значение настройки: ");
        return Console.ReadLine();
    }
}

// Presenter
public class AppSettingsPresenter
{
    private readonly IAppSettingsView _view;
    private readonly AppSettingsModel _model;

    public AppSettingsPresenter(IAppSettingsView view, AppSettingsModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddSetting()
    {
        var (key, value) = _view.GetSettingDetails();
        _model.UpdateSetting(key, value);
        _view.DisplaySettings(_model.Settings);
    }

    public void UpdateSetting()
    {
        string key = _view.GetSettingKeyToUpdate();
        string value = _view.GetNewSettingValue();
        _model.UpdateSetting(key, value);
        _view.DisplaySettings(_model.Settings);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new AppSettingsModel();
        var view = new AppSettingsConsoleView();
        var presenter = new AppSettingsPresenter(view, model);

        presenter.AddSetting();
        presenter.UpdateSetting();
    }
}

//67
using System;
using System.Collections.Generic;

// Model
public class NavigationModel
{
    public Stack<string> ScreenHistory { get; } = new Stack<string>();
    public string CurrentScreen { get; private set; }

    public void NavigateTo(string screenName)
    {
        ScreenHistory.Push(CurrentScreen);
        CurrentScreen = screenName;
    }

    public void GoBack()
    {
        if (ScreenHistory.Count > 0)
        {
            CurrentScreen = ScreenHistory.Pop();
        }
    }
}

// View Interface
public interface INavigationView
{
    void DisplayCurrentScreen(string screenName);
    string GetScreenNameToNavigate();
}

// View Implementation
public class NavigationConsoleView : INavigationView
{
    public void DisplayCurrentScreen(string screenName)
    {
        Console.WriteLine($"Текущий экран: {screenName}");
    }

    public string GetScreenNameToNavigate()
    {
        Console.Write("Введите название экрана для навигации: ");
        return Console.ReadLine();
    }
}

// Presenter
public class NavigationPresenter
{
    private readonly INavigationView _view;
    private readonly NavigationModel _model;

    public NavigationPresenter(INavigationView view, NavigationModel model)
    {
        _view = view;
        _model = model;
    }

    public void NavigateToScreen()
    {
        string screenName = _view.GetScreenNameToNavigate();
        _model.NavigateTo(screenName);
        _view.DisplayCurrentScreen(_model.CurrentScreen);
    }

    public void GoBack()
    {
        _model.GoBack();
        _view.DisplayCurrentScreen(_model.CurrentScreen);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new NavigationModel { CurrentScreen = "Home" };
        var view = new NavigationConsoleView();
        var presenter = new NavigationPresenter(view, model);

        presenter.NavigateToScreen();
        presenter.GoBack();
    }
}

//68
using System;
using System.Collections.Generic;
using System.Linq;

// Model
public class SearchItem
{
    public string Name { get; set; }
    public string Category { get; set; }
}

public class SearchModel
{
    public List<SearchItem> Items { get; } = new List<SearchItem>();

    public void AddItem(SearchItem item)
    {
        Items.Add(item);
    }

    public List<SearchItem> SearchItems(Func<SearchItem, bool> filter)
    {
        return Items.Where(filter).ToList();
    }
}

// View Interface
public interface ISearchView
{
    void DisplayItems(List<SearchItem> items);
    SearchItem GetItemDetails();
    string GetSearchQuery();
}

// View Implementation
public class SearchConsoleView : ISearchView
{
    public void DisplayItems(List<SearchItem> items)
    {
        Console.WriteLine("Результаты поиска:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name} ({item.Category})");
        }
    }

    public SearchItem GetItemDetails()
    {
        Console.Write("Введите название элемента: ");
        string name = Console.ReadLine();
        Console.Write("Введите категорию элемента: ");
        string category = Console.ReadLine();

        return new SearchItem { Name = name, Category = category };
    }

    public string GetSearchQuery()
    {
        Console.Write("Введите строку для поиска: ");
        return Console.ReadLine();
    }
}

// Presenter
public class SearchPresenter
{
    private readonly ISearchView _view;
    private readonly SearchModel _model;

    public SearchPresenter(ISearchView view, SearchModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddItem()
    {
        var item = _view.GetItemDetails();
        _model.AddItem(item);
    }

    public void SearchItems()
    {
        string query = _view.GetSearchQuery();
        var results = _model.SearchItems(item => item.Name.Contains(query) || item.Category.Contains(query));
        _view.DisplayItems(results);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new SearchModel();
        var view = new SearchConsoleView();
        var presenter = new SearchPresenter(view, model);

        presenter.AddItem();
        presenter.SearchItems();
    }
}

//69
using System;
using System.Collections.Generic;

// Model
public class Project
{
    public string Name { get; set; }
    public DateTime Deadline { get; set; }
    public List<string> Tasks { get; } = new List<string>();
}

public class ProjectModel
{
    public List<Project> Projects { get; } = new List<Project>();

    public void AddProject(Project project)
    {
        Projects.Add(project);
    }

    public void AddTaskToProject(string projectName, string task)
    {
        var project = Projects.Find(p => p.Name == projectName);
        if (project != null)
        {
            project.Tasks.Add(task);
        }
    }
}

// View Interface
public interface IProjectView
{
    void DisplayProjects(List<Project> projects);
    Project GetProjectDetails();
    (string ProjectName, string Task) GetTaskDetails();
}

// View Implementation
public class ProjectConsoleView : IProjectView
{
    public void DisplayProjects(List<Project> projects)
    {
        Console.WriteLine("Список проектов:");
        foreach (var project in projects)
        {
            Console.WriteLine($"{project.Name} (Deadline: {project.Deadline.ToShortDateString()})");
            foreach (var task in project.Tasks)
            {
                Console.WriteLine($"- {task}");
            }
        }
    }

    public Project GetProjectDetails()
    {
        Console.Write("Введите название проекта: ");
        string name = Console.ReadLine();
        Console.Write("Введите дедлайн проекта (dd/MM/yyyy): ");
        DateTime deadline = DateTime.Parse(Console.ReadLine());

        return new Project { Name = name, Deadline = deadline };
    }

    public (string ProjectName, string Task) GetTaskDetails()
    {
        Console.Write("Введите название проекта: ");
        string projectName = Console.ReadLine();
        Console.Write("Введите название задачи: ");
        string task = Console.ReadLine();

        return (projectName, task);
    }
}

// Presenter
public class ProjectPresenter
{
    private readonly IProjectView _view;
    private readonly ProjectModel _model;

    public ProjectPresenter(IProjectView view, ProjectModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddProject()
    {
        var project = _view.GetProjectDetails();
        _model.AddProject(project);
        _view.DisplayProjects(_model.Projects);
    }

    public void AddTask()
    {
        var (projectName, task) = _view.GetTaskDetails();
        _model.AddTaskToProject(projectName, task);
        _view.DisplayProjects(_model.Projects);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new ProjectModel();
        var view = new ProjectConsoleView();
        var presenter = new ProjectPresenter(view, model);

        presenter.AddProject();
        presenter.AddTask();
    }
}

//70
using System;
using System.Collections.Generic;

// Model
public class CartItem
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public class ShoppingCartModel
{
    public List<CartItem> Items { get; } = new List<CartItem>();

    public void AddItem(CartItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(string productName)
    {
        Items.RemoveAll(i => i.ProductName == productName);
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var item in Items)
        {
            total += item.Price * item.Quantity;
        }
        return total;
    }
}

// View Interface
public interface IShoppingCartView
{
    void DisplayCart(List<CartItem> items, decimal total);
    CartItem GetItemDetails();
    string GetItemNameToRemove();
}

// View Implementation
public class ShoppingCartConsoleView : IShoppingCartView
{
    public void DisplayCart(List<CartItem> items, decimal total)
    {
        Console.WriteLine("Корзина покупок:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.ProductName} - {item.Quantity} x {item.Price:C}");
        }
        Console.WriteLine($"Итого: {total:C}");
    }

    public CartItem GetItemDetails()
    {
        Console.Write("Введите название товара: ");
        string productName = Console.ReadLine();
        Console.Write("Введите количество: ");
        int quantity = int.Parse(Console.ReadLine());
        Console.Write("Введите цену: ");
        decimal price = decimal.Parse(Console.ReadLine());

        return new CartItem { ProductName = productName, Quantity = quantity, Price = price };
    }

    public string GetItemNameToRemove()
    {
        Console.Write("Введите название товара для удаления: ");
        return Console.ReadLine();
    }
}

// Presenter
public class ShoppingCartPresenter
{
    private readonly IShoppingCartView _view;
    private readonly ShoppingCartModel _model;

    public ShoppingCartPresenter(IShoppingCartView view, ShoppingCartModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddItem()
    {
        var item = _view.GetItemDetails();
        _model.AddItem(item);
        _view.DisplayCart(_model.Items, _model.CalculateTotal());
    }

    public void RemoveItem()
    {
        string productName = _view.GetItemNameToRemove();
        _model.RemoveItem(productName);
        _view.DisplayCart(_model.Items, _model.CalculateTotal());
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new ShoppingCartModel();
        var view = new ShoppingCartConsoleView();
        var presenter = new ShoppingCartPresenter(view, model);

        presenter.AddItem();
        presenter.RemoveItem();
    }
}

//71
using System;
using System.Collections.Generic;

// Model
public class NewsItem
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishDate { get; set; }
}

public class NewsModel
{
    public List<NewsItem> NewsItems { get; } = new List<NewsItem>();

    public void AddNewsItem(NewsItem newsItem)
    {
        NewsItems.Add(newsItem);
    }

    public List<NewsItem> GetRecentNews(int count)
    {
        NewsItems.Sort((x, y) => y.PublishDate.CompareTo(x.PublishDate));
        return NewsItems.GetRange(0, Math.Min(count, NewsItems.Count));
    }
}

// View Interface
public interface INewsView
{
    void DisplayNews(List<NewsItem> newsItems);
    NewsItem GetNewsItemDetails();
}

// View Implementation
public class NewsConsoleView : INewsView
{
    public void DisplayNews(List<NewsItem> newsItems)
    {
        Console.WriteLine("Последние новости:");
        foreach (var newsItem in newsItems)
        {
            Console.WriteLine($"{newsItem.Title} ({newsItem.PublishDate.ToShortDateString()})");
            Console.WriteLine($"{newsItem.Content}\n");
        }
    }

    public NewsItem GetNewsItemDetails()
    {
        Console.Write("Введите заголовок новости: ");
        string title = Console.ReadLine();
        Console.Write("Введите содержимое новости: ");
        string content = Console.ReadLine();

        return new NewsItem { Title = title, Content = content, PublishDate = DateTime.Now };
    }
}

// Presenter
public class NewsPresenter
{
    private readonly INewsView _view;
    private readonly NewsModel _model;

    public NewsPresenter(INewsView view, NewsModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddNewsItem()
    {
        var newsItem = _view.GetNewsItemDetails();
        _model.AddNewsItem(newsItem);
    }

    public void DisplayRecentNews(int count)
    {
        var recentNews = _model.GetRecentNews(count);
        _view.DisplayNews(recentNews);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new NewsModel();
        var view = new NewsConsoleView();
        var presenter = new NewsPresenter(view, model);

        presenter.AddNewsItem();
        presenter.DisplayRecentNews(5);
    }
}

//72
using System;
using System.Collections.Generic;

// Model
public class Message
{
    public string Sender { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
}

public class ChatModel
{
    public List<Message> Messages { get; } = new List<Message>();

    public void AddMessage(Message message)
    {
        Messages.Add(message);
    }

    public List<Message> GetMessages()
    {
        return Messages;
    }
}

// View Interface
public interface IChatView
{
    void DisplayMessages(List<Message> messages);
    Message GetMessageDetails();
}

// View Implementation
public class ChatConsoleView : IChatView
{
    public void DisplayMessages(List<Message> messages)
    {
        Console.WriteLine("Сообщения в чате:");
        foreach (var message in messages)
        {
            Console.WriteLine($"{message.Timestamp:HH:mm} {message.Sender}: {message.Content}");
        }
    }

    public Message GetMessageDetails()
    {
        Console.Write("Введите ваше имя: ");
        string sender = Console.ReadLine();
        Console.Write("Введите текст сообщения: ");
        string content = Console.ReadLine();

        return new Message { Sender = sender, Content = content, Timestamp = DateTime.Now };
    }
}

// Presenter
public class ChatPresenter
{
    private readonly IChatView _view;
    private readonly ChatModel _model;

    public ChatPresenter(IChatView view, ChatModel model)
    {
        _view = view;
        _model = model;
    }

    public void SendMessage()
    {
        var message = _view.GetMessageDetails();
        _model.AddMessage(message);
        _view.DisplayMessages(_model.GetMessages());
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new ChatModel();
        var view = new ChatConsoleView();
        var presenter = new ChatPresenter(view, model);

        presenter.SendMessage();
    }
}

//73
using System;
using System.Collections.Generic;

// Model
public class Expense
{
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}

public class ExpenseModel
{
    public List<Expense> Expenses { get; } = new List<Expense>();

    public void AddExpense(Expense expense)
    {
        Expenses.Add(expense);
    }

    public decimal GetTotalExpenses()
    {
        decimal total = 0;
        foreach (var expense in Expenses)
        {
            total += expense.Amount;
        }
        return total;
    }
}

// View Interface
public interface IExpenseView
{
    void DisplayExpenses(List<Expense> expenses, decimal total);
    Expense GetExpenseDetails();
}

// View Implementation
public class ExpenseConsoleView : IExpenseView
{
    public void DisplayExpenses(List<Expense> expenses, decimal total)
    {
        Console.WriteLine("Список расходов:");
        foreach (var expense in expenses)
        {
            Console.WriteLine($"{expense.Date:yyyy-MM-dd} - {expense.Description}: {expense.Amount:C}");
        }
        Console.WriteLine($"Общая сумма расходов: {total:C}");
    }

    public Expense GetExpenseDetails()
    {
        Console.Write("Введите описание расхода: ");
        string description = Console.ReadLine();
        Console.Write("Введите сумму расхода: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        return new Expense { Description = description, Amount = amount, Date = DateTime.Now };
    }
}

// Presenter
public class ExpensePresenter
{
    private readonly IExpenseView _view;
    private readonly ExpenseModel _model;

    public ExpensePresenter(IExpenseView view, ExpenseModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddExpense()
    {
        var expense = _view.GetExpenseDetails();
        _model.AddExpense(expense);
        _view.DisplayExpenses(_model.Expenses, _model.GetTotalExpenses());
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new ExpenseModel();
        var view = new ExpenseConsoleView();
        var presenter = new ExpensePresenter(view, model);

        presenter.AddExpense();
    }
}

//74
using System;
using System.Collections.Generic;

// Model
public class Image
{
    public string Title { get; set; }
    public string Path { get; set; }
}

public class GalleryModel
{
    public List<Image> Images { get; } = new List<Image>();

    public void AddImage(Image image)
    {
        Images.Add(image);
    }

    public List<Image> GetImages()
    {
        return Images;
    }
}

// View Interface
public interface IGalleryView
{
    void DisplayImages(List<Image> images);
    Image GetImageDetails();
}

// View Implementation
public class GalleryConsoleView : IGalleryView
{
    public void DisplayImages(List<Image> images)
    {
        Console.WriteLine("Галерея изображений:");
        foreach (var image in images)
        {
            Console.WriteLine($"{image.Title} - {image.Path}");
        }
    }

    public Image GetImageDetails()
    {
        Console.Write("Введите название изображения: ");
        string title = Console.ReadLine();
        Console.Write("Введите путь к изображению: ");
        string path = Console.ReadLine();

        return new Image { Title = title, Path = path };
    }
}

// Presenter
public class GalleryPresenter
{
    private readonly IGalleryView _view;
    private readonly GalleryModel _model;

    public GalleryPresenter(IGalleryView view, GalleryModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddImage()
    {
        var image = _view.GetImageDetails();
        _model.AddImage(image);
        _view.DisplayImages(_model.GetImages());
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new GalleryModel();
        var view = new GalleryConsoleView();
        var presenter = new GalleryPresenter(view, model);

        presenter.AddImage();
    }
}

//75
using System;
using System.Collections.Generic;

// Model
public class TaskItem
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
}

public class TaskModel
{
    public List<TaskItem> Tasks { get; } = new List<TaskItem>();

    public void AddTask(TaskItem task)
    {
        Tasks.Add(task);
    }

    public void ToggleTaskCompletion(string title)
    {
        var task = Tasks.Find(t => t.Title == title);
        if (task != null)
        {
            task.IsCompleted = !task.IsCompleted;
        }
    }
}

// View Interface
public interface ITaskManagerView
{
    void DisplayTasks(List<TaskItem> tasks);
    TaskItem GetTaskDetails();
    string GetTaskTitleToToggle();
}

// View Implementation
public class TaskManagerConsoleView : ITaskManagerView
{
    public void DisplayTasks(List<TaskItem> tasks)
    {
        Console.WriteLine("Список задач:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"- {(task.IsCompleted ? "[x]" : "[ ]")} {task.Title}");
        }
    }

    public TaskItem GetTaskDetails()
    {
        Console.Write("Введите название задачи: ");
        string title = Console.ReadLine();

        return new TaskItem { Title = title, IsCompleted = false };
    }

    public string GetTaskTitleToToggle()
    {
        Console.Write("Введите название задачи для изменения статуса: ");
        return Console.ReadLine();
    }
}

// Presenter
public class TaskManagerPresenter
{
    private readonly ITaskManagerView _view;
    private readonly TaskModel _model;

    public TaskManagerPresenter(ITaskManagerView view, TaskModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddTask()
    {
        var task = _view.GetTaskDetails();
        _model.AddTask(task);
        _view.DisplayTasks(_model.Tasks);
    }

    public void ToggleTaskCompletion()
    {
        string title = _view.GetTaskTitleToToggle();
        _model.ToggleTaskCompletion(title);
        _view.DisplayTasks(_model.Tasks);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new TaskModel();
        var view = new TaskManagerConsoleView();
        var presenter = new TaskManagerPresenter(view, model);

        presenter.AddTask();
        presenter.ToggleTaskCompletion();
    }
}

//76
using System;

// Model
public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class AuthenticationModel
{
    private User _currentUser;

    public bool Authenticate(string username, string password)
    {
        // Простая проверка (в реальном приложении используйте безопасное хранение паролей)
        _currentUser = new User { Username = username, Password = password };
        return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
    }

    public User GetCurrentUser()
    {
        return _currentUser;
    }
}

// View Interface
public interface IAuthenticationView
{
    string GetUsername();
    string GetPassword();
    void ShowSuccess(string message);
    void ShowError(string message);
}

// View Implementation
public class AuthenticationConsoleView : IAuthenticationView
{
    public string GetUsername()
    {
        Console.Write("Введите имя пользователя: ");
        return Console.ReadLine();
    }

    public string GetPassword()
    {
        Console.Write("Введите пароль: ");
        return Console.ReadLine();
    }

    public void ShowSuccess(string message)
    {
        Console.WriteLine($"Успех: {message}");
    }

    public void ShowError(string message)
    {
        Console.WriteLine($"Ошибка: {message}");
    }
}

// Presenter
public class AuthenticationPresenter
{
    private readonly IAuthenticationView _view;
    private readonly AuthenticationModel _model;

    public AuthenticationPresenter(IAuthenticationView view, AuthenticationModel model)
    {
        _view = view;
        _model = model;
    }

    public void Authenticate()
    {
        string username = _view.GetUsername();
        string password = _view.GetPassword();

        if (_model.Authenticate(username, password))
        {
            _view.ShowSuccess("Аутентификация прошла успешно!");
        }
        else
        {
            _view.ShowError("Неверное имя пользователя или пароль.");
        }
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new AuthenticationModel();
        var view = new AuthenticationConsoleView();
        var presenter = new AuthenticationPresenter(view, model);

        presenter.Authenticate();
    }
}

//77
using System;
using System.Collections.Generic;

// Model
public class DataPoint
{
    public string Label { get; set; }
    public double Value { get; set; }
}

public class StatisticsModel
{
    public List<DataPoint> DataPoints { get; } = new List<DataPoint>();

    public void AddDataPoint(DataPoint dataPoint)
    {
        DataPoints.Add(dataPoint);
    }

    public double CalculateAverage()
    {
        if (DataPoints.Count == 0) return 0;

        double sum = 0;
        foreach (var point in DataPoints)
        {
            sum += point.Value;
        }
        return sum / DataPoints.Count;
    }
}

// View Interface
public interface IStatisticsView
{
    void DisplayDataPoints(List<DataPoint> dataPoints, double average);
    DataPoint GetDataPointDetails();
}

// View Implementation
public class StatisticsConsoleView : IStatisticsView
{
    public void DisplayDataPoints(List<DataPoint> dataPoints, double average)
    {
        Console.WriteLine("Точки данных:");
        foreach (var point in dataPoints)
        {
            Console.WriteLine($"{point.Label}: {point.Value}");
        }
        Console.WriteLine($"Среднее значение: {average:F2}");
    }

    public DataPoint GetDataPointDetails()
    {
        Console.Write("Введите метку точки данных: ");
        string label = Console.ReadLine();
        Console.Write("Введите значение точки данных: ");
        double value = double.Parse(Console.ReadLine());

        return new DataPoint { Label = label, Value = value };
    }
}

// Presenter
public class StatisticsPresenter
{
    private readonly IStatisticsView _view;
    private readonly StatisticsModel _model;

    public StatisticsPresenter(IStatisticsView view, StatisticsModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddDataPoint()
    {
        var dataPoint = _view.GetDataPointDetails();
        _model.AddDataPoint(dataPoint);
        _view.DisplayDataPoints(_model.DataPoints, _model.CalculateAverage());
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new StatisticsModel();
        var view = new StatisticsConsoleView();
        var presenter = new StatisticsPresenter(view, model);

        presenter.AddDataPoint();
    }
}

//78
using System;
using System.Collections.Generic;

// Model
public class Ingredient
{
    public string Name { get; set; }
    public string Quantity { get; set; }
}

public class Recipe
{
    public string Title { get; set; }
    public List<Ingredient> Ingredients { get; } = new List<Ingredient>();
    public string Instructions { get; set; }
}

public class RecipeModel
{
    public List<Recipe> Recipes { get; } = new List<Recipe>();

    public void AddRecipe(Recipe recipe)
    {
        Recipes.Add(recipe);
    }
}

// View Interface
public interface IRecipeView
{
    void DisplayRecipes(List<Recipe> recipes);
    Recipe GetRecipeDetails();
}

// View Implementation
public class RecipeConsoleView : IRecipeView
{
    public void DisplayRecipes(List<Recipe> recipes)
    {
        Console.WriteLine("Список рецептов:");
        foreach (var recipe in recipes)
        {
            Console.WriteLine($"{recipe.Title}");
            Console.WriteLine("Ингредиенты:");
            foreach (var ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"- {ingredient.Name}: {ingredient.Quantity}");
            }
            Console.WriteLine($"Инструкции: {recipe.Instructions}\n");
        }
    }

    public Recipe GetRecipeDetails()
    {
        Console.Write("Введите название рецепта: ");
        string title = Console.ReadLine();

        var recipe = new Recipe { Title = title };

        Console.WriteLine("Введите ингредиенты (закончите ввод словом 'end'):");
        while (true)
        {
            Console.Write("Название ингредиента (или 'end'): ");
            string name = Console.ReadLine();
            if (name.ToLower() == "end") break;

            Console.Write("Количество: ");
            string quantity = Console.ReadLine();

            recipe.Ingredients.Add(new Ingredient { Name = name, Quantity = quantity });
        }

        Console.Write("Введите инструкции: ");
        recipe.Instructions = Console.ReadLine();

        return recipe;
    }
}

// Presenter
public class RecipePresenter
{
    private readonly IRecipeView _view;
    private readonly RecipeModel _model;

    public RecipePresenter(IRecipeView view, RecipeModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddRecipe()
    {
        var recipe = _view.GetRecipeDetails();
        _model.AddRecipe(recipe);
        _view.DisplayRecipes(_model.Recipes);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new RecipeModel();
        var view = new RecipeConsoleView();
        var presenter = new RecipePresenter(view, model);

        presenter.AddRecipe();
    }
}

//79
using System;
using System.Collections.Generic;

// Model
public class Task
{
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
}

public class PlanningModel
{
    public List<Task> Tasks { get; } = new List<Task>();

    public void AddTask(Task task)
    {
        Tasks.Add(task);
    }

    public void ToggleTaskCompletion(string description)
    {
        var task = Tasks.Find(t => t.Description == description);
        if (task != null)
        {
            task.IsCompleted = !task.IsCompleted;
        }
    }
}

// View Interface
public interface IPlanningView
{
    void DisplayTasks(List<Task> tasks);
    Task GetTaskDetails();
    string GetTaskDescriptionToToggle();
}

// View Implementation
public class PlanningConsoleView : IPlanningView
{
    public void DisplayTasks(List<Task> tasks)
    {
        Console.WriteLine("Список задач:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"- {(task.IsCompleted ? "[x]" : "[ ]")} {task.Description} (до {task.DueDate:yyyy-MM-dd})");
        }
    }

    public Task GetTaskDetails()
    {
        Console.Write("Введите описание задачи: ");
        string description = Console.ReadLine();
        Console.Write("Введите срок выполнения (yyyy-MM-dd): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        return new Task { Description = description, DueDate = dueDate, IsCompleted = false };
    }

    public string GetTaskDescriptionToToggle()
    {
        Console.Write("Введите описание задачи для изменения статуса: ");
        return Console.ReadLine();
    }
}

// Presenter
public class PlanningPresenter
{
    private readonly IPlanningView _view;
    private readonly PlanningModel _model;

    public PlanningPresenter(IPlanningView view, PlanningModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddTask()
    {
        var task = _view.GetTaskDetails();
        _model.AddTask(task);
        _view.DisplayTasks(_model.Tasks);
    }

    public void ToggleTaskCompletion()
    {
        string description = _view.GetTaskDescriptionToToggle();
        _model.ToggleTaskCompletion(description);
        _view.DisplayTasks(_model.Tasks);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new PlanningModel();
        var view = new PlanningConsoleView();
        var presenter = new PlanningPresenter(view, model);

        presenter.AddTask();
        presenter.ToggleTaskCompletion();
    }
}

//80
using System;
using System.Collections.Generic;

// Model
public class Booking
{
    public string CustomerName { get; set; }
    public DateTime BookingDate { get; set; }
    public string Service { get; set; }
}

public class BookingModel
{
    public List<Booking> Bookings { get; } = new List<Booking>();

    public void AddBooking(Booking booking)
    {
        Bookings.Add(booking);
    }

    public List<Booking> GetBookingsByDate(DateTime date)
    {
        return Bookings.FindAll(b => b.BookingDate.Date == date.Date);
    }
}

// View Interface
public interface IBookingView
{
    void DisplayBookings(List<Booking> bookings);
    Booking GetBookingDetails();
    DateTime GetDateToViewBookings();
}

// View Implementation
public class BookingConsoleView : IBookingView
{
    public void DisplayBookings(List<Booking> bookings)
    {
        Console.WriteLine("Список бронирований:");
        foreach (var booking in bookings)
        {
            Console.WriteLine($"{booking.BookingDate:yyyy-MM-dd HH:mm} - {booking.CustomerName} ({booking.Service})");
        }
    }

    public Booking GetBookingDetails()
    {
        Console.Write("Введите имя клиента: ");
        string customerName = Console.ReadLine();
        Console.Write("Введите дату и время бронирования (yyyy-MM-dd HH:mm): ");
        DateTime bookingDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Введите услугу: ");
        string service = Console.ReadLine();

        return new Booking { CustomerName = customerName, BookingDate = bookingDate, Service = service };
    }

    public DateTime GetDateToViewBookings()
    {
        Console.Write("Введите дату для просмотра бронирований (yyyy-MM-dd): ");
        return DateTime.Parse(Console.ReadLine());
    }
}

// Presenter
public class BookingPresenter
{
    private readonly IBookingView _view;
    private readonly BookingModel _model;

    public BookingPresenter(IBookingView view, BookingModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddBooking()
    {
        var booking = _view.GetBookingDetails();
        _model.AddBooking(booking);
    }

    public void ViewBookingsByDate()
    {
        DateTime date = _view.GetDateToViewBookings();
        var bookings = _model.GetBookingsByDate(date);
        _view.DisplayBookings(bookings);
    }
}

// Использование
class Program
{
    static void Main()
    {
        var model = new BookingModel();
        var view = new BookingConsoleView();
        var presenter = new BookingPresenter(view, model);

        presenter.AddBooking();
        presenter.ViewBookingsByDate();
    }
}

//81
using System;
using System.Collections.Generic;

// Model
public class MenuModel
{
    public List<string> GetMenuItems()
    {
        return new List<string> { "Pizza", "Burger", "Salad", "Soup" };
    }
}

// View Interface
public interface IMenuView
{
    void DisplayMenu(List<string> items);
}

// Presenter
public class MenuPresenter
{
    private readonly IMenuView _view;
    private readonly MenuModel _model;

    public MenuPresenter(IMenuView view, MenuModel model)
    {
        _view = view;
        _model = model;
    }

    public void LoadMenu()
    {
        var items = _model.GetMenuItems();
        _view.DisplayMenu(items);
    }
}

// Example View Implementation (Console for simplicity)
public class ConsoleMenuView : IMenuView
{
    public void DisplayMenu(List<string> items)
    {
        Console.WriteLine("Restaurant Menu:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

// Usage
class Program
{
    static void Main()
    {
        var model = new MenuModel();
        var view = new ConsoleMenuView();
        var presenter = new MenuPresenter(view, model);
        presenter.LoadMenu();
    }
}

//82
using System;
using System.Collections.Generic;

// Model
public class EventModel
{
    private List<string> _events = new List<string>();

    public void AddEvent(string eventName)
    {
        _events.Add(eventName);
    }

    public List<string> GetEvents()
    {
        return _events;
    }
}

// View Interface
public interface IEventView
{
    void DisplayEvents(List<string> events);
    string GetNewEvent();
}

// Presenter
public class EventPresenter
{
    private readonly IEventView _view;
    private readonly EventModel _model;

    public EventPresenter(IEventView view, EventModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddEvent()
    {
        var newEvent = _view.GetNewEvent();
        _model.AddEvent(newEvent);
    }

    public void LoadEvents()
    {
        var events = _model.GetEvents();
        _view.DisplayEvents(events);
    }
}

// Example View Implementation (Console)
public class ConsoleEventView : IEventView
{
    public void DisplayEvents(List<string> events)
    {
        Console.WriteLine("Events:");
        foreach (var ev in events)
        {
            Console.WriteLine(ev);
        }
    }

    public string GetNewEvent()
    {
        Console.Write("Enter new event: ");
        return Console.ReadLine();
    }
}

// Usage
class Program
{
    static void Main()
    {
        var model = new EventModel();
        var view = new ConsoleEventView();
        var presenter = new EventPresenter(view, model);
        presenter.AddEvent();
        presenter.LoadEvents();
    }
}

//83
using System;
using System.Collections.Generic;

// Model
public class MovieModel
{
    private Dictionary<string, int> _movies = new Dictionary<string, int>();

    public void AddRating(string movie, int rating)
    {
        _movies[movie] = rating;
    }

    public Dictionary<string, int> GetMovies()
    {
        return _movies;
    }
}

// View Interface
public interface IMovieView
{
    void DisplayMovies(Dictionary<string, int> movies);
    string GetMovieName();
    int GetRating();
}

// Presenter
public class MoviePresenter
{
    private readonly IMovieView _view;
    private readonly MovieModel _model;

    public MoviePresenter(IMovieView view, MovieModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddRating()
    {
        var movie = _view.GetMovieName();
        var rating = _view.GetRating();
        _model.AddRating(movie, rating);
    }

    public void LoadMovies()
    {
        var movies = _model.GetMovies();
        _view.DisplayMovies(movies);
    }
}

// Example View Implementation (Console)
public class ConsoleMovieView : IMovieView
{
    public void DisplayMovies(Dictionary<string, int> movies)
    {
        Console.WriteLine("Movie Ratings:");
        foreach (var kvp in movies)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}/10");
        }
    }

    public string GetMovieName()
    {
        Console.Write("Enter movie name: ");
        return Console.ReadLine();
    }

    public int GetRating()
    {
        Console.Write("Enter rating (1-10): ");
        return int.Parse(Console.ReadLine());
    }
}

// Usage
class Program
{
    static void Main()
    {
        var model = new MovieModel();
        var view = new ConsoleMovieView();
        var presenter = new MoviePresenter(view, model);
        presenter.AddRating();
        presenter.LoadMovies();
    }
}

//84
using System;

// Model
public class TransferModel
{
    public decimal Balance { get; private set; } = 1000m;

    public bool Transfer(decimal amount)
    {
        if (amount > Balance) return false;
        Balance -= amount;
        return true;
    }
}

// View Interface
public interface ITransferView
{
    void DisplayBalance(decimal balance);
    decimal GetTransferAmount();
    void ShowTransferResult(bool success);
}

// Presenter
public class TransferPresenter
{
    private readonly ITransferView _view;
    private readonly TransferModel _model;

    public TransferPresenter(ITransferView view, TransferModel model)
    {
        _view = view;
        _model = model;
    }

    public void PerformTransfer()
    {
        var amount = _view.GetTransferAmount();
        var success = _model.Transfer(amount);
        _view.ShowTransferResult(success);
        _view.DisplayBalance(_model.Balance);
    }
}

// Example View Implementation (Console)
public class ConsoleTransferView : ITransferView
{
    public void DisplayBalance(decimal balance)
    {
        Console.WriteLine($"Current Balance: {balance:C}");
    }

    public decimal GetTransferAmount()
    {
        Console.Write("Enter transfer amount: ");
        return decimal.Parse(Console.ReadLine());
    }

    public void ShowTransferResult(bool success)
    {
        Console.WriteLine(success ? "Transfer successful!" : "Insufficient funds!");
    }
}

// Usage
class Program
{
    static void Main()
    {
        var model = new TransferModel();
        var view = new ConsoleTransferView();
        var presenter = new TransferPresenter(view, model);
        presenter.PerformTransfer();
    }
}

//85
using System;

// Model
public class WeatherModel
{
    public string GetWeather()
    {
        // Simulate API call
        return "Sunny, 25°C";
    }
}

// View Interface
public interface IWeatherView
{
    void DisplayWeather(string weather);
}

// Presenter
public class WeatherPresenter
{
    private readonly IWeatherView _view;
    private readonly WeatherModel _model;

    public WeatherPresenter(IWeatherView view, WeatherModel model)
    {
        _view = view;
        _model = model;
    }

    public void LoadWeather()
    {
        var weather = _model.GetWeather();
        _view.DisplayWeather(weather);
    }
}

// Example View Implementation (Console)
public class ConsoleWeatherView : IWeatherView
{
    public void DisplayWeather(string weather)
    {
        Console.WriteLine($"Current Weather: {weather}");
    }
}

// Usage
class Program
{
    static void Main()
    {
        var model = new WeatherModel();
        var view = new ConsoleWeatherView();
        var presenter = new WeatherPresenter(view, model);
        presenter.LoadWeather();
    }
}

//86
using System;

// Model
public class RouteModel
{
    public string CalculateRoute(string start, string end)
    {
        // Simulate calculation
        return $"Route from {start} to {end}: 10 km, 15 min";
    }
}

// View Interface
public interface IRouteView
{
    string GetStartPoint();
    string GetEndPoint();
    void DisplayRoute(string route);
}

// Presenter
public class RoutePresenter
{
    private readonly IRouteView _view;
    private readonly RouteModel _model;

    public RoutePresenter(IRouteView view, RouteModel model)
    {
        _view = view;
        _model = model;
    }

    public void CalculateRoute()
    {
        var start = _view.GetStartPoint();
        var end = _view.GetEndPoint();
        var route = _model.CalculateRoute(start, end);
        _view.DisplayRoute(route);
    }
}

// Example View Implementation (Console)
public class ConsoleRouteView : IRouteView
{
    public string GetStartPoint()
    {
        Console.Write("Enter start point: ");
        return Console.ReadLine();
    }

    public string GetEndPoint()
    {
        Console.Write("Enter end point: ");
        return Console.ReadLine();
    }

    public void DisplayRoute(string route)
    {
        Console.WriteLine(route);
    }
}

// Usage
class Program
{
    static void Main()
    {
        var model = new RouteModel();
        var view = new ConsoleRouteView();
        var presenter = new RoutePresenter(view, model);
        presenter.CalculateRoute();
    }
}

//87
using System;

// Model
public class FitnessModel
{
    public int Steps { get; private set; }

    public void AddSteps(int steps)
    {
        Steps += steps;
    }
}

// View Interface
public interface IFitnessView
{
    void DisplaySteps(int steps);
    int GetStepsToAdd();
}

// Presenter
public class FitnessPresenter
{
    private readonly IFitnessView _view;
    private readonly FitnessModel _model;

    public FitnessPresenter(IFitnessView view, FitnessModel model)
    {
        _view = view;
        _model = model;
    }

    public void UpdateSteps()
    {
        var steps = _view.GetStepsToAdd();
        _model.AddSteps(steps);
        _view.DisplaySteps(_model.Steps);
    }
}

// Example View Implementation (Console)
public class ConsoleFitnessView : IFitnessView
{
    public void DisplaySteps(int steps)
    {
        Console.WriteLine($"Total Steps: {steps}");
    }

    public int GetStepsToAdd()
    {
        Console.Write("Enter steps to add: ");
        return int.Parse(Console.ReadLine());
    }
}

// Usage
class Program
{
    static void Main()
    {
        var model = new FitnessModel();
        var view = new ConsoleFitnessView();
        var presenter = new FitnessPresenter(view, model);
        presenter.UpdateSteps();
    }
}

//88
using System;

// Model
public class MediaModel
{
    public bool IsPlaying { get; private set; }

    public void Play()
    {
        IsPlaying = true;
    }

    public void Pause()
    {
        IsPlaying = false;
    }
}

// View Interface
public interface IMediaView
{
    void ShowStatus(bool isPlaying);
    bool GetPlayCommand(); // true for play, false for pause
}

// Presenter
public class MediaPresenter
{
    private readonly IMediaView _view;
    private readonly MediaModel _model;

    public MediaPresenter(IMediaView view, MediaModel model)
    {
        _view = view;
        _model = model;
    }

    public void HandleCommand()
    {
        var play = _view.GetPlayCommand();
        if (play) _model.Play();
        else _model.Pause();
        _view.ShowStatus(_model.IsPlaying);
    }
}

// Example View Implementation (Console)
public class ConsoleMediaView : IMediaView
{
    public void ShowStatus(bool isPlaying)
    {
        Console.WriteLine(isPlaying ? "Playing" : "Paused");
    }

    public bool GetPlayCommand()
    {
        Console.Write("Enter 'play' or 'pause': ");
        return Console.ReadLine().ToLower() == "play";
    }
}

// Usage
class Program
{
    static void Main()
    {
        var model = new MediaModel();
        var view = new ConsoleMediaView();
        var presenter = new MediaPresenter(view, model);
        presenter.HandleCommand();
    }
}

//89
using System;

// Model
public class TranslatorModel
{
    public string Translate(string text)
    {
        // Simulate translation (English to Russian example)
        return text == "Hello" ? "Привет" : "Unknown";
    }
}

// View Interface
public interface ITranslatorView
{
    string GetTextToTranslate();
    void DisplayTranslation(string translation);
}

// Presenter
public class TranslatorPresenter
{
    private readonly ITranslatorView _view;
    private readonly TranslatorModel _model;

    public TranslatorPresenter(ITranslatorView view, TranslatorModel model)
    {
        _view = view;
        _model = model;
    }

    public void Translate()
    {
        var text = _view.GetTextToTranslate();
        var translation = _model.Translate(text);
        _view.DisplayTranslation(translation);
    }
}

// Example View Implementation (Console)
public class ConsoleTranslatorView : ITranslatorView
{
    public string GetTextToTranslate()
    {
        Console.Write("Enter text to translate: ");
        return Console.ReadLine();
    }

    public void DisplayTranslation(string translation)
    {
        Console.WriteLine($"Translation: {translation}");
    }
}

// Usage
class Program
{
    static void Main()
    {
        var model = new TranslatorModel();
        var view = new ConsoleTranslatorView();
        var presenter = new TranslatorPresenter(view, model);
        presenter.Translate();
    }
}

//90
using System;
using System.Collections.Generic;

// Model
public class CalendarModel
{
    private Dictionary<DateTime, string> _notes = new Dictionary<DateTime, string>();

    public void AddNote(DateTime date, string note)
    {
        _notes[date] = note;
    }

    public Dictionary<DateTime, string> GetNotes()
    {
        return _notes;
    }
}

// View Interface
public interface ICalendarView
{
    void DisplayNotes(Dictionary<DateTime, string> notes);
    DateTime GetDate();
    string GetNote();
}

// Presenter
public class CalendarPresenter
{
    private readonly ICalendarView _view;
    private readonly CalendarModel _model;

    public CalendarPresenter(ICalendarView view, CalendarModel model)
    {
        _view = view;
        _model = model;
    }

    public void AddNote()
    {
        var date = _view.GetDate();
        var note = _view.GetNote();
        _model.AddNote(date, note);
    }

    public void LoadNotes()
    {
        var notes = _model.GetNotes();
        _view.DisplayNotes(notes);
    }
}

// Example View Implementation (Console)
public class ConsoleCalendarView : ICalendarView
{
    public void DisplayNotes(Dictionary<DateTime, string> notes)
    {
        Console.WriteLine("Calendar Notes:");
        foreach (var kvp in notes)
        {
            Console.WriteLine($"{kvp.Key.ToShortDateString()}: {kvp.Value}");
        }
    }

    public DateTime GetDate()
    {
        Console.Write("Enter date (yyyy-mm-dd): ");
        return DateTime.Parse(Console.ReadLine());
    }

    public string GetNote()
    {
        Console.Write("Enter note: ");
        return Console.ReadLine();
    }
}

// Usage
class Program
{
    static void Main()
    {
        var model = new CalendarModel();
        var view = new ConsoleCalendarView();
        var presenter = new CalendarPresenter(view, model);
        presenter.AddNote();
        presenter.LoadNotes();
    }
}

//91
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

public interface IDataService
{
    Task<string> GetMessageAsync();
}

public class DataService : IDataService
{
    public Task<string> GetMessageAsync() => Task.FromResult("Привет от сервиса через DI!");
}

public interface IView
{
    void ShowMessage(string message);
}

public class ConsoleView : IView
{
    public void ShowMessage(string message) => Console.WriteLine(message);
}

public class MainPresenter
{
    private readonly IView _view;
    private readonly IDataService _service;

    public MainPresenter(IView view, IDataService service)
    {
        _view = view;
        _service = service;
    }

    public async Task StartAsync()
    {
        var msg = await _service.GetMessageAsync();
        _view.ShowMessage(msg);
    }
}

class Program
{
    static async Task Main()
    {
        var services = new ServiceCollection();
        services.AddTransient<IDataService, DataService>();
        services.AddTransient<IView, ConsoleView>();
        services.AddTransient<MainPresenter>();

        var provider = services.BuildServiceProvider();
        var presenter = provider.GetRequiredService<MainPresenter>();
        await presenter.StartAsync();
    }
}

//92
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public record Product(int Id, string Name, decimal Price);

public interface IProductRepository
{
    Task<List<Product>> GetAllAsync();
}

public class ProductRepository : IProductRepository
{
    public Task<List<Product>> GetAllAsync()
    {
        var list = new List<Product>
        {
            new(1, "iPhone 15", 120000m),
            new(2, "Samsung Galaxy", 95000m),
            new(3, "Xiaomi", 35000m)
        };
        return Task.FromResult(list);
    }
}

public interface IProductView
{
    void ShowProducts(List<Product> products);
}

public class ConsoleProductView : IProductView
{
    public void ShowProducts(List<Product> products)
    {
        Console.WriteLine("=== Каталог товаров ===");
        foreach (var p in products)
            Console.WriteLine($"{p.Id}. {p.Name} — {p.Price:C}");
    }
}

public class ProductPresenter
{
    private readonly IProductView _view;
    private readonly IProductRepository _repo;

    public ProductPresenter(IProductView view, IProductRepository repo)
    {
        _view = view;
        _repo = repo;
    }

    public async Task LoadAsync()
    {
        var products = await _repo.GetAllAsync();
        _view.ShowProducts(products);
    }
}

class Program
{
    static async Task Main()
    {
        var view = new ConsoleProductView();
        var repo = new ProductRepository();
        var presenter = new ProductPresenter(view, repo);
        await presenter.LoadAsync();
    }
}

//93
using System;
using System.Threading.Tasks;

public interface IWeatherService
{
    Task<string> GetWeatherAsync(string city);
}

public class WeatherService : IWeatherService
{
    public async Task<string> GetWeatherAsync(string city)
    {
        await Task.Delay(1200); // имитация сети
        return $"В {city}: +22°C, ясно";
    }
}

public interface IWeatherView
{
    void ShowLoading(bool loading);
    void ShowWeather(string weather);
    string GetCity();
}

public class ConsoleWeatherView : IWeatherView
{
    public void ShowLoading(bool loading) => Console.WriteLine(loading ? "Загрузка погоды..." : "Готово!");
    public void ShowWeather(string weather) => Console.WriteLine(weather);
    public string GetCity()
    {
        Console.Write("Введите город: ");
        return Console.ReadLine() ?? "Москва";
    }
}

public class WeatherPresenter
{
    private readonly IWeatherView _view;
    private readonly IWeatherService _service;

    public WeatherPresenter(IWeatherView view, IWeatherService service)
    {
        _view = view;
        _service = service;
    }

    public async Task LoadWeatherAsync()
    {
        _view.ShowLoading(true);
        try
        {
            var city = _view.GetCity();
            var result = await _service.GetWeatherAsync(city);
            _view.ShowWeather(result);
        }
        finally
        {
            _view.ShowLoading(false);
        }
    }
}

class Program
{
    static async Task Main()
    {
        var presenter = new WeatherPresenter(new ConsoleWeatherView(), new WeatherService());
        await presenter.LoadWeatherAsync();
    }
}

//94
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

public interface IUserService
{
    Task<string> GetUserNameAsync(int id);
}

public class CachedUserService : IUserService
{
    private readonly IMemoryCache _cache;

    public CachedUserService(IMemoryCache cache) => _cache = cache;

    public Task<string> GetUserNameAsync(int id)
    {
        return _cache.GetOrCreateAsync($"user_{id}", entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);
            return Task.FromResult($"Пользователь №{id} (из кэша)");
        });
    }
}

public interface IView
{
    void Show(string text);
}

public class ConsoleView : IView
{
    public void Show(string text) => Console.WriteLine(text);
}

public class UserPresenter
{
    private readonly IView _view;
    private readonly IUserService _service;

    public UserPresenter(IView view, IUserService service)
    {
        _view = view;
        _service = service;
    }

    public async Task LoadUserAsync(int id)
    {
        var name = await _service.GetUserNameAsync(id);
        _view.Show(name);
    }
}

class Program
{
    static async Task Main()
    {
        var services = new ServiceCollection();
        services.AddMemoryCache();
        services.AddTransient<IUserService, CachedUserService>();
        services.AddTransient<IView, ConsoleView>();
        services.AddTransient<UserPresenter>();

        var sp = services.BuildServiceProvider();
        var p = sp.GetRequiredService<UserPresenter>();

        await p.LoadUserAsync(7);
        await p.LoadUserAsync(7); // мгновенно — из кэша!
    }
}

//95
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IDataSource
{
    Task<string?> TryGetDataAsync();
}

public class ApiSource : IDataSource
{
    public async Task<string?> TryGetDataAsync()
    {
        await Task.Delay(300);
        return "Данные из API";
    }
}

public class CacheSource : IDataSource
{
    public Task<string?> TryGetDataAsync() => Task.FromResult<string?>("Данные из кэша");
}

public class DbSource : IDataSource
{
    public Task<string?> TryGetDataAsync() => Task.FromResult<string?>(null);
}

public class MultiSourceService
{
    private readonly IEnumerable<IDataSource> _sources;

    public MultiSourceService(IEnumerable<IDataSource> sources) => _sources = sources;

    public async Task<string> GetDataAsync()
    {
        foreach (var source in _sources)
        {
            var data = await source.TryGetDataAsync();
            if (data != null) return data;
        }
        return "Нет данных";
    }
}

class Program
{
    static async Task Main()
    {
        var sources = new IDataSource[] { new DbSource(), new CacheSource(), new ApiSource() };
        var service = new MultiSourceService(sources);
        var result = await service.GetDataAsync();
        Console.WriteLine(result); // Выведет: Данные из кэша
    }
}

//96
using System;
using System.Threading.Tasks;

public interface IView
{
    void Show(string text);
}

public class ConsoleView : IView
{
    public void Show(string text) => Console.WriteLine(text);
}

public class NewsPresenter
{
    public event EventHandler<string>? OnNews;

    private readonly IView _view;
    public NewsPresenter(IView view) => _view = view;

    public async Task LoadNewsAsync()
    {
        await Task.Delay(1000);
        string news = "Срочно: MVP работает идеально!";
        OnNews?.Invoke(this, news);
        _view.Show(news);
    }
}

class Program
{
    static async Task Main()
    {
        var view = new ConsoleView();
        var presenter = new NewsPresenter(view);

        presenter.OnNews += (s, n) => Console.WriteLine("Событие поймано: " + n);

        await presenter.LoadNewsAsync();
    }
}

//97
using System;

public record User(string Email, string Password);

public interface IValidator<T>
{
    bool Validate(T item, out string error);
}

public class UserValidator : IValidator<User>
{
    public bool Validate(User user, out string error)
    {
        if (string.IsNullOrWhiteSpace(user.Email) || !user.Email.Contains("@"))
        {
            error = "Неверный email";
            return false;
        }
        if (user.Password.Length < 6)
        {
            error = "Пароль должен быть не менее 6 символов";
            return false;
        }
        error = "";
        return true;
    }
}

public class LoginPresenter
{
    private readonly IValidator<User> _validator;

    public LoginPresenter(IValidator<User> validator) => _validator = validator;

    public void Login(User user)
    {
        if (_validator.Validate(user, out var error))
            Console.WriteLine("Вход успешен!");
        else
            Console.WriteLine("Ошибка: " + error);
    }
}

class Program
{
    static void Main()
    {
        var validator = new UserValidator();
        var presenter = new LoginPresenter(validator);

        presenter.Login(new User("test@example.com", "123456"));
        presenter.Login(new User("bad", "123"));
    }
}

//98
using System;
using System.Threading.Tasks;

public interface IApiService
{
    Task<string> GetDataAsync();
}

public class ApiService : IApiService
{
    private readonly Random _rnd = new();
    public async Task<string> GetDataAsync()
    {
        await Task.Delay(500);
        if (_rnd.Next(3) == 0) throw new Exception("Сервер недоступен");
        return "Данные получены";
    }
}

public class SafePresenter
{
    private readonly IApiService _api;

    public SafePresenter(IApiService api) => _api = api;

    public async Task LoadAsync()
    {
        try
        {
            Console.WriteLine("Загрузка...");
            var data = await _api.GetDataAsync();
            Console.WriteLine("Успех: " + data);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}

class Program
{
    static async Task Main()
    {
        var presenter = new SafePresenter(new ApiService());
        await presenter.LoadAsync();
    }
}

//99
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IRepository<T>
{
    Task<List<T>> GetPageAsync(int page, int pageSize);
}

public class PostRepository : IRepository<string>
{
    private readonly List<string> _posts = Enumerable.Range(1, 100)
        .Select(i => $"Пост #{i}").ToList();

    public Task<List<string>> GetPageAsync(int page, int pageSize)
    {
        var skip = (page - 1) * pageSize;
        var result = _posts.Skip(skip).Take(pageSize).ToList();
        return Task.FromResult(result);
    }
}

public class PostsPresenter
{
    private readonly IRepository<string> _repo;

    public PostsPresenter(IRepository<string> repo) => _repo = repo;

    public async Task ShowPageAsync(int page = 1, int size = 10)
    {
        var posts = await _repo.GetPageAsync(page, size);
        Console.WriteLine($"--- Страница {page} ---");
        foreach (var p in posts) Console.WriteLine(p);
    }
}

class Program
{
    static async Task Main()
    {
        var presenter = new PostsPresenter(new PostRepository());
        await presenter.ShowPageAsync(1);
        await presenter.ShowPageAsync(3);
    }
}

//100
using System;
using System.Threading.Tasks;

public interface IConnectivity { bool IsOnline { get; } }
public interface IStorage { Task SaveAsync(string data); Task<string> LoadAsync(); }
public interface IApi { Task<string> GetOnlineDataAsync(); }

public class NetworkConnectivity : IConnectivity { public bool IsOnline => DateTime.Now.Second % 2 == 0; }
public class LocalStorage : IStorage
{
    private string _data = "Старые данные (оффлайн)";
    public Task SaveAsync(string data) { _data = data; return Task.CompletedTask; }
    public Task<string> LoadAsync() => Task.FromResult(_data);
}
public class Api : IApi
{
    public Task<string> GetOnlineDataAsync() => Task.FromResult($"Онлайн данные: {DateTime.Now:T}");
}

public class SmartPresenter
{
    private readonly IConnectivity _net;
    private readonly IStorage _storage;
    private readonly IApi _api;

    public SmartPresenter(IConnectivity net, IStorage storage, IApi api)
    {
        _net = net; _storage = storage; _api = api;
    }

    public async Task LoadDataAsync()
    {
        if (_net.IsOnline)
        {
            var data = await _api.GetOnlineDataAsync();
            await _storage.SaveAsync(data);
            Console.WriteLine("Онлайн: " + data);
        }
        else
        {
            var cached = await _storage.LoadAsync();
            Console.WriteLine("Оффлайн: " + cached);
        }
    }
}

class Program
{
    static async Task Main()
    {
        var presenter = new SmartPresenter(new NetworkConnectivity(), new LocalStorage(), new Api());
        await presenter.LoadDataAsync();
    }
}