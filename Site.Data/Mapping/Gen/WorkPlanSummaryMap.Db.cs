﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Site.Data.Mapping
{
    public partial class WorkPlanSummaryMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site.Models.WorkPlanSummary>
    {
        public WorkPlanSummaryMap()
        {
            // table
            ToTable("WorkPlanSummary", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.UserId)
                .HasColumnName("UserId")
                .IsOptional();
            Property(t => t.FactoryId)
                .HasColumnName("FactoryId")
                .IsOptional();
            Property(t => t.Type)
                .HasColumnName("Type")
                .IsOptional();
            Property(t => t.DateType)
                .HasColumnName("DateType")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Date)
                .HasColumnName("Date")
                .IsOptional();
            Property(t => t.Contents)
                .HasColumnName("Contents")
                .HasMaxLength(500)
                .IsOptional();
            Property(t => t.QtyRemark)
                .HasColumnName("QtyRemark")
                .HasMaxLength(500)
                .IsOptional();
            Property(t => t.Question)
                .HasColumnName("Question")
                .HasMaxLength(500)
                .IsOptional();
            Property(t => t.Solution)
                .HasColumnName("Solution")
                .HasMaxLength(500)
                .IsOptional();
            Property(t => t.Advise)
                .HasColumnName("Advise")
                .HasMaxLength(500)
                .IsOptional();
            Property(t => t.Consciousness)
                .HasColumnName("Consciousness")
                .HasMaxLength(500)
                .IsOptional();
            Property(t => t.EditUserId)
                .HasColumnName("EditUserId")
                .IsOptional();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsOptional();
            Property(t => t.EditTime)
                .HasColumnName("EditTime")
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}
