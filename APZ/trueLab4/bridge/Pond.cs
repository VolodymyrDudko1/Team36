namespace trueLab4.bridge;

public class Pond:IConfinable
{
    private Animal _animal;
    
    public string Confine(Animal animal)
    {
        _animal = animal;
        return $"The {_animal.Name} is in the pond";
    }
}