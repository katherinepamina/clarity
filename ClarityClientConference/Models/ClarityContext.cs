using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ClarityClientConference.Models
{
    public class ClarityContext : DbContext
    {
        public ClarityContext() : base("ClarityClientConference")
        {

        }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}