using ExemploGtkNet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExemploGtkNet8;

public class ExemploContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }

    public ExemploContext(DbContextOptions<ExemploContext> options)
        : base (options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExemploContext).Assembly);
    }
}