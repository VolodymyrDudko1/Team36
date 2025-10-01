using System.Transactions;

namespace lab6;

public class LoggerAdoptionRequest:AdoptionRequestDecorator
{
    public LoggerAdoptionRequest(IAdoptionRequest e):base(e) { }

    public override string MakeRequest()
    {
        Console.Write("Request has been made"+Environment.NewLine);
        return base.MakeRequest();
    }
}