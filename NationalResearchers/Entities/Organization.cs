using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class Organization
{
    public int OrganizationId { get; set; }

    public string? OrganizationName { get; set; }

    public string? Country { get; set; }

    public DateTime? AddedAt { get; set; }

    public string? AccreditationStatus { get; set; }

    public string? OrganizationType { get; set; }

    public string? DetailedAddress { get; set; }

    public int? ParentOrganizationId { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

