﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace stajrapor.Models
{
    public class UserProfile
    {
        
        public string id { get; set; }
        [Required]
        [DisplayName("Adı")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Soyadı")]
        public string  Surname { get; set; }
        [Required]
        [DisplayName("Kullamıcı Adı")]
        public string Username { get; set; }
        [Required]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Geçerli email adresi giriniz!")]
        public string Email { get; set; }





    }
}