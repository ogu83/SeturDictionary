using Microsoft.AspNetCore.Mvc;

namespace ReportService.Controllers;

[ApiController]
[Route("[controller]")]
public class ReportsController : ControllerBase
{
    private readonly ILogger<ReportsController> _logger;

    public ReportsController(ILogger<ReportsController> logger)
    {
        _logger = logger;
    }
}
