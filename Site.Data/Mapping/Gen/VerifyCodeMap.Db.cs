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
    public partial class VerifyCodeMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site.Models.VerifyCode>
    {
        public VerifyCodeMap()
        {
            // table
            ToTable("VerifyCode", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.VerifyText)
                .HasColumnName("VerifyText")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Guid)
                .HasColumnName("Guid")
                .IsRequired();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}
