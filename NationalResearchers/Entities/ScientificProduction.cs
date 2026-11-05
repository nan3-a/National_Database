using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ScientificProduction
{
    public int ScientificProductionId { get; set; }

    public string? ScientificProductionTitle { get; set; }

    public string? Doi { get; set; }

    public string? ScientificProductionAbstract { get; set; }

    public string? Keywords { get; set; }

    public string? SourceRecord { get; set; }

    public string? SourceLink { get; set; }

    public string? PublisherName { get; set; }

    public string? ScientificProductionLanguage { get; set; }

    public string? ScientificProductionType { get; set; }

    public string? ScientificProductionClassification { get; set; }

    public string? ScientificProductionStatus { get; set; }

    public int? PublicationYear { get; set; }

    public string? Issn { get; set; }

    public string? Isbn { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
