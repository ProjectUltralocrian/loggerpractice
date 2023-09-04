namespace LoggerLib;

public class BetterLogger : ILogger
{
    public BetterLogger(StreamWriter sw)
    {
        _streamWriter = sw;
        _streamWriter.AutoFlush = true;
        Console.SetOut(_streamWriter);
    }

    public BetterLogger()
        : this(new StreamWriter(Console.OpenStandardOutput()))
    {

    }

    private StreamWriter _streamWriter;
    public LogLevel Level { get; set; } = LogLevel.WARNING;

    private void Log(string message, LogLevel level)
    {
        if (Level <= level)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("hh:mm:ss")} {level}] {message}");
        }
    }

    public void Info(string message) => Log(message, LogLevel.INFO);

    public void Warning(string message) => Log(message, LogLevel.WARNING);

    public void Error(string message) => Log(message, LogLevel.ERROR);
}