namespace Observer;

public class LoggingListener(string logFile, string message) : IEventListener {
    private readonly string logFile = logFile;
    private readonly string message = message;

    public void Update(string filename) {
        Console.WriteLine($"Log: {string.Format(message, filename)} to {logFile}");
    }
}