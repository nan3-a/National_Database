using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class FieldReviewDetail
{
    public int FieldReviewDetailId { get; set; }

    //Foreign key for ...
    public int FormValidationId { get; set; }


    public string? EntityName { get; set; }

    public int? OriginalRecordId { get; set; }

    public string? FieldName { get; set; }

    public string? FieldValue { get; set; }

    public string? FieldStatus { get; set; }

    public bool? IsValid { get; set; }

    public string? RejectionReason { get; set; }

    public string? ReviewerNotes { get; set; }

    public string? ReviewDecision { get; set; }

    public DateTime? ReviewDate { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
