using ReportService.Models;
using Microsoft.EntityFrameworkCore;

namespace DirectoryService.Data;

public class ReportContext : DbContext
{
    public ReportContext(DbContextOptions<ReportContext> options)
        : base(options)
    {

    }

    public DbSet<Report>? Report { get; set; }
    public DbSet<ReportDetails>? ReportDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Report>().ToTable("Report")
                                     .HasOne<ReportDetails>(x => x.Details)
                                     .WithOne(x => x.Report)
                                     .HasForeignKey<ReportDetails>(x => x.Report_UUID);
        modelBuilder.Entity<ReportDetails>().ToTable("ReportDetails")
                                     .HasOne<Report>(x => x.Report)
                                     .WithOne(x => x.Details)
                                     .HasForeignKey<Report>(x => x.Details_Id);
    }
}