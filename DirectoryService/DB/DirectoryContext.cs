using Microsoft.EntityFrameworkCore;
using DirectoryService.Models;

namespace DirectoryService.Data;

public class DirectoryContext : DbContext
{
    public DirectoryContext (DbContextOptions<DirectoryContext> options)
        : base(options)
    {
        
    }

    public DbSet<CommunicationInfo>? ConnectionInfos { get; set; }
    public DbSet<Person>? Person { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CommunicationInfo>().ToTable("CommunicationInfo");
        modelBuilder.Entity<Person>().ToTable("Person")
                                    .HasMany<CommunicationInfo>(x=>x.CommunicationInfos)
                                    .WithOne(x=>x.Person)
                                    .HasForeignKey(x=>x.Person_UUID);

    }
}