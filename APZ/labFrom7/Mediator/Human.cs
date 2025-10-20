namespace labFrom7.Mediator;

public class Human: IComunicator
{
    public AnimalInterpreter Interpreter{get; set;}  
    
    

    public void Speak()
    {
        Console.WriteLine("Human says: Hi");
        Interpreter.Speak(this);
    }

    public void Receive()
    {
        Console.WriteLine("Human receives: Hii");
        
    }

    public Human(AnimalInterpreter interpreter)
    {
        Interpreter=interpreter;
    }
}