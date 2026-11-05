using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalResearchers.Entities;

namespace NationalResearchers.Data.Configurations;

public class ResearcherOrganizationAffiliationConfiguration
    : IEntityTypeConfiguration<ResearcherOrganizationAffiliation>
{
    public void Configure(
        EntityTypeBuilder<ResearcherOrganizationAffiliation> builder)
    {
        builder.HasKey(x => x.ResearcherOrganizationAffiliationId);

        builder.HasOne<Researcher>()
            .WithMany()
            .HasForeignKey(x => x.ResearcherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<Organization>()
            .WithMany()
            .HasForeignKey(x => x.OrganizationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => new
        {
            x.ResearcherId,
            x.OrganizationId
        });
    }
}
