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
    
    public partial class PremierLeague_Standings
    {
        public int StandingsId { get; set; }
        public int TeamId { get; set; }
        public int Played { get; set; }
        public int Won { get; set; }
        public int Drawn { get; set; }
        public int Lost { get; set; }
        public Nullable<int> GoalsForward { get; set; }
        public Nullable<int> GoalsAgainst { get; set; }
        public Nullable<int> GoalDifference { get; set; }
        public Nullable<int> Points { get; set; }
        public Nullable<System.DateTime> Metric_DateTimeCreated { get; set; }
        public byte[] TeamImage { get; set; }
    }
}
