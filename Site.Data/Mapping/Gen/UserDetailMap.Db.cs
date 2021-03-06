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
    public partial class UserDetailMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site.Models.UserDetail>
    {
        public UserDetailMap()
        {
            // table
            ToTable("UserDetail", "dbo");

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
            Property(t => t.Sex)
                .HasColumnName("Sex")
                .IsOptional();
            Property(t => t.Pic)
                .HasColumnName("Pic")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.Qq)
                .HasColumnName("QQ")
                .HasMaxLength(20)
                .IsOptional();
            Property(t => t.Birthday)
                .HasColumnName("Birthday")
                .IsOptional();
            Property(t => t.WeChat)
                .HasColumnName("WeChat")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.BankName)
                .HasColumnName("BankName")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.BankAccountName)
                .HasColumnName("BankAccountName")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.BankAccount)
                .HasColumnName("BankAccount")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Salary)
                .HasColumnName("Salary")
                .HasPrecision(18, 2)
                .IsOptional();
            Property(t => t.SalaryRecord)
                .HasColumnName("SalaryRecord")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.CardNo)
                .HasColumnName("CardNo")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Post)
                .HasColumnName("Post")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.JoinDate)
                .HasColumnName("JoinDate")
                .IsOptional();
            Property(t => t.FormalDate)
                .HasColumnName("FormalDate")
                .IsOptional();
            Property(t => t.LeaveDate)
                .HasColumnName("LeaveDate")
                .IsOptional();
            Property(t => t.Alipay)
                .HasColumnName("Alipay")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Address)
                .HasColumnName("Address")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.AddressHome)
                .HasColumnName("AddressHome")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.ExigenceLinkPerson)
                .HasColumnName("ExigenceLinkPerson")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.ExigenceLinkMobile)
                .HasColumnName("ExigenceLinkMobile")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}
