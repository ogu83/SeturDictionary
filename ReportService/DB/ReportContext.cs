using Microsoft.EntityFrameworkCore;
// using ReportService.Models;

namespace DirectoryService.Data;

public class ReportContext : DbContext
{
    public ReportContext (DbContextOptions<ReportContext> options)
        : base(options)
    {
        
    }

    // public DbSet<CommunicationInfo>? CommunicationInfo { get; set; }
    // public DbSet<Person>? Person { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<CommunicationInfo>().ToTable("CommunicationInfo");
        // modelBuilder.Entity<Person>().ToTable("Person")
        //                             .HasMany<CommunicationInfo>(x=>x.CommunicationInfos)
        //                             .WithOne(x=>x.Person)
        //                             .HasForeignKey(x=>x.Person_UUID);

    }
}