using System;
using System.Collections.Generic;

namespace task_2.Data.Entities;

public partial class StudentInfo
{
    public int Sid { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public decimal Cgpa { get; set; }
}
