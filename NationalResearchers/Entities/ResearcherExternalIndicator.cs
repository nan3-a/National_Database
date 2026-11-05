using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ResearcherExternalIndicator
{
    public int ResearcherExternalIndicatorId { get; set; }

    //Foreign key for ...
    public int ResearcherId { get; set; }

    //Foreign key for ...
    public int IndicatorDefinitionId { get; set; }
    

    public string? IndicatorType { get; set; }

    public string? Value { get; set; }

    public string? Source { get; set; }

    public DateTime? CapturedAt { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
