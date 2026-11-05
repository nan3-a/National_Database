using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ResearcherOrganizationAffiliation
{
    public int ResearcherOrganizationAffiliationId { get; set; }

    public int ResearcherId { get; set; }

    public int OrganizationId { get; set; }

    public string? Position { get; set; }

    public string? AffiliationSource { get; set; }

    public bool? IsPrimaryAffiliation { get; set; }

    public DateTime? AffiliationStartDate { get; set; }

    public DateTime? AffiliationEndDate { get; set; }

    public string? AcademicRank { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}


