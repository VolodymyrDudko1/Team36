namespace lab6;

public class AdoptionRequestDecorator:IAdoptionRequest
{
    private readonly IAdoptionRequest _adoptionRequest;

    public AdoptionRequestDecorator(IAdoptionRequest request)
    {
        _adoptionRequest = request;
    }

    public virtual string MakeRequest()
    {
        return _adoptionRequest.MakeRequest();
    }
}