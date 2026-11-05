using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalResearchers.Entities;

namespace NationalResearchers.Data.Configurations;

public class ResearcherParticipationConfiguration
    : IEntityTypeConfiguration<ResearcherParticipation>
{
    public void Configure(EntityTypeBuilder<ResearcherParticipation> builder)
    {
        builder.HasKey(x => x.ResearcherParticipationId);

        builder.HasOne<Researcher>()
            .WithMany()
            .HasForeignKey(x => x.ResearcherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<Participation>()
            .WithMany()
            .HasForeignKey(x => x.ParticipationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => new
        {
            x.ResearcherId,
            x.ParticipationId
        }).IsUnique();
    }
}

