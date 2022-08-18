using DirectoryService.Data;
using DirectoryService.Models;
using Microsoft.AspNetCore.Mvc;

namespace DirectoryService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectoryController : ControllerBase
    {
        private readonly ILogger<DirectoryController> _logger;
        private readonly DirectoryContext _context;

        public DirectoryController(ILogger<DirectoryController> logger, DirectoryContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetPersons")]
        public IEnumerable<Person>? Get()
        {
            return _context.Person?.AsEnumerable();
        }
    }
}