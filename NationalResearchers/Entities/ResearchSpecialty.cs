using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ResearchSpecialty
{
    public int ResearchSpecialtyId { get; set; }

    public string? SpecialtyName { get; set; }

    public string? SpecialtyDescription { get; set; }

    public string? AvailabilityStatus { get; set; }

    public DateTime? AddedAt { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

