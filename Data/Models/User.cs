using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User
    {
        public string Username { get; set; }
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{5,}$", ErrorMessage = "Password must be at least 5 characters long and contain at least one uppercase letter, one lowercase letter, and one digit.")]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime? LastLoginTime { get; set; }
    }
}
