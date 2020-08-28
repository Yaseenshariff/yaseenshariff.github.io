using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpanishFootballLeague.Models
{
    public class MatchesDto
    {
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public DateTime? MatchDate { get; set; }
        public string Status { get; set; }
        public string TeamWon { get; set; }
    }
}