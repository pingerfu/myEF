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
    public partial class FactoryLevelRatio
    {
        public FactoryLevelRatio()
        {
        }

        ///
        public int Id { get; set; }
        ///
        public int? FactoryId { get; set; }
        ///
        public int? Levels { get; set; }
        ///
        public decimal? Ratio { get; set; }
        ///
        public System.DateTime? CreateTime { get; set; }

    }
}