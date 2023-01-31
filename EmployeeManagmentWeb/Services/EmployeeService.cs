using EmployeeManagement.Models;

namespace EmployeeManagmentWeb.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;
        public EmployeeService(HttpClient httpClient) {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetEmployees() {
            var res = await httpClient.GetStringAsync("api/employees");
            Console.WriteLine(res);
            return await httpClient.GetFromJsonAsync<Employee[]>("api/employees");
        }
    }
}
