using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class ResearchSpecialtyAnnouncement
{
    public int ResearchSpecialtyAnnouncementId { get; set; }

    public int ResearchSpecialtyId { get; set; }

    public int AnnouncementId { get; set; }

    //public string? TargetSpecialty { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
