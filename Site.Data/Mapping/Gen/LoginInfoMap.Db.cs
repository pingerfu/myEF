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
    public partial class LoginInfoMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site.Models.LoginInfo>
    {
        public LoginInfoMap()
        {
            // table
            ToTable("LoginInfo", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.LoginToken)
                .HasColumnName("LoginToken")
                .IsRequired();
            Property(t => t.LastAccessTime)
                .HasColumnName("LastAccessTime")
                .IsRequired();
            Property(t => t.UserID)
                .HasColumnName("UserID")
                .IsRequired();
            Property(t => t.LoginName)
                .HasColumnName("LoginName")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.BusinessPermissionString)
                .HasColumnName("BusinessPermissionString")
                .HasMaxLength(4000)
                .IsOptional();
            Property(t => t.ClientIP)
                .HasColumnName("ClientIP")
                .HasMaxLength(90)
                .IsOptional();
            Property(t => t.EnumLoginAccountType)
                .HasColumnName("EnumLoginAccountType")
                .IsRequired();
            Property(t => t.Mobile)
                .HasColumnName("Mobile")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.FactoryId)
                .HasColumnName("FactoryId")
                .IsOptional();
            Property(t => t.Type)
                .HasColumnName("Type")
                .IsOptional();
            Property(t => t.TrueName)
                .HasColumnName("TrueName")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}