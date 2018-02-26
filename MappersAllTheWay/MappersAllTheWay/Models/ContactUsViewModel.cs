using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MappersAllTheWay.Models
{
    public class ContactUsViewModel
    {
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name is required")]
        [MaxLength(80,ErrorMessage = "Max 80 chars are allowed.")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "last name is required")]
        [MaxLength(80, ErrorMessage = "Max 80 chars are allowed.")]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name is required")]
        [MaxLength(10, ErrorMessage = "Max 10 chars are allowed.")]
        public string Phone { get; set; }
        [MaxLength(500, ErrorMessage = "Max 500 chars are allowed.")]
        public string Comments { get; set; }
    }
}