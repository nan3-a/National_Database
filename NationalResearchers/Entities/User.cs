using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class User
{
    public int UserId { get; set; }

    public string? Name { get; set; } = string.Empty;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public DateTime? EmailConfirmedAt { get; set; }

    public DateTime AccountCreatedAt { get; set; }

    public string? AccountStatus { get; set; }

    public string? AccountType { get; set; }

    public string? PhoneNumber { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
