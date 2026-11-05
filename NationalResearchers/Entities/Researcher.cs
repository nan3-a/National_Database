using System;
using System.Collections.Generic;
using System.Text;

namespace NationalResearchers.Entities;

public class Researcher
{
    public int ResearcherId { get; set; }

    //Foreign key for ...
    public int UserId { get; set; }


    public string? NationalId { get; set; }

    public string? Name { get; set; }

    public string? AcademicIdentity { get; set; }

    public string? PersonalPhoto { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Gender { get; set; }

    public string? Orcid { get; set; }

    public string? CurriculumVitae { get; set; }

    public string? AcademicBiography { get; set; }

    public string? CurrentProfessionalTitle { get; set; }


    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}

