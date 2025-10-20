using System.Reflection.Metadata;

namespace labFrom7.ChainOfResponsibility;

public class AcceptRequest:AcceptRequestAbstract
{
    public AcceptRequest()
    {
        SetNext(new AcceptanceRequestApprover());
    }
}