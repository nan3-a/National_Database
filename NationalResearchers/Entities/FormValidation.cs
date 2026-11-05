using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class FormValidation
{
    public int FormValidationId { get; set; }

    //Foreign key for ...
    public int ResearcherId { get; set; }

    //Foreign key for ...
    public int ReviewerUserId { get; set; }


    public string? ValidationStatus { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public DateTime? ReviewDate { get; set; }

    public string? ReviewerName { get; set; }

    public string? ReviewDecision { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

