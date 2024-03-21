﻿public sealed class Logger
{
    private static readonly Logger instance = new Logger();

    private Logger()
    {
    }

    public static Logger Instance
    {
        get
        {
            return instance;
        }
    }

    public void Log(LogLevel level, string message)
    {
        switch (level)
        {
            case LogLevel.Comment:
                Console.WriteLine($"Comment: {message}");
                break;
            case LogLevel.Warning:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Warning: {message}");
                Console.ResetColor();
                break;
            case LogLevel.Error:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {message}");
                Console.ResetColor();
                if (level == LogLevel.Error)
                {
                    Environment.Exit(1);
                }
                break;
        }
    }
}

public enum LogLevel
{
    Comment,
    Warning,
    Error
}