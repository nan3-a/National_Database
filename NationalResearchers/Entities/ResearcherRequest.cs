using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ResearcherRequest
{
    public int ResearcherRequestId { get; set; }

    //Foreign key for ...
    public int UserId { get; set; }
    public int ResearcherId { get; set; }

    public string? RequestType { get; set; }

    public string? RequestDisplay { get; set; }

    public string? RequestDescription { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public string? RequestStatus { get; set; }

    public DateTime? ResponseDate { get; set; }

    public string? ResponseNote { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

