using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClarityClientConference.Models
{
    public class Client
    {
        [ScaffoldColumn(false)]
        public int ClientID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string Name { get; set; }

        [Required, Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required, Display(Name = "Email")]
        public string Email { get; set; }

        [Required, Display(Name = "Street")]
        public string Street { get; set; }

        [Required, Display(Name = "City")]
        public string City { get; set; }

        [Required, Display(Name = "State")]
        public string State { get; set; }

        [Required, Display(Name = "ZipCode")]
        public int ZipCode { get; set; }

    }
}