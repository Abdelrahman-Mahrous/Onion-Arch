using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OA.Wep.Models
{
    public class UserViewModel
    {
        [HiddenInput]
        public int ID { get; set; }  
        
        [Display(Name ="User Name")]
        [Required]
        public string UserName { get; set; }

        
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Display(Name = "User Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
