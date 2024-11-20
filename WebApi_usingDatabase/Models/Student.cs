using System;
using System.Collections.Generic;

namespace WebApi_usingDatabase.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Gender { get; set; } = null!;
}
