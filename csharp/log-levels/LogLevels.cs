using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine
        .Replace("[ERROR]:", "")
        .Replace("[WARNING]:", "")
        .Replace("[INFO]:", "")
        .Trim();
    }

    public static string LogLevel(string logLine)
    {
        if (logLine.IndexOf("ERROR") == 1)
        {
            int first = logLine.IndexOf("ERROR");
            int last = first + "ERROR".Length - 1;
            string str2 = logLine.Substring(first, last).ToLower();
            return str2;
        }
        else if (logLine.IndexOf("WARNING") == 1)
        {
            int first = logLine.IndexOf("WARNING");
            int last = first + "WARNING".Length - 1;
            string str2 = logLine.Substring(first, last).ToLower();
            return str2;
        }
        else if (logLine.IndexOf("INFO") == 1)
        {
            int first = logLine.IndexOf("INFO");
            int last = first + "INFO".Length - 1;
            string str2 = logLine.Substring(first, last).ToLower();
            return str2;
        }
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        return $"{LogLine.Message(logLine)} ({LogLine.LogLevel(logLine)})";
    }
}
