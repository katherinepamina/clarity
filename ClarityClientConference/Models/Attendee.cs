using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClarityClientConference.Models
{
    public class Attendee
    {
        [ScaffoldColumn(false)]
        public int AttendeeID { get; set; }

        [Required]
        public int ClientID { get; set; }

        [Required, Display(Name = "Name")]
        public string Name { get; set; }

        [Required, Display(Name = "Email")]
        public string Email { get; set; }

    }
}