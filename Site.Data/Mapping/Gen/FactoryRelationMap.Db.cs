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
    public partial class FactoryRelationMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site.Models.FactoryRelation>
    {
        public FactoryRelationMap()
        {
            // table
            ToTable("FactoryRelation", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.FactoryId)
                .HasColumnName("FactoryId")
                .IsOptional();
            Property(t => t.FactoryId2)
                .HasColumnName("FactoryId2")
                .IsOptional();
            Property(t => t.Levels)
                .HasColumnName("Levels")
                .IsOptional();
            Property(t => t.Status)
                .HasColumnName("Status")
                .IsOptional();
            Property(t => t.Des)
                .HasColumnName("Des")
                .HasMaxLength(500)
                .IsOptional();
            Property(t => t.Pic)
                .HasColumnName("Pic")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.EditUserId)
                .HasColumnName("EditUserId")
                .IsOptional();
            Property(t => t.UserId)
                .HasColumnName("UserId")
                .IsOptional();
            Property(t => t.EditTime)
                .HasColumnName("EditTime")
                .IsOptional();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}