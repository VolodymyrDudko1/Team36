namespace trueLab4.bridge;

public abstract class Animal
{
    protected string _name;
    protected string _species;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Species
    {
        get { return _species; }
        set { _species = value; }
    }
    
}