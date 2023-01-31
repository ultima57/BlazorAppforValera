using EmployeeManagement.Models;

namespace EmployeeManagmentWeb.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;
        public EmployeeService(HttpClient httpClient) {

        }
        public async Task<IEnumerable<Employee>> GetEmployees() {
            return await httpClient.GetFromJsonAsync<Employee[]>("api/employees");
        }
    }
}
