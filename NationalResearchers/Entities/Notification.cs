using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class Notification
{
    public int NotificationId { get; set; }

    //Foreign key for ...
    public int UserId { get; set; }


    public string? RelatedEntityType { get; set; }

    public string? NotificationType { get; set; }

    public string? NotificationText { get; set; }

    public string? SendingStatus { get; set; }

    public DateTime Timestamp { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

