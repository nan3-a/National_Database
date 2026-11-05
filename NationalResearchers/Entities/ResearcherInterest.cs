using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ResearcherInterest
{
    public int ResearcherInterestId { get; set; }

    public int ResearcherId { get; set; }

    public int ResearchInterestId { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
