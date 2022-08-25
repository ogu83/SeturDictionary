using System.ComponentModel.DataAnnotations;

namespace ReportService.Models
{
    public class ReportDetails
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public string? Location { get; set; }

        public int PersonCount { get; set; }

        public int PhoneNumberCount { get; set; }

        public Report? Report { get; set; }

        public Guid Report_UUID { get; set; }
    }
}