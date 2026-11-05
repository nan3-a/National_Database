using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class Participation
{
    public int ParticipationId { get; set; }

    public string? EventName { get; set; }

    public string? EventType { get; set; }

    public string? ResearcherRole { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? City { get; set; }

    public string? OrganizingOrganizationName { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}