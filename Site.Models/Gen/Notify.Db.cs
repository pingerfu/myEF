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
    public partial class Notify
    {
        public Notify()
        {
        }

        ///
        public int Id { get; set; }
        ///
        public int? Type { get; set; }
        ///
        public int? SendUserId { get; set; }
        ///
        public int? ReceiveUserId { get; set; }
        ///
        public int? SendFactoryId { get; set; }
        ///
        public int? ReceiveFactoryId { get; set; }
        ///
        public string Title { get; set; }
        ///
        public string Msg { get; set; }
        ///
        public int? Status { get; set; }
        ///
        public System.DateTime? CreateTime { get; set; }

    }
}