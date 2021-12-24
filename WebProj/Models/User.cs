using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProj.Models
{
    public class User
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        [MaxLength(10)]
        public string phone { get; set; }
    }
}
