namespace labFrom7.Mediator;

public class Animal:IComunicator
{
    public AnimalInterpreter Interpreter{get; set;}  
    
    

    public void Speak()
    {
        Console.WriteLine("Animal says: Woof");
        Interpreter.Speak(this);
    }

    public void Receive()
    {
        Console.WriteLine("Animal receives: Woooof");
    }

    public Animal(AnimalInterpreter interpreter)
    {
        Interpreter=interpreter;
    }
}