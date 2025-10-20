namespace labFrom7.Mediator;

public interface IComunicator
{
    AnimalInterpreter Interpreter { get; set; }
    void Speak();
    void Receive();
}