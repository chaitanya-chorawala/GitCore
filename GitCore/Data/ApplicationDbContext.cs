using GitCore.Models;
using Microsoft.EntityFrameworkCore;

namespace GitCore.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Employee> Employee { get; set; }
}
