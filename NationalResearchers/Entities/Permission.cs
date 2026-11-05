using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class Permission
{
    public int PermissionId { get; set; }

    public string Name { get; set; }

    public string? Category { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}


