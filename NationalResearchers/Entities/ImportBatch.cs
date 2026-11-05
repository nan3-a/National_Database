using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ImportBatch
{
    public int ImportBatchId { get; set; }

    public string? ImportSource { get; set; }

    public DateTime? ImportDate { get; set; }

    public string? BatchStatus { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

