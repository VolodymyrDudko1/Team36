namespace labFrom7.Command_Method;

public class Showel:Nut
{
    override public void Hit()
    {
        Console.WriteLine("Fiiiiuuuuu");
        _target.ReceiveAHit();
    }

    public override void Undo()
    {
        Console.WriteLine("Foohhooooouuup");
        _target.UnReceiveAHit();
    }

    public Showel(ITargetable target):base(target)
    { }
}