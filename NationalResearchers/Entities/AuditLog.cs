using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class AuditLog
{
    public int AuditLogId { get; set; }

    //Foreign key for ...
    public int UserId { get; set; }


    public string? BeforeValue { get; set; }

    public string? AfterValue { get; set; }

    public string? OperationType { get; set; }

    public string? AffectedEntity { get; set; }

    public DateTime Timestamp { get; set; }

    public string? IpAddress { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}


