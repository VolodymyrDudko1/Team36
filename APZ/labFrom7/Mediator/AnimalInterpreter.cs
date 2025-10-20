namespace labFrom7.Mediator;

public class AnimalInterpreter
{
    public Animal Animal{get;set;}
    public Human Human{get;set;}
    
    public void Speak( IComunicator comunicator)
    {
        if (comunicator.GetType() == typeof(Animal))
        {
            Human.Receive();
        }
        else
        {
            Animal.Receive();
        }
    }
}