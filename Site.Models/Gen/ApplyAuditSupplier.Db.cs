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
using System.Text;

namespace Site.Models
{
    public partial class ApplyAuditSupplier
    {
        public ApplyAuditSupplier()
        {
        }

        ///
        public int Id { get; set; }
        ///
        public int? Status { get; set; }
        ///
        public int? ApplyFactoryId { get; set; }
        ///
        public int? AuditFactoryId { get; set; }
        ///
        public string ApplyRemark { get; set; }
        ///
        public string AuditRemark { get; set; }
        ///
        public int? ApplyUserId { get; set; }
        ///
        public int? AuditUserId { get; set; }
        ///
        public System.DateTime? AuditTime { get; set; }
        ///
        public int? ApplyDelete { get; set; }
        ///
        public int? AuditDelete { get; set; }
        ///
        public System.DateTime? CreateTime { get; set; }

    }
}