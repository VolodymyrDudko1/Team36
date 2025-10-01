namespace lab6.proxy;

public class AdoptionRequestProxy
{
    private IAdoptionRequest _adoptionRequest;
    private bool _isAuthenticated;
    private readonly string _password="password";
    

    public IAdoptionRequest AccessRequest()
    {
        if (_isAuthenticated)
        {
            _adoptionRequest = new SimpleAdoptionRequest();
            return _adoptionRequest;
        }
        else
        {
            throw new AccessViolationException();
        }
    }

    public AdoptionRequestProxy Authenticate(string passwordEntered)
    {
        if (passwordEntered == _password)
        {
            _isAuthenticated = true;
        }

        return this;
    }
    
}