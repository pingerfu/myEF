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
    public partial class RoleMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site.Models.Role>
    {
        public RoleMap()
        {
            // table
            ToTable("Role", "dbo");

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
                .IsRequired();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsRequired();
            Property(t => t.Info)
                .HasColumnName("Info")
                .HasMaxLength(300)
                .IsOptional();
            Property(t => t.BusinessPermissionString)
                .HasColumnName("BusinessPermissionString")
                .HasMaxLength(4000)
                .IsOptional();
            Property(t => t.ForSys)
                .HasColumnName("ForSys")
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}
