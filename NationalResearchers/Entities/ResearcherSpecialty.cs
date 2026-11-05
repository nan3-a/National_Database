using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ResearcherSpecialty
{
    public int ResearcherSpecialtyId { get; set; }

    public int ResearcherId { get; set; }

    public int ResearchSpecialtyId { get; set; }

    public string? DeterminationSource { get; set; }

    public int? SpecialtyOrder { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

