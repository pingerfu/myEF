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
    public partial class FactoryCustomerVisitRecord
    {
        public FactoryCustomerVisitRecord()
        {
        }

        ///
        public int Id { get; set; }
        ///
        public int? FactoryId { get; set; }
        ///
        public int? FactoryId2 { get; set; }
        ///
        public int? UserId { get; set; }
        ///
        public System.DateTime? VisitTime { get; set; }
        ///
        public string Contents { get; set; }
        ///
        public string Type { get; set; }
        ///
        public System.DateTime? CreateTime { get; set; }

    }
}