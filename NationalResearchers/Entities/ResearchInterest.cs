using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ResearchInterest
{
    public int ResearchInterestId { get; set; }

    public string? InterestName { get; set; }

    public string? InterestDescription { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

