using Data;
using Data.Tests;
using Microsoft.EntityFrameworkCore;

namespace HotChocolateDemo.Queries;

public class QueryPatients
{
  private readonly SqlServerDockerTest _testEnvironment;
  public QueryPatients(SqlServerDockerTest testEnvironment)
  {
    _testEnvironment = testEnvironment;
  }
  public async Task<List<Patient>> GetPatientsAsync()
  {
    await _testEnvironment.InitializeAsync();

    var optionsBuilder = _testEnvironment.GetDbContextBuilder();
    using (var context = new MyContext(optionsBuilder.Options)) 
    {
      return (context?
        .Patients?
        .Include(p => p.Requests)
        .ThenInclude(r => r.PrescribedTests)
        .ToList() ?? Enumerable.Empty<Patient>().ToList());
    }
  }

}
