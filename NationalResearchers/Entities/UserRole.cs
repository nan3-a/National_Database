using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class UserRole
{
    public int UserRoleId { get; set; }

    public int UserId { get; set; }

    public int RoleId { get; set; }

    public string? OrganizationScope { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AppointmentDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}


