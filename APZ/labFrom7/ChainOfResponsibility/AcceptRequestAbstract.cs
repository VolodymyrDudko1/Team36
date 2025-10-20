namespace labFrom7.ChainOfResponsibility;

public abstract class AcceptRequestAbstract:IAnimalAcceptable<AcceptRequestAbstract>
{
    private AcceptRequestAbstract _nextHandler;

    public IAnimalAcceptable<AcceptRequestAbstract> SetNext(AcceptRequestAbstract acceptRequest)
    {
        _nextHandler = acceptRequest;
        return _nextHandler;
    }

    virtual public object Accept(object animal)
    {
        return _nextHandler.Accept(animal);
    }
}