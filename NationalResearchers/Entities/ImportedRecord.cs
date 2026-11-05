using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ImportedRecord
{
    public int ImportedRecordId { get; set; }

    //Foreign key for ...
    public int ImportBatchId { get; set; }


    public string? ImportedName { get; set; }

    public string? ExternalReference { get; set; }

    public string? ImportedOrganization { get; set; }

    public string? RecordStatus { get; set; }

    public string? MatchingScore { get; set; }

    public string? ReviewDecision { get; set; }

    public DateTime? ReviewDate { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
