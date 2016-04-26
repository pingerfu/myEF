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
    public partial class CustomerMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site.Models.Customer>
    {
        public CustomerMap()
        {
            // table
            ToTable("Customer", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Mobile1)
                .HasColumnName("Mobile1")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Tel1)
                .HasColumnName("Tel1")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Sex)
                .HasColumnName("Sex")
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
            Property(t => t.Remark)
                .HasColumnName("Remark")
                .HasMaxLength(500)
                .IsOptional();
            Property(t => t.Levels)
                .HasColumnName("Levels")
                .IsOptional();
            Property(t => t.Pic)
                .HasColumnName("Pic")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.Coordinates)
                .HasColumnName("Coordinates")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.FactoryId)
                .HasColumnName("FactoryId")
                .IsOptional();
            Property(t => t.UserId)
                .HasColumnName("UserId")
                .IsOptional();
            Property(t => t.IsDelete)
                .HasColumnName("IsDelete")
                .IsOptional();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}
