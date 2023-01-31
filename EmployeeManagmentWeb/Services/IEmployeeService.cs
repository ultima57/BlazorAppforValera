using EmployeeManagement.Models;

namespace EmployeeManagmentWeb.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
