namespace Bugs_in_Samples.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>?> GetEmployees();
    }
}