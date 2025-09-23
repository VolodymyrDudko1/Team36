namespace Shelter;

class Program
{
    static void Main(string[] args)
    {
        Cage a=new Cage();
        Cage b= a.Clone() as Cage;
        Console.WriteLine(a.CageId + b.CageId);
		Logger.Instance.Log("uhscuh");
    }
}