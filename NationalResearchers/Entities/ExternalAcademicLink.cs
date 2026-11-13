using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ExternalAcademicLink
{
    public int ExternalLinkId { get; set; }

    public int ResearcherId { get; set; }
    public string? PlatformName { get; set; }

    public string? AccountLink { get; set; }

    public string? LinkStatus { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

