using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace task_2.Data.Entities;

public partial class StudentInfo
{
    [Required]
    public int Sid { get; set; }
    [Required]
    public string Name { get; set; } = null!;
    [Required,EmailAddress]
    public string Email { get; set; } = null!;
    [Required,Phone]
    public string Phone { get; set; } = null!;
    [Required,Range(0.1,4)]
    public decimal Cgpa { get; set; }
}
