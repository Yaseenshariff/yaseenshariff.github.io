using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpanishFootballLeague.Models
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public Nullable<int> UserGroup { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Disable { get; set; }
    }
}