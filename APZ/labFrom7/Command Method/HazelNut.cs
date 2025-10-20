namespace labFrom7.Command_Method;

public class HazelNut:Nut
{
    override public void Hit()
    {
        Console.WriteLine("Swooooooshhh");
        _target.ReceiveAHit();
    }

    public override void Undo()
    {
        Console.WriteLine("hooooouuup");
        _target.UnReceiveAHit();
    }

    public HazelNut(ITargetable target):base(target)
    { }
}