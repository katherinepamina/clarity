using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClarityClientConference.Models;

namespace ClarityClientConference.Models
{
    public class AttendeeManager
    {
        private ClarityContext cc = new ClarityContext();
        
        public void Add(string name, string email, int client)
        {
            Attendee attendee = new Attendee();
            attendee.Name = name;
            attendee.Email = email;
            attendee.ClientID = client;
            cc.Attendees.Add(attendee);
            cc.SaveChanges();
        }
    }
}