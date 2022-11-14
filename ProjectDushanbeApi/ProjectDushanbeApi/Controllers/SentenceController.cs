using Microsoft.AspNetCore.Mvc;

namespace ProjectDushanbeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SentenceController : ControllerBase
{
    
    private readonly ILogger<SentenceController> _logger;

    public SentenceController(ILogger<SentenceController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTest")]
    public string Get()
    {
        return String.Empty;
    }
}