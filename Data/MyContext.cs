using Microsoft.EntityFrameworkCore;

namespace Data;

public class MyContext : DbContext
{
  public DbSet<Patient>? Patients { get; set; }
  public DbSet<Request>? Requests { get; set; }
  public DbSet<PrescribedTest>? PrescribedTests { get; set; }

  public MyContext()
  {

  }
  public MyContext(DbContextOptions options)
    : base(options)
  {

  }
}
