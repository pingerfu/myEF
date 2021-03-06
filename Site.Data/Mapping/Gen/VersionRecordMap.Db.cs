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
    public partial class VersionRecordMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site.Models.VersionRecord>
    {
        public VersionRecordMap()
        {
            // table
            ToTable("VersionRecord", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.VersionNo)
                .HasColumnName("VersionNo")
                .HasMaxLength(100)
                .IsOptional();
            Property(t => t.Url)
                .HasColumnName("Url")
                .HasMaxLength(500)
                .IsOptional();
            Property(t => t.Des)
                .HasColumnName("Des")
                .HasMaxLength(500)
                .IsOptional();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsOptional();
            Property(t => t.Type)
                .HasColumnName("Type")
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}
