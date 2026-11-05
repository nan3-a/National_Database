using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ResearcherScientificProduction
{
    public int ResearcherScientificProductionId { get; set; }

    public int ResearcherId { get; set; }

    public int ScientificProductionId { get; set; }

    public string? AuthorName { get; set; }

    public string? AuthorRole { get; set; }

    public int? AuthorOrder { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}


