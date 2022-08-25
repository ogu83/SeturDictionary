using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ReportService.Models
{
    public class Report
    {
        public enum ReportState { Preparing, Completed }

        [Key]
        public Guid UUID { get; set; }

        public ReportState State { get; set; }

        public int Details_Id { get; set; }

        public ReportDetails? Details { get; set; }
    }
}