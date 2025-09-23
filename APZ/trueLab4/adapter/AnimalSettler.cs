using trueLab4.bridge;

namespace trueLab4.adapter;

public class AnimalSettler
{
    public string SettleAnimal(Animal animal, IConfinable asylum)
    {
       return asylum.Confine(animal);
    }
}