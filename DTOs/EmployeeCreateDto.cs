namespace Employee_React.DTOs
{
    public class EmployeeCreateDto
    {
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public String? Phone { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Gender { get; set; }
        public string? Qualification { get; set; }
        public int? Experience { get; set; }
        public string? Department { get; set; }
        public string? Location { get; set; }
        public bool? TermsAccepted { get; set; }

        public IFormFile? Resume { get; set; }
    }
}
