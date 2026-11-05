using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ScientificProductionReport
{
    public int ScientificProductionReportId { get; set; }

    //Foreign key for ...
    public int ScientificProductionId { get; set; }


    public string? ReportType { get; set; }

    public string? ReportDescription { get; set; }

    public DateTime? ReportDate { get; set; }

    public string? ReportStatus { get; set; }


    public DateTime? ProcessingDate { get; set; }

    public string? ProcessingResult { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}


