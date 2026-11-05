using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalResearchers.Entities;

namespace NationalResearchers.Data.Configurations;

public class ResearcherSpecialtyConfiguration
    : IEntityTypeConfiguration<ResearcherSpecialty>
{
    public void Configure(EntityTypeBuilder<ResearcherSpecialty> builder)
    {
        builder.HasKey(x => x.ResearcherSpecialtyId);

        builder.HasOne<Researcher>()
            .WithMany()
            .HasForeignKey(x => x.ResearcherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<ResearchSpecialty>()
                .WithMany()
                .HasForeignKey(x => x.ResearchSpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => new
        {
            x.ResearcherId,
            x.ResearchSpecialtyId
        }).IsUnique();
    }
}
