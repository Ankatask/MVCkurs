using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Day1Demo2.Models
{
    public class Guest
    {
        [Required(ErrorMessage="Please enter your neme")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public bool WillAttend { get; set; }
    }
}