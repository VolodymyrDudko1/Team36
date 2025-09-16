namespace AnimalShelterFactoryMethod.Care
{
    public interface IAnimalCareFactory
    {
        IFood CreateFood();
        IBed  CreateBed();
        IToy  CreateToy();
    }
}