using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalResearchers.Entities;

namespace NationalResearchers.Data.Configurations;

public class ResearchSpecialtyAnnouncementConfiguration
    : IEntityTypeConfiguration<ResearchSpecialtyAnnouncement>
{
    public void Configure(
        EntityTypeBuilder<ResearchSpecialtyAnnouncement> builder)
    {
        builder.HasKey(x => x.ResearchSpecialtyAnnouncementId);

        builder.HasOne<ResearchSpecialty>()
            .WithMany()
            .HasForeignKey(x => x.ResearchSpecialtyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<EventAnnouncement>()
            .WithMany()
            .HasForeignKey(x => x.AnnouncementId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => new
        {
            x.ResearchSpecialtyId,
            x.AnnouncementId
        }).IsUnique();
    }
}
