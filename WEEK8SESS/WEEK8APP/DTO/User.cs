using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WEEK8APP.Models;

namespace WEEK8APP.DTO
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        
        [Display(Name = "Fullname"), Required]
        public string FullName { get; set; }

        [Display(Name = "Email"), Required]
        public string Email { get; set; }

        [Display(Name = "Nida Number")]
        public string NidaNumber { get; set; }

        //[Display(Name = "Password"), Required]
        //public string Password { get; set; }

        //public string ConfirmPassword { get; set; }

        public string mobile { get; set; }



    }
}
