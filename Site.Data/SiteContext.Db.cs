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
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Infrastructure;
using Site.Data.Interceptor;
using System.Data.Entity;
using Site.Models;

namespace Site.Data
{
    public partial class SiteContext
        : DbContext
    {
        public SiteContext()
            :base("Name=SiteContext")
        {
//#if DEBUG
//            DbInterception.Add(new LogInterceptor());
//#endif
            DbInterception.Add(new CommandInterceptor());
        }

        public SiteContext(System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base("Name=SiteContext", model)
        { }

        public SiteContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        { }

        public SiteContext(string nameOrConnectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(nameOrConnectionString, model)
        { } 

        public DbSet<Ad> Ads { get; set; }
        public DbSet<ApplyAuditSupplier> ApplyAuditSuppliers { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<BackVisitRecord> BackVisitRecords { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerVisitRecord> CustomerVisitRecords { get; set; }
        public DbSet<DateNorm> DateNorms { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<FactoryBank> FactoryBanks { get; set; }
        public DbSet<FactoryBrand> FactoryBrands { get; set; }
        public DbSet<FactoryCustomerVisitRecord> FactoryCustomerVisitRecords { get; set; }
        public DbSet<FactoryLevelRatio> FactoryLevelRatios { get; set; }
        public DbSet<FactoryPic> FactoryPics { get; set; }
        public DbSet<FactoryRelation> FactoryRelations { get; set; }
        public DbSet<FinanceRecord> FinanceRecords { get; set; }
        public DbSet<FinanceRecordPrivate> FinanceRecordPrivates { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<FurnitureKinds> FurnitureKinds { get; set; }
        public DbSet<Kinds> Kinds { get; set; }
        public DbSet<FurniturePic> FurniturePics { get; set; }
        public DbSet<FurnitureSizePrice> FurnitureSizePrices { get; set; }
        public DbSet<Log4net> Log4nets { get; set; }
        public DbSet<LoginInfo> LoginInfos { get; set; }
        public DbSet<Logistics> Logistics { get; set; }
        public DbSet<LogisticsLine> LogisticsLines { get; set; }
        public DbSet<Notify> Notifies { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<OrderLog> OrderLogs { get; set; }
        public DbSet<RecommendSupplier> RecommendSuppliers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SysDic> SysDics { get; set; }
        public DbSet<Temp6402> Temp6402s { get; set; }
        public DbSet<ThirdLinks> ThirdLinks { get; set; }
        public DbSet<TrackRecord> TrackRecords { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<VerifyCode> VerifyCodes { get; set; }
        public DbSet<VersionRecord> VersionRecords { get; set; }
        public DbSet<WorkAttendance> WorkAttendances { get; set; }
        public DbSet<WorkBusiness> WorkBusinesses { get; set; }
        public DbSet<WorkEvent> WorkEvents { get; set; }
        public DbSet<WorkPlanSummary> WorkPlanSummaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Site.Data.Mapping.AdMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.ApplyAuditSupplierMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.AuditLogMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.BackVisitRecordMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.CustomerMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.CustomerVisitRecordMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.DateNormMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.EmployeeMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FactoryMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FactoryBankMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FactoryBrandMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FactoryCustomerVisitRecordMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FactoryLevelRatioMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FactoryPicMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FactoryRelationMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FinanceRecordMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FinanceRecordPrivateMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FurnitureMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FurnitureKindsMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.KindsMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FurniturePicMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.FurnitureSizePriceMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.Log4netMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.LoginInfoMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.LogisticsMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.LogisticsLineMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.NotifyMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.OfficeMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.OrderMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.OrderItemsMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.OrderLogMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.RecommendSupplierMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.RoleMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.SysDicMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.Temp6402Map());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.ThirdLinksMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.TrackRecordMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.UserMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.UserDetailMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.UserRoleMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.VerifyCodeMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.VersionRecordMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.WorkAttendanceMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.WorkBusinessMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.WorkEventMap());
            modelBuilder.Configurations.Add(new Site.Data.Mapping.WorkPlanSummaryMap());

            InitializeMapping(modelBuilder);
            
        }
    }
}