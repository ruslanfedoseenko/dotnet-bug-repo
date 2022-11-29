namespace WebApplication2.Services;

public class SomeService : ISomeService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public SomeService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public void DoSmth()
    {
        var request = _httpContextAccessor.HttpContext.Request;
        request.EnableBuffering();
        var body = request.Body;
        body.Position = 0;
    }
}

public interface ISomeService
{
    void DoSmth();
}