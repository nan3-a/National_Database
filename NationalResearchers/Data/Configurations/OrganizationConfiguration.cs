using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalResearchers.Entities;

namespace NationalResearchers.DataS.Configurations;

public class OrganizationConfiguration
    : IEntityTypeConfiguration<Organization>
{
    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        builder.HasKey(x => x.OrganizationId);

        builder.HasOne<Organization>()
            .WithMany()
            .HasForeignKey(x => x.ParentOrganizationId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
