//using System;
//using System.Collections.Generic;
//using System.Text;
using Microsoft.EntityFrameworkCore;
using NationalResearchers.Entities;

namespace NationalResearchers.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<Permission> Permissions => Set<Permission>();
    public DbSet<Token> Tokens => Set<Token>();
    public DbSet<AuditLog> AuditLogs => Set<AuditLog>();
    public DbSet<Notification> Notifications => Set<Notification>();

    public DbSet<Researcher> Researchers => Set<Researcher>();
    public DbSet<Organization> Organizations => Set<Organization>();
    public DbSet<Qualification> Qualifications => Set<Qualification>();
    public DbSet<ExternalAcademicLink> ExternalAcademicLinks => Set<ExternalAcademicLink>();

    public DbSet<ResearcherRequest> ResearcherRequests => Set<ResearcherRequest>();
    public DbSet<WorkEvaluation> WorkEvaluations => Set<WorkEvaluation>();
    public DbSet<Participation> Participations => Set<Participation>();
    public DbSet<ScientificProduction> ScientificProductions => Set<ScientificProduction>();
    public DbSet<ScientificProductionReport> ScientificProductionReports
        => Set<ScientificProductionReport>();

    public DbSet<ResearchSpecialty> ResearchSpecialties => Set<ResearchSpecialty>();
    public DbSet<ResearchInterest> ResearchInterests => Set<ResearchInterest>();
    public DbSet<EventAnnouncement> EventAnnouncements => Set<EventAnnouncement>();

    public DbSet<ImportBatch> ImportBatches => Set<ImportBatch>();
    public DbSet<ImportedRecord> ImportedRecords => Set<ImportedRecord>();

    public DbSet<ResearcherExternalIndicator> ResearcherExternalIndicators
        => Set<ResearcherExternalIndicator>();

    public DbSet<IndicatorDefinition> IndicatorDefinitions => Set<IndicatorDefinition>();
    public DbSet<IndicatorSnapshot> IndicatorSnapshots => Set<IndicatorSnapshot>();

    public DbSet<FormValidation> FormValidations => Set<FormValidation>();
    public DbSet<FieldReviewDetail> FieldReviewDetails => Set<FieldReviewDetail>();
    public DbSet<ValidationEvidence> ValidationEvidences => Set<ValidationEvidence>();

    // الجداول الوسيطة
    public DbSet<UserRole> UserRoles => Set<UserRole>();
    public DbSet<RolePermission> RolePermissions => Set<RolePermission>();
    public DbSet<ResearcherQualification> ResearcherQualifications
        => Set<ResearcherQualification>();

    public DbSet<ResearcherParticipation> ResearcherParticipations
        => Set<ResearcherParticipation>();

    public DbSet<ResearcherScientificProduction> ResearcherScientificProductions
        => Set<ResearcherScientificProduction>();

    public DbSet<ResearcherOrganizationAffiliation>
        ResearcherOrganizationAffiliations
        => Set<ResearcherOrganizationAffiliation>();

    //public DbSet<ResearcherSpecialty> ResearcherSpecialties
       // => Set<ResearcherSpecialty>();

   // public DbSet<ResearcherInterest> ResearcherInterests
       // => Set<ResearcherInterest>();

    public DbSet<ResearchSpecialtyAnnouncement>
        ResearchSpecialtyAnnouncements
        => Set<ResearchSpecialtyAnnouncement>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly);
    }

}
