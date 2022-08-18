using System.ComponentModel.DataAnnotations;

namespace DirectoryService.Models
{
    public class Person
    {
        [Key]
        public Guid UUID { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Company { get; set; }

        public List<CommunicationInfo>? CommunicationInfos { get; set; }
    }
}