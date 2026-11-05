using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class EventAnnouncement
{
    public int AnnouncementId { get; set; }

    public string? AnnouncementType { get; set; }

    public string? AnnouncementTitle { get; set; }

    public string? AnnouncementLink { get; set; }

    public string? EventLocation { get; set; }

    public DateTime? EventStartDate { get; set; }

    public DateTime? EventEndDate { get; set; }

    public DateTime? PublicationDate { get; set; }

    public string? AnnouncementStatus { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

