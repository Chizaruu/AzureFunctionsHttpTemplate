using AzureFunctionsHttpTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace AzureFunctionsHttpTemplate.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Log> Logs { get; set; }
}