namespace labFrom7.Command_Method;

public class Squirel:ITargetable
{
    public void ReceiveAHit()
    {
        Console.WriteLine("SQUEEEEEEEEAAAAAAAAK!");
    }

    public void UnReceiveAHit()
    {
        Console.WriteLine("!KAAAAAAAAAEEEEEEEUQS");
    }
}