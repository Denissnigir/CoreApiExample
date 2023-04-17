using System;
using System.Collections.Generic;

namespace WebApplication2.Model;

public partial class User
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public string? Mail { get; set; }

    public string? PhoneNumber { get; set; }

    public string? RoleId { get; set; }

    public string? FirstName { get; set; }

    public string? SecondName { get; set; }

    public string? ThirdName { get; set; }

    public int? CompanyId { get; set; }

    public string? Note { get; set; }

    public int? PassportSeries { get; set; }

    public int? PassportNumber { get; set; }

    public byte[]? Photo { get; set; }

    public string? BirthDate { get; set; }
}
