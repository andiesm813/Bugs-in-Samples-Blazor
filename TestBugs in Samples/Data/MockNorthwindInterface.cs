namespace Bugs_in_Samples.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<EmployeesType>?> GetEmployees()
        {
            return Task.FromResult<List<EmployeesType>?>(new());
        }
    }
}