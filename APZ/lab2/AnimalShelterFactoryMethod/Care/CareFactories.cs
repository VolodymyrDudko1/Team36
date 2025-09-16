namespace AnimalShelterFactoryMethod.Care
{
    public sealed class DogCareFactory : IAnimalCareFactory
    {
        public IFood CreateFood() => new DogFood();
        public IBed  CreateBed()  => new DogBed();
        public IToy  CreateToy()  => new DogToy();
    }

    public sealed class CatCareFactory : IAnimalCareFactory
    {
        public IFood CreateFood() => new CatFood();
        public IBed  CreateBed()  => new CatBed();
        public IToy  CreateToy()  => new CatToy();
    }

    public sealed class RabbitCareFactory : IAnimalCareFactory
    {
        public IFood CreateFood() => new RabbitFood();
        public IBed  CreateBed()  => new RabbitBed();
        public IToy  CreateToy()  => new RabbitToy();
    }
}
