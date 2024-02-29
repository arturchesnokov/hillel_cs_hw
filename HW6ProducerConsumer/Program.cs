namespace HW6ProducerConsumer;

class Program
{
    static Queue<int> _buffer = new Queue<int>();
    static object _locker = new object();
    private static bool _isProducerDone;
    private static bool _isConsumerDone;

    static void Main()
    {
        var producerThread = new Thread(Producer);
        var consumerThread = new Thread(Consumer);

        producerThread.Start();
        consumerThread.Start();

        producerThread.Join();
        consumerThread.Join();

        Log("All tasks are completed.");
    }

    static void Producer()
    {
        for (var i = 0; i < 10; i++)
        {
            lock (_locker)
            {
                while (_buffer.Count >= 5)
                {
                    Monitor.Wait(_locker);
                }

                int data = i + 1;
                _buffer.Enqueue(data);
                Log($"Produced: {data}");
                Monitor.Pulse(_locker);
            }

            Thread.Sleep(100);
        }

        lock (_locker)
        {
            _isProducerDone = true;
            Monitor.PulseAll(_locker);
        }
    }

    static void Consumer()
    {
        while (true)
        {
            lock (_locker)
            {
                while
                    (_buffer.Count == 0 && !_isProducerDone)
                {
                    Monitor.Wait(_locker);
                }

                if (_buffer.Count > 0)
                {
                    int data = _buffer.Dequeue();
                    Log($"Consumed: {data}");
                    Monitor.Pulse(_locker);
                }

                if (_buffer.Count == 0 && _isProducerDone)
                {
                    _isConsumerDone = true;
                    break;
                }
            }

            Thread.Sleep(200);
        }

        Log("Consumer finished its task.");
    }

    static void Log(string message)
    {
        const string logFilePath = "log.txt";
        try
        {
            using (var writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to write to log file: {ex.Message}");
        }
    }
}