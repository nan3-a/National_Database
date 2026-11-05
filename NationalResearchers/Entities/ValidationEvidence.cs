using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ValidationEvidence
{
    public int ValidationEvidenceId { get; set; }

    //Foreign key for ...
    public int FieldReviewDetailId { get; set; }

    //Foreign key for ...
    public int UserId { get; set; }

    public string? EvidenceType { get; set; }

    public string? FileName { get; set; }

    public string? Description { get; set; }

    public string? StorageKey { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

