using System.Net.Http.Json;

namespace Bugs_in_Samples.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly HttpClient _http;

        public NorthwindService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<EmployeesType>?> GetEmployees()
        {
            return await this._http.GetFromJsonAsync<List<EmployeesType>>("/static-data/northwind-employees.json");
        }
    }
}