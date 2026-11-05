using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class IndicatorSnapshot
{
    public int IndicatorSnapshotId { get; set; }

    //Foreign key for ...
    public int IndicatorDefinitionId { get; set; }


    public string? IndicatorValue { get; set; }

    public DateTime? PeriodStartDate { get; set; }

    public DateTime? PeriodEndDate { get; set; }

    public DateTime CalculationTimestamp { get; set; }

    public string? DataQualityStatus { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

