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
    public partial class FactoryMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site.Models.Factory>
    {
        public FactoryMap()
        {
            // table
            ToTable("Factory", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.Type)
                .HasColumnName("Type")
                .IsOptional();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(100)
                .IsOptional();
            Property(t => t.LegalPerson)
                .HasColumnName("LegalPerson")
                .HasMaxLength(20)
                .IsOptional();
            Property(t => t.LinkPerson)
                .HasColumnName("LinkPerson")
                .HasMaxLength(20)
                .IsOptional();
            Property(t => t.Tel1)
                .HasColumnName("Tel1")
                .HasMaxLength(20)
                .IsOptional();
            Property(t => t.Tel2)
                .HasColumnName("Tel2")
                .HasMaxLength(20)
                .IsOptional();
            Property(t => t.Mobile1)
                .HasColumnName("Mobile1")
                .HasMaxLength(20)
                .IsOptional();
            Property(t => t.Mobile2)
                .HasColumnName("Mobile2")
                .HasMaxLength(20)
                .IsOptional();
            Property(t => t.Qq)
                .HasColumnName("QQ")
                .HasMaxLength(20)
                .IsOptional();
            Property(t => t.Email)
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Area)
                .HasColumnName("Area")
                .IsOptional();
            Property(t => t.AreaName)
                .HasColumnName("AreaName")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Address)
                .HasColumnName("Address")
                .HasMaxLength(500)
                .IsOptional();
            Property(t => t.Intro)
                .HasColumnName("Intro")
                .HasMaxLength(1000)
                .IsOptional();
            Property(t => t.Coordinates)
                .HasColumnName("Coordinates")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.IsDelete)
                .HasColumnName("IsDelete")
                .IsOptional();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsOptional();
            //Property(t => t.Geom)
            //    .HasColumnName("Geom")
            //    .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}
