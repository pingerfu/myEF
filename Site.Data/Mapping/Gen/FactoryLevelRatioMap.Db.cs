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
    public partial class FactoryLevelRatioMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site.Models.FactoryLevelRatio>
    {
        public FactoryLevelRatioMap()
        {
            // table
            ToTable("FactoryLevelRatio", "dbo");

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
            Property(t => t.Levels)
                .HasColumnName("Levels")
                .IsOptional();
            Property(t => t.Ratio)
                .HasColumnName("Ratio")
                .HasPrecision(18, 2)
                .IsOptional();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}