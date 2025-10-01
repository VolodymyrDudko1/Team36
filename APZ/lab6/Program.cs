using lab6.proxy;
using Microsoft.Extensions.DependencyInjection;
namespace lab6;






class Program
{
    
    static void Main(string[] args)
    {

        var services = new ServiceCollection();
        
        
        
        services.AddTransient<Func<string, IAdoptionRequest>>(provider => password=>
            new AdoptionRequestProxy().Authenticate(password).AccessRequest());
        
        var serviceProvider = services.BuildServiceProvider();
        
        var secureRequestFactory = serviceProvider.GetService<Func<string,IAdoptionRequest>>();
         
        LoggerAdoptionRequest request =new LoggerAdoptionRequest(secureRequestFactory("password"));
        Console.WriteLine(request.MakeRequest()+Environment.NewLine);
    }
}