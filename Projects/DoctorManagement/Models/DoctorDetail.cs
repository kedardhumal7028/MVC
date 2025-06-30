using System;
using System.Collections.Generic;

namespace DoctorManagement.Models;

public partial class DoctorDetail
{
    public int DoctorId { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime Dob { get; set; }

    public int Age { get; set; }

    public string Gender { get; set; } = null!;

    public string Education { get; set; } = null!;

    public string MobileNo1 { get; set; } = null!;

    public string? MobileNo2 { get; set; }

    public string AaddharNo { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public string Address { get; set; } = null!;
}
