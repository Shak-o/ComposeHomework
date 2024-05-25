using Microsoft.EntityFrameworkCore;
using VeryComplexApp.Api.Models;

namespace VeryComplexApp.Api.Infrastructure;

public class ComplexDbContext : DbContext
{
    public ComplexDbContext(DbContextOptions<ComplexDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Person> Persons { get; set; }
}