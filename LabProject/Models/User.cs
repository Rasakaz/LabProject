﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LabProject.Models
{
    public class User
    {

        [Required(ErrorMessage = "field is must")]
        [Key]
        public string UserName { get; set; }

        /*
        [Required(ErrorMessage = "please choose your user type")]
        public string UserType { get; set; }
        */

        [Required(ErrorMessage = "field is must")]
        public string Password { get; set; }


        [Required(ErrorMessage = "field is must")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "field is must")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "field is must")]
        public string Address { get; set; }

    }

}
