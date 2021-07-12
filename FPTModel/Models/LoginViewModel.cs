using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FPTModel.Models
{
    public class LoginViewModel
    {
        [Required]
        
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int Role_ID { get; set; }

    }
}