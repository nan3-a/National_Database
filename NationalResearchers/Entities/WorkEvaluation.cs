using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class WorkEvaluation
{
    public int EvaluationId { get; set; }

    public string? EvaluationType { get; set; }

    public int? ResponseSpeed { get; set; }

    public int? CooperationQuality { get; set; }

    public int? CommitmentAndProcedureClarity { get; set; }

    public DateTime EvaluationDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
