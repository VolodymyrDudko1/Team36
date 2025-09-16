namespace AnimalShelterFactoryMethod.Care
{
    public interface IFood { string Describe(); decimal Price { get; } }
    public interface IBed  { string Describe(); decimal Price { get; } }
    public interface IToy  { string Describe(); decimal Price { get; } }

    // ----- Dog family -----
    public sealed class DogFood : IFood { public decimal Price => 700m; public string Describe() => "Сухий корм для собак 12кг"; }
    public sealed class DogBed  : IBed  { public decimal Price => 1200m; public string Describe() => "Лігво XL з бортиками"; }
    public sealed class DogToy  : IToy  { public decimal Price => 250m; public string Describe() => "Гумова кістка"; }

    // ----- Cat family -----
    public sealed class CatFood : IFood { public decimal Price => 500m; public string Describe() => "Сухий корм для котів 8кг"; }
    public sealed class CatBed  : IBed  { public decimal Price => 800m;  public string Describe() => "Будиночок для кота"; }
    public sealed class CatToy  : IToy  { public decimal Price => 180m;  public string Describe() => "Пухнаста вудка"; }

    // ----- Rabbit family -----
    public sealed class RabbitFood : IFood { public decimal Price => 300m; public string Describe() => "Комбікорм + сіно"; }
    public sealed class RabbitBed  : IBed  { public decimal Price => 450m; public string Describe() => "М'яка підстилка для клітки"; }
    public sealed class RabbitToy  : IToy  { public decimal Price => 90m;  public string Describe() => "Дерев'яний гризунець"; }
}
