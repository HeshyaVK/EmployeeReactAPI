using Employee_React.DTOs;
using Employee_React.Models;

namespace Employee_React.Services
{
    public interface IEmployeeService
    {
        Task<Employee> CreateEmployeeAsync(EmployeeCreateDto dto);
        Task<List<Employee>> GetEmployeesAsync();
    }
}
