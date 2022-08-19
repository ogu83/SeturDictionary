using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DirectoryService.Models
{
    public class Person
    {
        [Key]
        public Guid UUID { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Company { get; set; }

        [JsonIgnore]
        public List<CommunicationInfo>? CommunicationInfos { get; set; }
    }
}