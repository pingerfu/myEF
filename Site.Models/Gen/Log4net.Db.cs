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
    public partial class Log4net
    {
        public Log4net()
        {
        }

        ///
        public int Id { get; set; }
        ///
        public string Level { get; set; }
        ///
        public string Logger { get; set; }
        ///
        public string Host { get; set; }
        ///
        public System.DateTime? Date { get; set; }
        ///
        public string Thread { get; set; }
        ///
        public string Message { get; set; }
        ///
        public string Exception { get; set; }

    }
}