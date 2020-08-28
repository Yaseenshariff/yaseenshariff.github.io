using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpanishFootballLeague.Models
{
    public class TeamsDto
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamShortName { get; set; }
        public DateTime? Metric_DateTimeCreated { get; set; }
        public string Disable { get; set; }
        public string Group { get; set; }
        public byte[] TeamImage { get; set; }
    }
}