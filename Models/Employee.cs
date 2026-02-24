using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Employee_React.Models;

public partial class Employee
{
    [Key]
    public int Id { get; set; }

    [StringLength(150)]
    public string FullName { get; set; } = null!;

    [StringLength(150)]
    public string Email { get; set; } = null!;

    [StringLength(20)]
    public string? Phone { get; set; }

    public DateOnly? Dob { get; set; }

    [StringLength(20)]
    public string? Gender { get; set; }

    [StringLength(100)]
    public string? Qualification { get; set; }

    public int? Experience { get; set; }

    [StringLength(100)]
    public string? Department { get; set; }

    [StringLength(100)]
    public string? Location { get; set; }

    public bool? TermsAccepted { get; set; }

    [StringLength(500)]
    public string? ResumePath { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }
}
