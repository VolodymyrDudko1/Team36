namespace Shelter;

public sealed class Logger
{
    private static readonly Lazy<Logger> _instance = new Lazy<Logger>(isThreadSafe: true);

    private Logger()
    {
        return;
    }
    public static Logger Instance => _instance.Value;

    public static void Log(string message)
    {
        Console.WriteLine(message+Environment.NewLine);
    }
    
}