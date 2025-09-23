namespace Shelter;

public sealed class Logger
{
    private static readonly Lazy<Logger> _instance = new Lazy<Logger>(isThreadSafe: true);

    public Logger()
    {
        return;
    }
    public static Logger Instance => _instance.Value;

    public void Log(string message)
    {
        Console.WriteLine(message+Environment.NewLine);
    }
    
}