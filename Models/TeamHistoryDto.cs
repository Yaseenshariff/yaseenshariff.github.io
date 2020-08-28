using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpanishFootballLeague.Models
{
    public class TeamHistoryDto
    {
        public int? TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamShortName { get; set; }
        public int? Played { get; set; }
        public int? Won { get; set; }
        public int? Drawn { get; set; }
        public int? Lost { get; set; }
        public int? GoalsForward { get; set; }
        public int? GoalsAgainst { get; set; }
        public byte[] TeamImage { get; set; }
    }
}