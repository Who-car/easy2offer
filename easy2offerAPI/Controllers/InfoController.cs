using easy2offerAPI.Dto;
using Microsoft.AspNetCore.Mvc;
using ILogger = Serilog.ILogger;

namespace easy2offerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class InfoController : ControllerBase
{
    private readonly ILogger _logger;

    public InfoController(ILogger logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ApiInfoDto GetApiInfo()
    {
        var result = new ApiInfoDto
        {
            Name = "easy2offer",
            Version = "0.0.0",
            Description =
                "Easy2Offer is a personalized website for analyzing current IT job openings in Russia. "
                + "Stay up-to-date with the latest tech vacancies and find your dream job effortlessly."
        };
        _logger
            .Information("request api info {@Result}", result);
        return result;
    }
}
