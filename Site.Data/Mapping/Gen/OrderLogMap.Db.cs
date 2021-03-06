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
    public partial class OrderLogMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site.Models.OrderLog>
    {
        public OrderLogMap()
        {
            // table
            ToTable("OrderLog", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.OrderId)
                .HasColumnName("OrderId")
                .IsOptional();
            Property(t => t.UserId)
                .HasColumnName("UserId")
                .IsOptional();
            Property(t => t.UserName)
                .HasColumnName("UserName")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Action)
                .HasColumnName("Action")
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
