using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ResearcherQualification
{
    public int ResearcherQualificationId { get; set; }

    public int ResearcherId { get; set; }

    public int QualificationId { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

