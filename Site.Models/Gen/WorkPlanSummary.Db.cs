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
    public partial class WorkPlanSummary
    {
        public WorkPlanSummary()
        {
        }

        ///
        public int Id { get; set; }
        ///
        public int? UserId { get; set; }
        ///
        public int? FactoryId { get; set; }
        ///
        public int? Type { get; set; }
        ///
        public string DateType { get; set; }
        ///
        public System.DateTime? Date { get; set; }
        ///
        public string Contents { get; set; }
        ///
        public string QtyRemark { get; set; }
        ///
        public string Question { get; set; }
        ///
        public string Solution { get; set; }
        ///
        public string Advise { get; set; }
        ///
        public string Consciousness { get; set; }
        ///
        public int? EditUserId { get; set; }
        ///
        public System.DateTime? CreateTime { get; set; }
        ///
        public System.DateTime? EditTime { get; set; }

    }
}