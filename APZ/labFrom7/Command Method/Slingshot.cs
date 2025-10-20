namespace labFrom7.Command_Method;

public class Slingshot
{
    private IShootable _nut;

    public Slingshot(IShootable nut)
    {
        _nut = nut;
    }

    public void Shoot()
    {
        _nut.Hit();
    }

    public void UnShoot()
    {
        _nut.Undo();
    }
}