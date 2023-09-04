namespace LoggerLib;

public interface ILogger
{
    LogLevel Level { get; set; }
    void Info(string message);
    void Warning(string message);
    void Error(string message);
}