namespace MultipleApiInteraction.Utilities;

public class CustomHttpClient : HttpClient
{
    public CustomHttpClient()
    {
        BaseAddress = new("http://localhost:30911");
    }
}
