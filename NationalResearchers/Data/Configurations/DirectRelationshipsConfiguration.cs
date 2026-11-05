using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalResearchers.Entities;

namespace NationalResearchers.Data.Configurations;

public class DirectRelationshipsConfiguration :
    IEntityTypeConfiguration<Token>,
    IEntityTypeConfiguration<AuditLog>,
    IEntityTypeConfiguration<Notification>,
    IEntityTypeConfiguration<Researcher>,
    IEntityTypeConfiguration<ResearcherRequest>,
    IEntityTypeConfiguration<ScientificProductionReport>,
    IEntityTypeConfiguration<IndicatorSnapshot>,
    IEntityTypeConfiguration<ResearcherExternalIndicator>,
    IEntityTypeConfiguration<FormValidation>,
    IEntityTypeConfiguration<FieldReviewDetail>,
    IEntityTypeConfiguration<ValidationEvidence>,
    IEntityTypeConfiguration<ImportedRecord>
{
    public void Configure(EntityTypeBuilder<Token> builder)
    {
        builder.HasKey(x => x.TokenId);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public void Configure(EntityTypeBuilder<AuditLog> builder)
    {
        builder.HasKey(x => x.AuditLogId);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder.HasKey(x => x.NotificationId);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public void Configure(EntityTypeBuilder<Researcher> builder)
    {
        builder.HasKey(x => x.ResearcherId);

        builder.HasOne<User>()
            .WithOne()
            .HasForeignKey<Researcher>(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public void Configure(EntityTypeBuilder<ResearcherRequest> builder)
    {
        builder.HasKey(x => x.ResearcherRequestId);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public void Configure(EntityTypeBuilder<ScientificProductionReport> builder)
    {
        builder.HasKey(x => x.ScientificProductionReportId);

        builder.HasOne<ScientificProduction>()
            .WithMany()
            .HasForeignKey(x => x.ScientificProductionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
    public void Configure(EntityTypeBuilder<IndicatorSnapshot> builder)
    {
        builder.HasKey(x => x.IndicatorSnapshotId);

        builder.HasOne<IndicatorDefinition>()
            .WithMany()
            .HasForeignKey(x => x.IndicatorDefinitionId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public void Configure(
        EntityTypeBuilder<ResearcherExternalIndicator> builder)
    {
        builder.HasKey(x => x.ResearcherExternalIndicatorId);

        builder.HasOne<Researcher>()
            .WithMany()
            .HasForeignKey(x => x.ResearcherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<IndicatorDefinition>()
            .WithMany()
            .HasForeignKey(x => x.IndicatorDefinitionId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public void Configure(EntityTypeBuilder<FormValidation> builder)
    {
        builder.HasKey(x => x.FormValidationId);

        builder.HasOne<Researcher>()
            .WithMany()
            .HasForeignKey(x => x.ResearcherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(x => x.ReviewerUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public void Configure(EntityTypeBuilder<FieldReviewDetail> builder)
    {
        builder.HasKey(x => x.FieldReviewDetailId);

        builder.HasOne<FormValidation>()
            .WithMany()
            .HasForeignKey(x => x.FormValidationId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public void Configure(EntityTypeBuilder<ValidationEvidence> builder)
    {
        builder.HasKey(x => x.ValidationEvidenceId);

        builder.HasOne<FieldReviewDetail>()
            .WithMany()
            .HasForeignKey(x => x.FieldReviewDetailId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public void Configure(EntityTypeBuilder<ImportedRecord> builder)
    {
        builder.HasKey(x => x.ImportedRecordId);

        builder.HasOne<ImportBatch>()
            .WithMany()
            .HasForeignKey(x => x.ImportBatchId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

