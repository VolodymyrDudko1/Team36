namespace AnimalShelterFactoryMethod.Domain
{
    public sealed class Adopter
    {
        public Adopter(string fullName, string phone) { FullName = fullName; Phone = phone; }
        public string FullName { get; }
        public string Phone { get; }
    }
}
