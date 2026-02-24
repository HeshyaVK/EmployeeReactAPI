using Employee_React.Models;

namespace Employee_React.Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddAsync(Employee employee);
        Task<List<Employee>> GetAllAsync();
    }
}
