using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class Token
{
    public int TokenId { get; set; }

    //Foreign key for ...
    public int UserId { get; set; }


    public string? Type { get; set; }

    public string EncryptedValue { get; set; } = string.Empty;

    public DateTime ExpiresAt { get; set; }

    public bool IsUsed { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
