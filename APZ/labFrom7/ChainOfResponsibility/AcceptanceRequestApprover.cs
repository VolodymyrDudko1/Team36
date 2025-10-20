using System.Reflection.Metadata;

namespace labFrom7.ChainOfResponsibility;

public class AcceptanceRequestApprover:AcceptRequestAbstract
{
    private bool IsSpaceAvailable()
    {
        return true;
    }
    public override object Accept(object animal)
    {
        if (IsSpaceAvailable())
            return $"{animal} is accepted";
        else
        {
            return "no space available";
        }
    }
}