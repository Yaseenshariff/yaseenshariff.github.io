//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpanishFootballLeague.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public Nullable<int> UserGroup { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<int> UpdatedByID { get; set; }
        public string DateLastUpdated { get; set; }
        public string Disable { get; set; }
        public string Roles { get; set; }
        public Nullable<System.DateTime> Metric_DateTimeCreated { get; set; }
    }
}
