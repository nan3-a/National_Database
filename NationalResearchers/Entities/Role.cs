using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class Role
{
    public int RoleId { get; set; }

    public string Name { get; set; }

    public int? PermissionLevel { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
