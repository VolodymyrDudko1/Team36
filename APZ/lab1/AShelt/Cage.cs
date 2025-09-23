namespace Shelter;

public class Cage : IPrototype
{
    public long CageId { get; set; }
    public Animal? CagedAnimal{get; set;}
    public IPrototype Clone()
    {
        Cage newCage = this.MemberwiseClone() as Cage;
        newCage.CageId += 1;
        newCage.CagedAnimal = null;
        return newCage;
    }
}