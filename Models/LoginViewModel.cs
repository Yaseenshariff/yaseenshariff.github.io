using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SpanishFootballLeague.Models
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("User Name : ")]
        [StringLength(100, ErrorMessage = "A maximum of 100 characters are allowed")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Password : ")]
        [StringLength(50, ErrorMessage = "A maximum of 50 characters are allowed")]
        public string Password { get; set; }
    }
}