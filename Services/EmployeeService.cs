using Employee_React.DTOs;
using Employee_React.Models;
using Employee_React.Repository;

namespace Employee_React.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IWebHostEnvironment _environment;

        public EmployeeService(IEmployeeRepository repository, IWebHostEnvironment environment)
        {
            _repository = repository;
            _environment = environment;
        }
        public async Task<Employee> CreateEmployeeAsync(EmployeeCreateDto dto)
        {
            string? filePath = null;
            if (dto.Resume != null)
            {
                var uploadsFolder = Path.Combine(_environment.WebRootPath ?? "wwwroot", "resumes");

                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                var fileName = Guid.NewGuid() + Path.GetExtension(dto.Resume.FileName);
                var fullPath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await dto.Resume.CopyToAsync(stream);
                }

                filePath = "/resumes/" + fileName;

            }

            var employee = new Employee
            {
                FullName = dto.FullName,
                Email = dto.Email,
                Phone = dto.Phone,
                Dob = dto.Dob,
                Gender = dto.Gender,
                Qualification = dto.Qualification,
                Experience = dto.Experience,
                Department = dto.Department,
                Location = dto.Location,
                TermsAccepted = dto.TermsAccepted,
                ResumePath = filePath,
                CreatedDate = DateTime.Now
            };

            return await _repository.AddAsync(employee);


        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _repository.GetAllAsync(); 
        }
    }
}
