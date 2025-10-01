namespace lab6;

public class SimpleAdoptionRequest: IAdoptionRequest
{
    internal SimpleAdoptionRequest()
    {
        
    }
    public string MakeRequest()
    {
        return "Adoption request is being processed";
    }
}