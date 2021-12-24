using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationApi.Models
{
    public class UserModel
    {
        [Key]
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

        public UserModel() { }

        public UserModel(string username,string email,string password,string phone)
        {
            this.Username = username;
            this.EmailAddress = email;
            this.password = password;
            this.phone = phone;
        }
    }
}