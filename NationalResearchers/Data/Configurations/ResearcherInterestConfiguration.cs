using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalResearchers.Entities;

namespace NationalResearchers.Data.Configurations;

public class ResearcherInterestConfiguration
    : IEntityTypeConfiguration<ResearcherInterest>
{
    public void Configure(EntityTypeBuilder<ResearcherInterest> builder)
    {
        builder.HasKey(x => x.ResearcherInterestId);

        builder.HasOne<Researcher>()
            .WithMany()
            .HasForeignKey(x => x.ResearcherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<ResearchInterest>()
            .WithMany()
            .HasForeignKey(x => x.ResearchInterestId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => new
        {
            x.ResearcherId,
            x.ResearchInterestId
        }).IsUnique();
    }
}
