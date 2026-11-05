using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalResearchers.Entities;

namespace NationalResearchers.Data.Configurations;

public class ResearcherQualificationConfiguration
    : IEntityTypeConfiguration<ResearcherQualification>
{
    public void Configure(EntityTypeBuilder<ResearcherQualification> builder)
    {
        builder.HasKey(x => x.ResearcherQualificationId);

        builder.HasOne<Researcher>()
            .WithMany()
            .HasForeignKey(x => x.ResearcherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<Qualification>()
            .WithMany()
            .HasForeignKey(x => x.QualificationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => new { x.ResearcherId, x.QualificationId })
            .IsUnique();
    }
}

