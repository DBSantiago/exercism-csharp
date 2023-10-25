namespace LogLevels;

public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string stringDelimiter) =>
        str.Split(stringDelimiter)[1];

    public static string
        SubstringBetween(this string str, string stringStart, string stringEnd) =>
        str.SubstringAfter(stringStart).Split(stringEnd)[0];

    public static string Message(this string str) => str.SubstringAfter(": ");

    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}