namespace LoggerLib;

public class Logger : ILogger
{
    public LogLevel Level { get; set; } = LogLevel.INFO;

    public void Error(string message)
    {
        Console.WriteLine("LOG: " + message);
    }
    public void Info(string message)
    {
        Console.WriteLine("LOG: " + message);
    }
    public void Warning(string message)
    {
        Console.WriteLine("LOG: " + message);
    }
}