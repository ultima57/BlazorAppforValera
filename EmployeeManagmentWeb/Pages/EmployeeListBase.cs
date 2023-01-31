using EmployeeManagement.Models;
using EmployeeManagmentWeb.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagmentWeb.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync() {
            Employees = (await EmployeeService.GetEmployees()).ToList();
            // await Task.Run(LoadEmployees);
            // return base.OnInitializedAsync();
        }

        private void LoadEmployees() {
            System.Threading.Thread.Sleep(1000);
            Employee e1 = new Employee {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",
                //   DateOfBrith = DateTime.UtcNow,
                Gender = Gender.Male,
                //  Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/john.png"
            };

            Employee e2 = new Employee {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                //   DateOfBrith = DateTime.UtcNow,
                Gender = Gender.Male,
                //   Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
                PhotoPath = "images/sam.jpg"
            };

            Employee e3 = new Employee {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                //   DateOfBrith = DateTime.UtcNow,
                Gender = Gender.Female,
                //   Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/mary.png"
            };

            Employee e4 = new Employee {
                EmployeeId = 3,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@pragimtech.com",
                //   DateOfBrith = DateTime.UtcNow,
                Gender = Gender.Female,
                //   Department = new Department { DepartmentId = 3, DepartmentName = "Payroll" },
                PhotoPath = "images/sara.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
