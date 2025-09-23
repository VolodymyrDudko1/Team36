using trueLab4.bridge;
using trueLab4.adapter;

namespace trueLab4;

class Program
{
    static void Main(string[] args)
    {
        Dog darkLordCorvaxTheUnmerciful = new Dog("DarkLordCorvaxTheUnmerciful","Chihuahua");
        Crocodile sunshine = new Crocodile("Sunshine","Crocodile");

        var pond = new Pond();
        var kennel = new Kennel();

        var settler = new AnimalSettler();
        
        Console.WriteLine(settler.SettleAnimal(darkLordCorvaxTheUnmerciful, pond));
        Console.WriteLine(settler.SettleAnimal(sunshine, kennel));
        
        
    }
}