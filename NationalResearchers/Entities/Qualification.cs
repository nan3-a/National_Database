using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class Qualification
{
    public int QualificationId { get; set; }

    public string? QualificationSpecialization { get; set; }

    public string? QualificationDegree { get; set; }

    public string? GrantingOrganization { get; set; }

    public string? GrantingOrganizationCountry { get; set; }

    public int? QualificationYear { get; set; }

    public string? StatementStatus { get; set; }

    public string? DataSource { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

