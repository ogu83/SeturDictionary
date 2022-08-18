using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DirectoryService.Models
{
    public class CommunicationInfo 
    {
        public enum CommunicationTypes { PhoneNumber, EMail, Location }

        [Key]
        public int Id { get; set; }

        [JsonIgnore]
        public Guid Person_UUID { get; set; }

        public CommunicationTypes ConnectionType { get; set; }

        public string? Content { get; set; }
    }

    public class Person
    {
        [Key]
        public Guid UUID { get; set; }
    }
}