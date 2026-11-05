using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalResearchers.Entities;

namespace NationalResearchers.Data.Configurations;

public class ResearcherScientificProductionConfiguration
    : IEntityTypeConfiguration<ResearcherScientificProduction>
{
    public void Configure(
        EntityTypeBuilder<ResearcherScientificProduction> builder)
    {
        builder.HasKey(x => x.ResearcherScientificProductionId);

        builder.HasOne<Researcher>()
            .WithMany()
            .HasForeignKey(x => x.ResearcherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<ScientificProduction>()
            .WithMany()
            .HasForeignKey(x => x.ScientificProductionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => new
        {
            x.ResearcherId,
            x.ScientificProductionId
        }).IsUnique();
    }
}
