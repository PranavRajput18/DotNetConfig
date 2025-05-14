namespace DotNetConfig;


public class MyService
{
    private readonly IConfiguration _configuration;

    public MyService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetMessage()
    {
        return _configuration["AppSettings:Message"];
    }
}

