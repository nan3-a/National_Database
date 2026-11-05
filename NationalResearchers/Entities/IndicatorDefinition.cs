using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class IndicatorDefinition
{
    public int IndicatorDefinitionId { get; set; }

    public string? IndicatorName { get; set; }

    public string? IndicatorDescription { get; set; }

    public string? DisplayScope { get; set; }

    public string? UpdateFrequency { get; set; }

    public DateTime? ImplementationStartDate { get; set; }

    public string? Status { get; set; }

    public string? MeasurementUnit { get; set; }

    public string? CalculationFormula { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

