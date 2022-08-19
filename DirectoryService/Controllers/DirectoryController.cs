using DirectoryService.Data;
using DirectoryService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var retval = _context.Person?.Include(x=>x.CommunicationInfos).AsEnumerable();
            return retval;
        }

        [HttpPost(Name = "AddPerson")]
        public Person AddPerson(Person p)
        {
            _context.Person?.Add(p);
            _context.SaveChanges();
            return p;
        }

        [HttpPost(Name = "DeletePerson")]
        public void DeletePerson(Guid id)
        {
            var person = _context.Person?.FirstOrDefault(x=>x.UUID == id);
            if (person == null)
                throw new ArgumentNullException("No such person");
            _context.Person?.Remove(person);
            _context.SaveChanges();
        }


        [HttpPost(Name = "AddCommInfoToPerson")]
        public void AddCommInfoToPerson(Guid personId, CommunicationInfo commInfo)
        {
            var person = _context.Person?.FirstOrDefault(x=>x.UUID == personId);
            if (person == null)
                throw new ArgumentNullException("No such person");

            if (person.CommunicationInfos == null)
                person.CommunicationInfos = new List<CommunicationInfo>();

            person.CommunicationInfos.Add(commInfo);

            _context.SaveChanges();
        } 

        
        [HttpPost(Name = "DeleteCommunicationInfo")]
        public void DeleteCommunicationInfo(int commInfoId)
        {
            var commInfo = _context.ConnectionInfos?.FirstOrDefault(x=>x.Id == commInfoId);
            if (commInfo == null)
                throw new ArgumentNullException("No such commInfo");
            _context.ConnectionInfos?.Remove(commInfo);
            _context.SaveChanges();
        }
    }
}